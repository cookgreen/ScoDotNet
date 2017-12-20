#ifndef SCO_H_GUARD
#define SCO_H_GUARD

#define SCO_MAGIC -717
#define GROUND_PAINT_MAGIC -11873882
#define GROUND_PAINT_ELEVATION_MAGIC -7793
#define GROUND_PAINT_LEVELING_MAGIC -12565

typedef struct vector
{
	float x;
	float y;
	float z;
} vector_t;

typedef struct matrix
{
	vector_t v0;
	vector_t v1;
	vector_t v2;
	vector_t o;
} matrix_t;

typedef struct ground_paint_layer
{
	char *ground_spec_id;
	int ground_spec_no;
	int *continuity_count;
	float *cells;
} ground_paint_layer_t;

typedef struct ground_paint
{
	int size_x;
	int size_y;
	int num_layers;
	ground_paint_layer_t *layers;
} ground_paint_t;

typedef struct ai_mesh_vertex
{
	vector_t position;
} ai_mesh_vertex_t;

typedef struct ai_mesh_edge
{
	int start_vertex;
	int end_vertex;
} ai_mesh_edge_t;

typedef struct ai_mesh_face
{
	int num_vertices;
	int vertices[4];
	int edges[4];
	int unknown;
} ai_mesh_face_t;

typedef struct ai_mesh
{
	int num_vertices;
	int num_edges;
	int num_faces;
	ai_mesh_vertex_t *vertices;
	ai_mesh_edge_t *edges;
	ai_mesh_face_t *faces;
} ai_mesh_t;

typedef struct mission_object
{
	char *id;
	int meta_type; // 0 = scene prop, 1 = entry point, 2 = scene item, 4 = flora, 5 = passage
	int sub_kind_no;
	int variation_id;
	int variation_id_2;
	matrix_t position;
	vector_t scale;
} mission_object_t;

typedef struct sco_file
{
	int version;
	int num_mission_objects;
	mission_object_t *mission_objects;
	ai_mesh_t *ai_mesh;
	ground_paint_t *ground_paint;
} sco_file_t;

#endif

