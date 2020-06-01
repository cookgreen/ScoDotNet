using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCO.Managed;

namespace SCO.TestWriter
{
	public partial class ucAIMeshEditor : UserControl
	{
		private SCOFile scoFile;
		public ucAIMeshEditor(SCOFile scoFile)
		{
			InitializeComponent();
			this.scoFile = scoFile;
			LoadAIMesh();
		}

		private void LoadAIMesh()
		{
			LoadAIMeshVertics();
			LoadAIMeshEdges();
			LoadAIMeshFaces();
		}

		private void LoadAIMeshVertics()
		{
			vertexList.Items.Clear();
			foreach (var vertex in scoFile.CurrentAIMesh.Vertices)
			{
				ListViewItem item = new ListViewItem();
				item.Text = vertex.Position.X.ToString();
				item.SubItems.Add(vertex.Position.Y.ToString());
				item.SubItems.Add(vertex.Position.Z.ToString());
				vertexList.Items.Add(item);
			}
		}

		private void LoadAIMeshEdges()
		{
			edgeList.Items.Clear();
			foreach (var edge in scoFile.CurrentAIMesh.Edages)
			{
				ListViewItem item = new ListViewItem();
				item.Text = edge.Start_vertex.ToString();
				item.SubItems.Add(edge.End_vertex.ToString());
				edgeList.Items.Add(item);
			}
		}

		private void LoadAIMeshFaces()
		{
			faceList.Items.Clear();
			foreach (var face in scoFile.CurrentAIMesh.Faces)
			{
				ListViewItem item = new ListViewItem();
				item.Text = face.Num_vertices.ToString();
				item.SubItems.Add(face.Vertices.Length.ToString());
				faceList.Items.Add(item);
			}
		}
	}
}
