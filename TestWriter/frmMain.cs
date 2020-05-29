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
		private BackgroundWorker worker;
		private FormState currentState;
		private ScoAppSession session;

		private delegate void SetControlEnableDelegate(Control ctrl, bool state);
		private SetControlEnableDelegate setControlEnableDelegate;
		public frmMain()
		{
			InitializeComponent();
			currentState = FormState.Closed;
			worker = new BackgroundWorker();
			worker.DoWork += Worker_DoWork;
			worker.RunWorkerAsync();

			setControlEnableDelegate = new SetControlEnableDelegate(SetControlEnableMethod);
		}

		private void SetControlEnableMethod(Control ctrl, bool state)
		{
			if (ctrl.InvokeRequired)
			{
				ctrl.Invoke(setControlEnableDelegate, ctrl, state);
			}
			else
			{
				ctrl.Enabled = state;
			}
		}

		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			while (true)
			{
				switch (currentState)
				{
					case FormState.Open:
						SetControlEnableMethod(btnAIMesh, true);
						SetControlEnableMethod(btnGroundPaint, true);
						SetControlEnableMethod(btnMissionObjects, true);
						SetControlEnableMethod(btnSave, true);
						break;
					case FormState.New:
						SetControlEnableMethod(btnAIMesh, true);
						SetControlEnableMethod(btnGroundPaint, true);
						SetControlEnableMethod(btnMissionObjects, true);
						SetControlEnableMethod(btnSave, true);
						break;
					case FormState.Closed:
						SetControlEnableMethod(btnAIMesh, false);
						SetControlEnableMethod(btnGroundPaint, false);
						SetControlEnableMethod(btnMissionObjects, false);
						SetControlEnableMethod(btnSave, false);
						break;
					default:
						SetControlEnableMethod(btnAIMesh, false);
						SetControlEnableMethod(btnGroundPaint, false);
						SetControlEnableMethod(btnMissionObjects, false);
						SetControlEnableMethod(btnSave, false);
						break;
				}
			}
		}

		private void mnuNew_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "MB SceneObj File|*.sco";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				session = new ScoAppSession(this);
				session.New(dialog.FileName);
			}
		}

		public void SetState(FormState newState)
		{
			currentState = newState;
		}

		private void mnuOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "MB SceneObj File|*.sco";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				session = new ScoAppSession(this);
				session.Open(dialog.FileName);
			}
		}

		private void btnMissionObjects_Click(object sender, EventArgs e)
		{
			ucMissionObjectEditor ucMissionObjectEditor = new ucMissionObjectEditor(session.CurrentFile);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(ucMissionObjectEditor);
			ucMissionObjectEditor.Dock = DockStyle.Fill;
		}

		private void btnGroundPaint_Click(object sender, EventArgs e)
		{
			ucGroudPaintLayerEditor ucGroudPaintLayerEditor = new ucGroudPaintLayerEditor(session.CurrentFile);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(ucGroudPaintLayerEditor);
			ucGroudPaintLayerEditor.Dock = DockStyle.Fill;
		}

		private void btnAIMesh_Click(object sender, EventArgs e)
		{
			ucAIMeshEditor ucAIMeshEditor = new ucAIMeshEditor(session.CurrentFile);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(ucAIMeshEditor);
			ucAIMeshEditor.Dock = DockStyle.Fill;
		}
	}
}
