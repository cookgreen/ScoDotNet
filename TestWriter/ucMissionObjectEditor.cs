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
	public partial class ucMissionObjectEditor : UserControl
	{
		private SCOFile scoFile;
		public ucMissionObjectEditor(ref SCOFile scoFile)
		{
			InitializeComponent();
			this.scoFile = scoFile;
			LoadMissionObjects();
		}

		private void LoadMissionObjects()
		{
			listView1.Items.Clear();
			foreach (var missionObj in scoFile.MissionObjects)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = missionObj.ID;
				lvi.SubItems.Add(missionObj.SubKindNo.ToString());
				lvi.SubItems.Add(missionObj.VariationId.ToString());
				lvi.SubItems.Add(missionObj.VariationId2.ToString());
				lvi.SubItems.Add(missionObj.MetaType.ToString());
				listView1.Items.Add(lvi);
			}
		}
	}
}
