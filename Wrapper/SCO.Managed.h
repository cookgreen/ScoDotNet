// SCO.Managed.h

#pragma once

#include "sco.h"
#include "scoReader.c"
#include "scoWriter.c"

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Runtime::InteropServices;

namespace SCO {
	namespace Managed{

		public ref class Vector
		{
		private:
			float x;
			float y;
			float z;
			vector_t* _vector;
		public:
			Vector()
			{
				_vector = new vector_t();
				x = 0;
				y = 0;
				z = 0;
			}
			Vector(vector_t* _nativePtr)
			{
				_vector = _nativePtr;
			}
			Vector(const Vector% _nativeObj)
			{

			}
			Vector(const vector_t &_nativeObj)
			{
				x = _nativeObj.x;
				y = _nativeObj.y;
				z = _nativeObj.z;
			}
			~Vector()
			{
				delete _vector;
			}
			Vector^ operator = (Vector^ v)
			{
				Vector^ nv=gcnew Vector();
				nv->x = v->x;
				nv->y = v->y;
				nv->z = v->z;
				return nv;
			}
			property float X
			{
				float get(){
					return x;
				}
				void set(float value)
				{
					x = value;
				}
			}
			property float Y
			{
				float get(){
					return y;
				}
				void set(float value)
				{
					y = value;
				}
			}
			property float Z
			{
				float get(){
					return z;
				}
				void set(float value)
				{
					z = value;
				}
			}
			property vector_t* NativePtr
			{
				vector_t* get()
				{
					return _vector;
				}
			}
			property vector_t Native
			{
				vector_t get()
				{
					vector_t v;
					v.x = x;
					v.y = y;
					v.z = z;
					return v;
				}
			}
		};
		public ref class Matrix
		{
		private:
			matrix_t* _matrix;
			Vector^ v0;
			Vector^ v1;
			Vector^ v2;
			Vector^ o;
		public:
			Matrix()
			{
				v0 = gcnew Vector();
				v1 = gcnew Vector();
				v2 = gcnew Vector();
				o = gcnew Vector();
			}
			Matrix(matrix_t* _nativePtr)
			{
				_matrix = _nativePtr;
			}
			Matrix(const Matrix% _nativeObj)
			{
				
			}
			Matrix(const matrix_t& _nativeObj)
			{
				v0 = gcnew Vector(_nativeObj.v0);
				v1 = gcnew Vector(_nativeObj.v1);
				v2 = gcnew Vector(_nativeObj.v2);
				o = gcnew Vector(_nativeObj.o);
			}
			~Matrix()
			{
				delete _matrix;
				delete v0;
				delete v1;
				delete v2;
				delete o;
			}
			Matrix^ operator = (Matrix^ m)
			{
				Matrix^ nm = gcnew Matrix();
				nm->O = m->O;
				nm->V0 = m->V0;
				nm->V1 = m->V1;
				nm->V2 = m->V2;
				return nm;
			}
			property Vector^ V0
			{
				Vector^ get()
				{
					return v0;
				}
				void set(Vector^ value)
				{
					v0 = value;
				}
			}
			property Vector^ V1
			{
				Vector^ get()
				{
					return v1;
				}
				void set(Vector^ value)
				{
					v1 = value;
				}
			}
			property Vector^ V2
			{
				Vector^ get()
				{
					return v2;
				}
				void set(Vector^ value)
				{
					v2 = value;
				}
			}
			property Vector^ O
			{
				Vector^ get()
				{
					return o;
				}
				void set(Vector^ value)
				{
					o = value;
				}
			}
			property matrix_t* NativePtr
			{
				matrix_t* get()
				{
					return _matrix;
				}
			}
			property matrix_t Native
			{
				matrix_t get()
				{
					matrix_t m;
					m.o = o->Native;
					m.v0 = v0->Native;
					m.v1 = v1->Native;
					m.v2 = v2->Native;
					return m;
				}
			}
		};
		public ref class GroundPaintLayer
		{
		private:
			ground_paint_layer_t* _gound_painter_layer;
			String^ groundSpecID;
			int groundSpecNo;
			int hasCells;
			array<int>^ continuityCount;
			array<float>^ cells;
		public:
			GroundPaintLayer(int continuityArrayCount, int cellArraycount)
			{
				_gound_painter_layer = new ground_paint_layer_t();
				groundSpecID = gcnew String("");
				groundSpecNo = 0;
				continuityCount = gcnew array<int>(continuityArrayCount);
				cells = gcnew array<float>(cellArraycount);
			}
			GroundPaintLayer(ground_paint_layer_t* _nativePtr)
			{
				this->_gound_painter_layer = _nativePtr;
			}
			GroundPaintLayer(ground_paint_layer_t _nativeObj)
			{
			}
			~GroundPaintLayer()
			{
				delete _gound_painter_layer;
				delete[] continuityCount;
				delete[] cells;
			}
			property int HasCells
			{
				int get() 
				{
					return hasCells;
				}
				void set(int hasCells)
				{
					this->hasCells = hasCells;
				}
			}
			property String^ GroundSpecID
			{
				String^ get()
				{
					//return gcnew String(_gound_painter_layer->ground_spec_id);
					return groundSpecID;
				}
				void set(String^ value)
				{
					//_gound_painter_layer->ground_spec_id = (char*)Marshal::StringToHGlobalAnsi(value).ToPointer();
					groundSpecID = value;
				}
			}
			property int GroundSpecNo
			{
				int get()
				{
					//return _gound_painter_layer->ground_spec_no;
					return groundSpecNo;
				}
				void set(int value)
				{
					//_gound_painter_layer->ground_spec_no = value;
					groundSpecNo = value;
				}
			}
			property array<int>^ ContinuityCount
			{
				array<int>^ get()
				{
					return continuityCount;
				}
				void set(array<int>^ value)
				{
					continuityCount = value;
				}
			}
			property array<float>^ Cells
			{
				array<float>^ get()
				{
					return cells;
				}
				void set(array<float>^ value)
				{
					cells = value;
				}
			}
			property ground_paint_layer_t* NativePtr
			{
				ground_paint_layer_t* get()
				{
					return _gound_painter_layer;
				}
			}
		};
		public ref class GroundPaint
		{
		private:
			ground_paint_t* _ground_paint;
			int sizeX;
			int sizeY; 
			int num_layers;
			List<GroundPaintLayer^>^ layers;
		public:
			GroundPaint()
			{
				_ground_paint = new ground_paint_t();
			}
			GroundPaint(ground_paint_t* _nativePtr)
			{
				_ground_paint = _nativePtr;
			}
			GroundPaint(ground_paint_t _nativeObj)
			{
				sizeX = _nativeObj.size_x;
				sizeY = _nativeObj.size_y;
				num_layers = _nativeObj.num_layers;
				layers = gcnew List<GroundPaintLayer^>();
				for (int lcv = 0; lcv < num_layers; ++lcv)
				{
					GroundPaintLayer^ layer = gcnew GroundPaintLayer(sizeX * sizeY + 1, sizeX * sizeY);
					layer->GroundSpecID = gcnew String(_nativeObj.layers[lcv].ground_spec_id);
					layer->GroundSpecNo = _nativeObj.layers[lcv].ground_spec_no;
					layer->HasCells = _nativeObj.layers[lcv].has_cells;
					if (layer->HasCells)
					{
						layer->ContinuityCount[sizeX * sizeY] = _nativeObj.layers[lcv].continuity_count[sizeX * sizeY];
						for (int i = 0; i < sizeX; i++)
						{
							for (int j = 0; j < sizeY; j++)
							{
								layer->ContinuityCount[_nativeObj.layers[lcv].continuity_count[j * sizeY + i]];
								layer->Cells[_nativeObj.layers[lcv].cells[j * sizeY + i]];
							}
						}
					}
					layers->Add(layer);
				}
			}
			~GroundPaint()
			{
				delete _ground_paint;
				delete[] layers;
			}
			property ground_paint_t* NativePtr
			{
				ground_paint_t* get()
				{
					return _ground_paint;
				}
			}
			property ground_paint_t Native
			{
				ground_paint_t get()
				{
					ground_paint_t g;
					g.num_layers = layers->Count;
					g.size_x = sizeX;
					g.size_y = sizeY;
					g.layers = new  ground_paint_layer_t[layers->Count];
					
					for (int i = 0; i < g.num_layers; i++)
					{
						ground_paint_layer_t layer;
						layer.continuity_count = new int[sizeX*sizeY + 1];
						layer.cells = new float[sizeX*sizeY];
						layer.ground_spec_id = (char*)Marshal::StringToHGlobalAnsi(layers[i]->GroundSpecID).ToPointer();
						layer.ground_spec_no = layers[i]->GroundSpecNo;
						for (int j = 0; j < sizeX; j++)
						{
							for (int k = 0; k < sizeY; k++)
							{
								layer.cells[k * sizeY + j] = (float)layers[i]->Cells[k * sizeY + j];
								layer.continuity_count[k * sizeY + j] = (int)layers[i]->ContinuityCount[k * sizeY + j];
							}
						}
					}
					return g;
				}
			}
			property int SizeX
			{
				int get()
				{
					return sizeX;
				}
				void set(int value)
				{
					sizeX = value;
				}
			}
			property int SizeY
			{
				int get()
				{
					return sizeY;
				}
				void set(int value)
				{
					sizeY = value;
				}
			}
			property List<GroundPaintLayer^>^ Layers
			{
				List<GroundPaintLayer^>^ get()
				{
					return layers;
				}
			}
		};
		public ref class AIMeshVertex
		{
		private:
			ai_mesh_vertex_t* _ai_mesh_vertex;
			Vector^ position;
		public:
			AIMeshVertex()
			{
				_ai_mesh_vertex = new ai_mesh_vertex_t();
			}
			AIMeshVertex(ai_mesh_vertex_t* _nativePtr)
			{
				_ai_mesh_vertex = _nativePtr;
			}
			AIMeshVertex(ai_mesh_vertex_t _nativeObj)
			{
				position = gcnew Vector(_nativeObj.position);
			}
			~AIMeshVertex()
			{
				delete _ai_mesh_vertex;
				delete position;
			}
			property ai_mesh_vertex_t* NativePtr
			{
				ai_mesh_vertex_t* get()
				{
					return _ai_mesh_vertex;
				}
			}
			property ai_mesh_vertex_t Native
			{
				ai_mesh_vertex_t get()
				{
					ai_mesh_vertex_t v;
					v.position = position->Native;
					return v;
				}
			}
			property Vector^ Position
			{
				Vector^ get()
				{
					return position;
				}
				void set(Vector^ value)
				{
					position = value;
				}
			}

		};
		public ref class AIMeshEdge
		{
		private:
			ai_mesh_edge_t* _ai_mesh_edge;
			int start_vertex;
			int end_vertex;
		public:
			AIMeshEdge()
			{
				_ai_mesh_edge = new ai_mesh_edge_t();
			}
			AIMeshEdge(ai_mesh_edge_t* _nativePtr)
			{
				_ai_mesh_edge = _nativePtr;
			}
			AIMeshEdge(ai_mesh_edge_t _nativeObj)
			{
				start_vertex = _nativeObj.start_vertex;
				end_vertex = _nativeObj.end_vertex;
			}
			~AIMeshEdge()
			{
				delete _ai_mesh_edge;
			}
			property ai_mesh_edge_t* NativePtr
			{
				ai_mesh_edge_t* get()
				{
					return _ai_mesh_edge;
				}
			}
			property ai_mesh_edge_t Native
			{
				ai_mesh_edge_t get()
				{
					ai_mesh_edge_t e;
					e.start_vertex = start_vertex;
					e.end_vertex = end_vertex;
					return e;
				}
			}
			property int Start_vertex
			{
				int get()
				{
					return start_vertex;
				}
				void set(int value)
				{
					start_vertex = value;
				}
			}
			property int End_vertex
			{
				int get()
				{
					return end_vertex;
				}
				void set(int value)
				{
					end_vertex = value;
				}
			}
		};
		public ref class AIMeshFace
		{
		private:
			ai_mesh_face_t* _ai_mesh_face; 
			int num_vertices;
			array<int>^ vertices;
			array<int>^ edges;
			int unknown;
		public:
			AIMeshFace()
			{
				_ai_mesh_face = new ai_mesh_face_t();
			}
			AIMeshFace(ai_mesh_face_t* _nativePtr)
			{
				_ai_mesh_face = _nativePtr;
			}
			AIMeshFace(ai_mesh_face_t _nativeObj)
			{
				num_vertices = _nativeObj.num_vertices;
				unknown = _nativeObj.unknown;
				vertices = gcnew array<int>(4);
				edges = gcnew array<int>(4);
				for (int i = 0; i < 4; i++)
				{
					edges[i] = _nativeObj.edges[i];
				}
				for (int i = 0; i < 4; i++)
				{
					vertices[i] = _nativeObj.vertices[i];
				}
			}
			~AIMeshFace()
			{
				delete _ai_mesh_face;
				delete[] vertices;
				delete[] edges;
			}
			property ai_mesh_face_t* NativePtr
			{
				ai_mesh_face_t* get()
				{
					return _ai_mesh_face;
				}
			}
			property ai_mesh_face_t Native
			{
				ai_mesh_face_t get()
				{
					ai_mesh_face_t f;
					for (int i = 0; i < 4; i++)
					{
						f.vertices[i] = vertices[i];
					}
					for (int i = 0; i < 4; i++)
					{
						f.edges[i] = edges[i];
					}
					f.num_vertices = num_vertices;
					f.unknown = unknown;
					return f;
				}
			}
			property int Num_vertices
			{
				int get()
				{
					return num_vertices;
				}
				void set(int value)
				{
					num_vertices = value;
				}
			}
			property array<int>^ Vertices
			{
				array<int>^ get()
				{
					return vertices;
				}
				void set(array<int>^ value)
				{
					for (int i = 0; i < 4; i++)
					{
						vertices[i] = value[i];
					}
				}
			}
			property array<int>^ Edges
			{
				array<int>^ get()
				{
					return edges;
				}
				void set(array<int>^ value)
				{
					for (int i = 0; i < 4; i++)
					{
						edges[i] = value[i];
					}
				}
			}
			property int Unknown
			{
				int get()
				{
					return unknown;
				}
				void set(int value)
				{
					unknown = value;
				}
			}
		};
		public ref class AIMesh
		{
		private:
			ai_mesh_t* _ai_mesh;
			List<AIMeshVertex^>^ vertices; 
			List<AIMeshEdge^>^ edges;
			List<AIMeshFace^>^ faces;
		public:
			AIMesh()
			{
				_ai_mesh = new ai_mesh_t();
			}
			AIMesh(ai_mesh_t* _nativePtr)
			{
				_ai_mesh = _nativePtr;
			}
			AIMesh(ai_mesh_t _nativeObj)
			{
				vertices = gcnew List<AIMeshVertex^>();
				edges = gcnew List<AIMeshEdge^>();
				faces = gcnew List<AIMeshFace^>();
				for (int i = 0; i < _nativeObj.num_vertices; i++)
				{
					vertices->Add(gcnew AIMeshVertex(_nativeObj.vertices[i]));
				}
				for (int i = 0; i < _nativeObj.num_edges; i++)
				{
					edges->Add(gcnew AIMeshEdge(_nativeObj.edges[i]));
				}
				for (int i = 0; i < _nativeObj.num_faces; i++)
				{
					faces->Add(gcnew AIMeshFace(_nativeObj.faces[i]));
				}
			}
			~AIMesh()
			{
				delete _ai_mesh;
				delete[] vertices;
				delete[] edges;
				delete[] faces;
			}
			property ai_mesh_t* NativePtr
			{
				ai_mesh_t* get()
				{
					return _ai_mesh;
				}
			}
			property ai_mesh_t Native
			{
				ai_mesh_t get()
				{
					ai_mesh_t mesh;
					mesh.edges = new ai_mesh_edge_t[edges->Count];
					mesh.faces = new ai_mesh_face_t[faces->Count];
					mesh.vertices = new ai_mesh_vertex_t[vertices->Count];
					mesh.num_edges = edges->Count;
					mesh.num_faces = faces->Count;
					mesh.num_vertices = vertices->Count;
					for (int i = 0; i < edges->Count; i++)
					{
						mesh.edges[i] = edges[i]->Native;
					}
					for (int i = 0; i < faces->Count; i++)
					{
						mesh.faces[i] = faces[i]->Native;
					}
					for (int i = 0; i < vertices->Count; i++)
					{
						mesh.vertices[i] = vertices[i]->Native;
					}
					return mesh;
				}
			}
			property List<AIMeshVertex^>^ Vertices
			{
				List<AIMeshVertex^>^ get()
				{
					return vertices;
				}
				void set(List<AIMeshVertex^>^ value)
				{
					vertices = value;
				}
			}
			property List<AIMeshEdge^>^ Edages
			{
				List<AIMeshEdge^>^ get()
				{
					return edges;
				}
				void set(List<AIMeshEdge^>^ value)
				{
					edges = value;
				}
			}
			property List<AIMeshFace^>^ Faces
			{
				List<AIMeshFace^>^ get()
				{
					return faces;
				}
				void set(List<AIMeshFace^>^ value)
				{
					faces = value;
				}
			}
		};
		public ref class MissionObject
		{
		private:
			mission_object_t* _mission_object;
			String^ id;
			int metaType;
			int subKindNo;
			int variationId;
			int variationId2;
			Matrix^ position;
			Vector^ scale;
		public:
			MissionObject()
			{
				_mission_object = new mission_object_t();
			}
			MissionObject(mission_object_t* _nativePtr)
			{
				_mission_object = _nativePtr;
			}
			MissionObject(mission_object_t _nativeObj)
			{
				id = gcnew String(_nativeObj.id);
				subKindNo = _nativeObj.sub_kind_no;
				variationId = _nativeObj.variation_id;
				variationId2 = _nativeObj.variation_id_2;
				metaType = _nativeObj.meta_type;
				position = gcnew Matrix(_nativeObj.position);
				scale = gcnew Vector(_nativeObj.scale);
			}
			~MissionObject()
			{
				delete _mission_object;
			}
			property mission_object_t* NativePtr
			{
				mission_object_t* get()
				{
					return _mission_object;
				}
			}
			property mission_object_t Native
			{
				mission_object_t get()
				{
					mission_object_t m;
					m.sub_kind_no = subKindNo;
					m.meta_type = metaType;
					m.variation_id = variationId;
					m.variation_id_2 = variationId2;
					m.position = position->Native;
					m.scale = scale->Native;
					return m;
				}
			}
			property String^ ID
			{
				String^ get()
				{
					return id;
				}
				void set(String^ value)
				{
					id = value;
				}
			}
			property int MetaType
			{
				int get()
				{
					return metaType;
				}
				void set(int value)
				{
					metaType = value;
				}
			}
			property int SubKindNo
			{
				int get()
				{
					return subKindNo;
				}
				void set(int value)
				{
					subKindNo = value;
				}
			}
			property int VariationId
			{
				int get()
				{
					return variationId;
				}
				void set(int value)
				{
					variationId = value;
				}
			}
			property int VariationId2
			{
				int get()
				{
					return variationId2;
				}
				void set(int value)
				{
					variationId2 = value;
				}
			}
			property Matrix^ Position
			{
				Matrix^ get()
				{
					return position;
				}
				void set(Matrix^ value)
				{
					position = value;
				}
			}
			property Vector^ Scale
			{
				Vector^ get()
				{
					return scale;
				}
				void set(Vector^ value)
				{
					scale = value;
				}
			}
		};
		public ref class SCOFile
		{
		private:
			sco_file_t* _sco_file;
			int version;
			List<MissionObject^>^ missionObjects;
			AIMesh^ aiMesh;
			GroundPaint^ groundPaint;
		public:
			SCOFile()
			{
				_sco_file = new sco_file_t();
				version = 0;
				missionObjects = gcnew List<MissionObject^>();
				aiMesh = gcnew AIMesh();
				groundPaint = gcnew GroundPaint();
			}
			SCOFile(sco_file_t _nativeObj)
			{
				version = _nativeObj.version;
				missionObjects = gcnew List<MissionObject^>();
				aiMesh = gcnew AIMesh();
				groundPaint = gcnew GroundPaint();
				for (int i = 0; i < _nativeObj.num_mission_objects; i++)
				{
					missionObjects->Add(gcnew MissionObject(_nativeObj.mission_objects[i]));
				}
				aiMesh = gcnew AIMesh(_nativeObj.ai_mesh[0]);
				groundPaint = gcnew GroundPaint(_nativeObj.ground_paint[0]);
			}
			SCOFile(sco_file_t* _nativePtr)
			{
				_sco_file = _nativePtr;
			}
			~SCOFile()
			{
				delete _sco_file;
			}
			property int Version
			{
				int get()
				{
					return version;
				}
			}
			property List<MissionObject^>^ MissionObjects
			{
				List<MissionObject^>^ get()
				{
					return missionObjects;
				}
				void set(List<MissionObject^>^ value)
				{
					missionObjects = value;
				}
			}
			property AIMesh^ CurrentAIMesh
			{
				AIMesh^ get()
				{
					return aiMesh;
				}
				void set(AIMesh^ value)
				{
					aiMesh = value;
				}
			}
			property GroundPaint^ CurrentGroundPaint
			{
				GroundPaint^ get()
				{
					return groundPaint;
				}
				void set(GroundPaint^ value)
				{
					groundPaint = value;
				}
			}
			property sco_file_t Native{
				sco_file_t get()
				{
					sco_file_t sco;
					sco.ai_mesh = new ai_mesh_t[1];
					sco.mission_objects = new mission_object_t[missionObjects->Count];
					sco.num_mission_objects = missionObjects->Count;
					sco.ground_paint = new ground_paint_t[1];
					for (int i = 0; i < missionObjects->Count; i++)
					{
						sco.mission_objects[i] = missionObjects[i]->Native;
					}
					sco.ai_mesh[0] = aiMesh->Native;
					sco.ground_paint[0] = groundPaint->Native;
					return sco;
				}
			}
		};
		public ref class SCOLoader
		{
		public:
			SCOLoader()
			{

			}
			~SCOLoader()
			{

			}
			SCOFile^ Read(String^ fileName)
			{
				sco_file_t scoFile;
				SCOFile^ sco;
				FILE* fp = fopen((const char*)Marshal::StringToHGlobalAnsi(fileName).ToPointer(), "rb");
				if (fp != NULL)
				{
					read_sco_file(fp, &scoFile);
					sco = gcnew SCOFile(scoFile);
					return sco;
				}
				else
				{
					return nullptr;
				}
			}

			void Write(String^ fileName, SCOFile% sco)
			{
				FILE* fp = fopen((const char*)Marshal::StringToHGlobalAnsi(fileName).ToPointer(), "wb");
				if (fp != NULL)
				{
					write_sco_file(fp, &sco.Native);
				}
			}
		};
	}
}
