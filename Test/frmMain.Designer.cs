namespace SCO.Test
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtSCOFile = new System.Windows.Forms.TextBox();
			this.btnChoose = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGroundPaintLayerCount = new System.Windows.Forms.Label();
			this.txtMissionObjectCount = new System.Windows.Forms.Label();
			this.txtAIMeshCount = new System.Windows.Forms.Label();
			this.missionObject = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "SCO File:";
			// 
			// txtSCOFile
			// 
			this.txtSCOFile.Location = new System.Drawing.Point(77, 6);
			this.txtSCOFile.Name = "txtSCOFile";
			this.txtSCOFile.ReadOnly = true;
			this.txtSCOFile.Size = new System.Drawing.Size(357, 21);
			this.txtSCOFile.TabIndex = 1;
			// 
			// btnChoose
			// 
			this.btnChoose.Location = new System.Drawing.Point(440, 4);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(75, 23);
			this.btnChoose.TabIndex = 2;
			this.btnChoose.Text = "Browse";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.missionObject);
			this.groupBox1.Location = new System.Drawing.Point(12, 145);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(503, 196);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mission Objects";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtAIMeshCount);
			this.groupBox4.Controls.Add(this.txtMissionObjectCount);
			this.groupBox4.Controls.Add(this.txtGroundPaintLayerCount);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Location = new System.Drawing.Point(14, 33);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(501, 106);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Basic Info";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "AIMesh:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "Mission Objects";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ground Paint Layer:";
			// 
			// txtGroundPaintLayerCount
			// 
			this.txtGroundPaintLayerCount.AutoSize = true;
			this.txtGroundPaintLayerCount.Location = new System.Drawing.Point(471, 76);
			this.txtGroundPaintLayerCount.Name = "txtGroundPaintLayerCount";
			this.txtGroundPaintLayerCount.Size = new System.Drawing.Size(11, 12);
			this.txtGroundPaintLayerCount.TabIndex = 3;
			this.txtGroundPaintLayerCount.Text = "0";
			// 
			// txtMissionObjectCount
			// 
			this.txtMissionObjectCount.AutoSize = true;
			this.txtMissionObjectCount.Location = new System.Drawing.Point(471, 50);
			this.txtMissionObjectCount.Name = "txtMissionObjectCount";
			this.txtMissionObjectCount.Size = new System.Drawing.Size(11, 12);
			this.txtMissionObjectCount.TabIndex = 4;
			this.txtMissionObjectCount.Text = "0";
			// 
			// txtAIMeshCount
			// 
			this.txtAIMeshCount.AutoSize = true;
			this.txtAIMeshCount.Location = new System.Drawing.Point(471, 21);
			this.txtAIMeshCount.Name = "txtAIMeshCount";
			this.txtAIMeshCount.Size = new System.Drawing.Size(11, 12);
			this.txtAIMeshCount.TabIndex = 5;
			this.txtAIMeshCount.Text = "0";
			// 
			// missionObject
			// 
			this.missionObject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.missionObject.Location = new System.Drawing.Point(9, 20);
			this.missionObject.Name = "missionObject";
			this.missionObject.Size = new System.Drawing.Size(488, 170);
			this.missionObject.TabIndex = 0;
			this.missionObject.UseCompatibleStateImageBehavior = false;
			this.missionObject.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 75;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "MetaType";
			this.columnHeader2.Width = 88;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "SubKindNo";
			this.columnHeader3.Width = 125;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "VariationId";
			this.columnHeader4.Width = 99;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "VariationId2";
			this.columnHeader5.Width = 97;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 356);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnChoose);
			this.Controls.Add(this.txtSCOFile);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mount&Blade SCO Reader";
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSCOFile;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txtAIMeshCount;
		private System.Windows.Forms.Label txtMissionObjectCount;
		private System.Windows.Forms.Label txtGroundPaintLayerCount;
		private System.Windows.Forms.ListView missionObject;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
	}
}