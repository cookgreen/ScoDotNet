#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include "sco.h"

void read(FILE *file, size_t size, void *dest)
{
	if(dest)
		fread(dest, size, 1, file);
}

void read_int(FILE *file, int *dest)
{
	read(file, 4, dest);
}

void read_char(FILE *file, char *dest)
{
	read(file, 1, dest);
}

void read_float(FILE *file, float *dest)
{
	read(file, 4, dest);
}

void read_string(FILE *file, char **dest)
{
	int length;

	read_int(file, &length);
	*dest = (char*)malloc(length + 1);
	read(file, length, *dest);
	(*dest)[length] = '\0';
}

void read_vector(FILE *file, vector_t *dest)
{
	read_float(file, &dest->x);
	read_float(file, &dest->y);
	read_float(file, &dest->z);
}

void read_matrix(FILE *file, matrix_t *dest)
{
	read_vector(file, &dest->v0);
	read_vector(file, &dest->v1);
	read_vector(file, &dest->v2);
	read_vector(file, &dest->o);
}

void read_sco_file(FILE *file, sco_file_t *dest)
{
	fseek(file, 0, SEEK_END);

	long file_size = ftell(file);

	fseek(file, 0, SEEK_SET);

	int magic;

	read_int(file, &magic);

	if (magic == SCO_MAGIC)
	{
		read_int(file, &dest->version);
		read_int(file, &dest->num_mission_objects);
	}
	else
	{
		dest->version = 0;
		dest->num_mission_objects = magic;
	}

	printf("SCO file version: %d\n", dest->version);
	printf("Mission object count: %d\n", dest->num_mission_objects);

	dest->mission_objects = (mission_object_t*)malloc(dest->num_mission_objects * sizeof(mission_object_t));

	int lcv;

	for (lcv = 0; lcv < dest->num_mission_objects; ++lcv)
	{
		read_int(file, &dest->mission_objects[lcv].meta_type);
		read_int(file, &dest->mission_objects[lcv].sub_kind_no);
		fseek(file, 4, SEEK_CUR); // unused
		read_matrix(file, &dest->mission_objects[lcv].position);
		read_string(file, &dest->mission_objects[lcv].id);
		read_int(file, &dest->mission_objects[lcv].variation_id);

		if (dest->version >= 2)
			read_int(file, &dest->mission_objects[lcv].variation_id_2);
		else
			dest->mission_objects[lcv].variation_id_2 = 0;

		if (dest->version >= 3)
			read_vector(file, &dest->mission_objects[lcv].scale);
		else
		{
			dest->mission_objects[lcv].scale.x = 1.0f;
			dest->mission_objects[lcv].scale.y = 1.0f;
			dest->mission_objects[lcv].scale.z = 1.0f;
		}
	}

	if (dest->version >= 4)
	{
		int ai_mesh_size;

		read_int(file, &ai_mesh_size);

		long start_pos = ftell(file);

		dest->ai_mesh = (ai_mesh_t*)malloc(sizeof(ai_mesh_t));

		read_int(file, &dest->ai_mesh->num_vertices);
		dest->ai_mesh->vertices = (ai_mesh_vertex_t*)malloc(dest->ai_mesh->num_vertices * sizeof(ai_mesh_vertex_t));

		printf("AI mesh vertex count: %d\n", dest->ai_mesh->num_vertices);

		for (lcv = 0; lcv < dest->ai_mesh->num_vertices; ++lcv)
		{
			read_vector(file, &dest->ai_mesh->vertices[lcv].position);
		}

		read_int(file, &dest->ai_mesh->num_edges);
		dest->ai_mesh->edges = (ai_mesh_edge_t*)malloc(dest->ai_mesh->num_edges * sizeof(ai_mesh_edge_t));

		printf("AI mesh edge count: %d\n", dest->ai_mesh->num_edges);

		for (lcv = 0; lcv < dest->ai_mesh->num_edges; ++lcv)
		{
			fseek(file, 4, SEEK_CUR); // unused
			read_int(file, &dest->ai_mesh->edges[lcv].start_vertex);
			read_int(file, &dest->ai_mesh->edges[lcv].end_vertex);
			fseek(file, 8, SEEK_CUR); // unused
		}

		read_int(file, &dest->ai_mesh->num_faces);
		dest->ai_mesh->faces = (ai_mesh_face_t*)malloc(dest->ai_mesh->num_faces * sizeof(ai_mesh_face_t));

		printf("AI mesh face count: %d\n", dest->ai_mesh->num_faces);

		int i;
		for (i = 0; i < dest->ai_mesh->num_faces; ++i)
		{
			read_int(file, &dest->ai_mesh->faces[i].num_vertices);

			int j;
			for (j = 0; j < dest->ai_mesh->faces[i].num_vertices; ++j)
			{
				read_int(file, &dest->ai_mesh->faces[i].vertices[j]);
			}

			for (j = 0; j < dest->ai_mesh->faces[i].num_vertices; ++j)
			{
				read_int(file, &dest->ai_mesh->faces[i].edges[j]);
			}

			read_int(file, &dest->ai_mesh->faces[i].unknown);

			if (dest->ai_mesh->faces[i].unknown > 0)
				read_int(file, &dest->ai_mesh->faces[i].unknown);
			else
				dest->ai_mesh->faces[i].unknown = 0;
		}

		long end_pos = ftell(file);

		if (end_pos - start_pos != ai_mesh_size)
		{
			printf("ERROR: failed to read AI mesh\n");
			fclose(file);
			return;
		}
	}
	else
		dest->ai_mesh = NULL;

	if (ftell(file) != file_size)
	{
		read_int(file, &magic);

		if (magic != GROUND_PAINT_MAGIC)
		{
			printf("ERROR: wrong ground paint magic\n");
			fclose(file);
			free(dest);
			return;
		}

		int ground_paint_size;

		read_int(file, &ground_paint_size);

		long start_pos = ftell(file);

		dest->ground_paint = (ground_paint_t*)malloc(sizeof(ground_paint_t));

		read_int(file, &dest->ground_paint->num_layers);
		dest->ground_paint->layers = (ground_paint_layer_t*)malloc(dest->ground_paint->num_layers * sizeof(ground_paint_layer_t));

		printf("Ground paint layer count: %d\n", dest->ground_paint->num_layers);

		read_int(file, &dest->ground_paint->size_x);
		read_int(file, &dest->ground_paint->size_y);

		for(lcv = 0; lcv < dest->ground_paint->num_layers; ++lcv)
		{
			read_int(file, &dest->ground_paint->layers[lcv].ground_spec_no);
			read_string(file, &dest->ground_paint->layers[lcv].ground_spec_id);

			int has_cells;

			read_int(file, &has_cells);

			dest->ground_paint->layers[lcv].has_cells = has_cells;

			if(has_cells)
			{
				dest->ground_paint->layers[lcv].continuity_count = (int*)malloc((dest->ground_paint->size_x * dest->ground_paint->size_y + 1) * sizeof(int));
				dest->ground_paint->layers[lcv].cells = (float*)malloc(dest->ground_paint->size_x * dest->ground_paint->size_y * sizeof(float));

				int empty = 1;
				int count;

				read_int(file, &count);
				dest->ground_paint->layers[lcv].continuity_count[dest->ground_paint->size_x * dest->ground_paint->size_y] = count;

				int x, y;
				for(y = 0; y < dest->ground_paint->size_y; ++y)
				{
					for(x = 0; x < dest->ground_paint->size_x; ++x)
					{
						if(!count)
						{
							empty = !empty;
							read_int(file, &count);
							dest->ground_paint->layers[lcv].continuity_count[x * dest->ground_paint->size_y + y] = count;
						}

						count--;

						float value;

						if(empty)
						{
							if( dest->ground_paint->layers[lcv].ground_spec_no == GROUND_PAINT_LEVELING_MAGIC )
								value = -1.0f;
							else
								value = 0.0f;
						}
						else
						{
							if(dest->ground_paint->layers[lcv].ground_spec_no < 0)
								read_float(file, &value);
							else
							{
								char cvalue;

								read_char(file, &cvalue);
								value = cvalue / 255.0f;
							}
						}

						dest->ground_paint->layers[lcv].cells[x * dest->ground_paint->size_y + y] = value;
					}
				}
			}
			else
				dest->ground_paint->layers[lcv].cells = NULL;
		}

		long end_pos = ftell(file);

		if(end_pos - start_pos != ground_paint_size)
		{
			printf("ERROR: failed to read ground paint\n");
			fclose(file);
			return;
		}
	}
	else
		dest->ground_paint = NULL;

	fclose(file);
}

