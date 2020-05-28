using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCO.TestWriter
{
	public partial class frmMain : Form
	{
		private string currentFilePath = null;
		public frmMain()
		{
			InitializeComponent();
		}

		private void mnuNew_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "MB SceneObj File|*.sco";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				currentFilePath = dialog.FileName;
			}
		}
	}
}
