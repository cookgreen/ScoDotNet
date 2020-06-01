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
	public partial class ucGroudPaintLayerEditor : UserControl
	{
		private SCOFile scoFile;
		public ucGroudPaintLayerEditor(SCOFile scoFile)
		{
			InitializeComponent();
			this.scoFile = scoFile;
			LoadGroudPaintLayers();
		}

		private void LoadGroudPaintLayers()
		{
			layerList.Items.Clear();
			if (scoFile.CurrentGroundPaint == null)
			{
				return;
			}
			
			foreach (var layer in scoFile.CurrentGroundPaint.Layers)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = layer.GroundSpecID;
				lvi.SubItems.Add(layer.GroundSpecNo.ToString());
				lvi.SubItems.Add(layer.HasCells.ToString());
				if (layer.HasCells == 1)
				{
					lvi.SubItems.Add(layer.ContinuityCount.Length.ToString());
					lvi.SubItems.Add(layer.Cells.Length.ToString());
				}
				
				layerList.Items.Add(lvi);
			}
		}
	}
}
