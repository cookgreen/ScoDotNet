namespace SCO.TestWriter
{
	partial class frmMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAIMesh = new System.Windows.Forms.Button();
			this.btnGroundPaint = new System.Windows.Forms.Button();
			this.btnMissionObjects = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSave = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(991, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mnuNew
			// 
			this.mnuNew.Name = "mnuNew";
			this.mnuNew.Size = new System.Drawing.Size(180, 22);
			this.mnuNew.Text = "New";
			this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnAIMesh);
			this.panel1.Controls.Add(this.btnGroundPaint);
			this.panel1.Controls.Add(this.btnMissionObjects);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 609);
			this.panel1.TabIndex = 1;
			// 
			// btnAIMesh
			// 
			this.btnAIMesh.Enabled = false;
			this.btnAIMesh.Location = new System.Drawing.Point(33, 287);
			this.btnAIMesh.Name = "btnAIMesh";
			this.btnAIMesh.Size = new System.Drawing.Size(121, 84);
			this.btnAIMesh.TabIndex = 2;
			this.btnAIMesh.Text = "AIMesh";
			this.btnAIMesh.UseVisualStyleBackColor = true;
			this.btnAIMesh.Click += new System.EventHandler(this.btnAIMesh_Click);
			// 
			// btnGroundPaint
			// 
			this.btnGroundPaint.Enabled = false;
			this.btnGroundPaint.Location = new System.Drawing.Point(33, 154);
			this.btnGroundPaint.Name = "btnGroundPaint";
			this.btnGroundPaint.Size = new System.Drawing.Size(121, 84);
			this.btnGroundPaint.TabIndex = 1;
			this.btnGroundPaint.Text = "Groud Paint";
			this.btnGroundPaint.UseVisualStyleBackColor = true;
			this.btnGroundPaint.Click += new System.EventHandler(this.btnGroundPaint_Click);
			// 
			// btnMissionObjects
			// 
			this.btnMissionObjects.Enabled = false;
			this.btnMissionObjects.Location = new System.Drawing.Point(33, 25);
			this.btnMissionObjects.Name = "btnMissionObjects";
			this.btnMissionObjects.Size = new System.Drawing.Size(121, 84);
			this.btnMissionObjects.TabIndex = 0;
			this.btnMissionObjects.Text = "Mission Objects";
			this.btnMissionObjects.UseVisualStyleBackColor = true;
			this.btnMissionObjects.Click += new System.EventHandler(this.btnMissionObjects_Click);
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(200, 25);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(791, 609);
			this.panelMain.TabIndex = 2;
			// 
			// mnuOpen
			// 
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.Size = new System.Drawing.Size(180, 22);
			this.mnuOpen.Text = "Open";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(33, 512);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(121, 84);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 634);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mount&Blade SCO Writer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuNew;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAIMesh;
		private System.Windows.Forms.Button btnGroundPaint;
		private System.Windows.Forms.Button btnMissionObjects;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.Button btnSave;
	}
}

