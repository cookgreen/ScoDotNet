#include <stdio.h>
#include <string.h>
#include "sco.h"

void write(FILE *file, size_t size, void *src)
{
	if(src)
		fwrite(src, size, 1, file);
}

void write_int(FILE *file, int src)
{
	write(file, 4, &src);
}

void write_char(FILE *file, char src)
{
	write(file, 1, &src);
}

void write_float(FILE *file, float src)
{
	write(file, 4, &src);
}

void write_string(FILE *file, char *src)
{
	int length = strlen(src);

	write_int(file, length);
	write(file, length, src);
}

void write_vector(FILE *file, vector_t *src)
{
	write_float(file, src->x);
	write_float(file, src->y);
	write_float(file, src->z);
}

void write_matrix(FILE *file, matrix_t *src)
{
	write_vector(file, &src->v0);
	write_vector(file, &src->v1);
	write_vector(file, &src->v2);
	write_vector(file, &src->o);
}

void write_sco_file(FILE *file, sco_file_t *src)
{
	fseek(file, 0, SEEK_SET);

	write_int(file, SCO_MAGIC);
	write_int(file, src->version);
	write_int(file, src->num_mission_objects);

	printf("SCO file version: %d\n", src->version);
	printf("Mission object count: %d\n", src->num_mission_objects);

	int lcv;
	for(lcv = 0; lcv < src->num_mission_objects; ++lcv)
	{
		write_int(file, src->mission_objects[lcv].meta_type);
		write_int(file, src->mission_objects[lcv].sub_kind_no);
		fseek(file, 4, SEEK_CUR); // unused
		write_matrix(file, &src->mission_objects[lcv].position);
		write_string(file, src->mission_objects[lcv].id);
		write_int(file, src->mission_objects[lcv].variation_id);

		if(src->version >= 2)
			write_int(file, src->mission_objects[lcv].variation_id_2);

		if(src->version >= 3)
			write_vector(file, &src->mission_objects[lcv].scale);
	}

	long start_pos;
	long end_pos;

	/// AI mesh

	fseek(file, 4, SEEK_CUR); //placeholder

	start_pos = ftell(file);

	write_int(file, src->ai_mesh->num_vertices);
	printf("AI mesh vertex count: %d\n", src->ai_mesh->num_vertices);
	for(lcv = 0; lcv < src->ai_mesh->num_vertices; ++lcv)
		write_vector(file, &src->ai_mesh->vertices[lcv].position);

	write_int(file, src->ai_mesh->num_edges);
	printf("AI mesh edge count: %d\n", src->ai_mesh->num_edges);
	for(lcv = 0; lcv < src->ai_mesh->num_edges; ++lcv)
	{
		fseek(file, 4, SEEK_CUR); // unused
		write_int(file, src->ai_mesh->edges[lcv].start_vertex);
		write_int(file, src->ai_mesh->edges[lcv].end_vertex);
		fseek(file, 8, SEEK_CUR); // unused
	}

	write_int(file, src->ai_mesh->num_faces);
	printf("AI mesh face count: %d\n", src->ai_mesh->num_faces);
	int i;
	for(i = 0; i < src->ai_mesh->num_faces; ++i)
	{
		write_int(file, src->ai_mesh->faces[i].num_vertices);

		int j;
		for(j = 0; j < src->ai_mesh->faces[i].num_vertices; ++j)
			write_int(file, src->ai_mesh->faces[i].vertices[j]);

		for(j = 0; j < src->ai_mesh->faces[i].num_vertices; ++j)
			write_int(file, src->ai_mesh->faces[i].edges[j]);

		write_int(file, src->ai_mesh->faces[i].unknown);

		if(src->ai_mesh->faces[i].unknown > 0)
			write_int(file, src->ai_mesh->faces[i].unknown);
	}

	end_pos = ftell(file);

	fseek(file, start_pos - 4, SEEK_SET);
	write_int(file, end_pos - start_pos);
	fseek(file, end_pos, SEEK_SET);

	/// Ground paint

	write_int(file, GROUND_PAINT_MAGIC);

	fseek(file, 4, SEEK_CUR); // placeholder

	start_pos = ftell(file);

	write_int(file, src->ground_paint->num_layers);

	printf("Ground paint layer count: %d\n", src->ground_paint->num_layers);

	write_int(file, src->ground_paint->size_x);
	write_int(file, src->ground_paint->size_y);

	for(lcv = 0; lcv < src->ground_paint->num_layers; ++lcv)
	{
		write_int(file, src->ground_paint->layers[lcv].ground_spec_no);
		write_string(file, src->ground_paint->layers[lcv].ground_spec_id);

		write_int(file, src->ground_paint->layers[lcv].cells != NULL);

		if(src->ground_paint->layers[lcv].cells != NULL)
		{
			int empty = 1;
			int count = src->ground_paint->layers[lcv].continuity_count[src->ground_paint->size_x * src->ground_paint->size_y];
			write_int(file, count);

			int x, y;
			for(y = 0; y < src->ground_paint->size_y; ++y)
			{
				for(x = 0; x < src->ground_paint->size_x; ++x)
				{
					if(!count)
					{
						empty = !empty;
						count = src->ground_paint->layers[lcv].continuity_count[x * src->ground_paint->size_y + y];
						write_int(file, count);
					}

					--count;

					if(!empty)
					{
						float value = src->ground_paint->layers[lcv].cells[x * src->ground_paint->size_y + y];
						if(src->ground_paint->layers[lcv].ground_spec_no < 0)
							write_float(file, value);
						else
							write_char(file, value * 255.0f); // shady
					}
				}
			}
		}
	}

	end_pos = ftell(file);

	fseek(file, start_pos - 4, SEEK_SET);
	write_int(file, end_pos - start_pos);
	fseek(file, end_pos, SEEK_SET);

	fclose(file);
}

