namespace SCO.TestWriter
{
	partial class ucMissionObjectEditor
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMissionObjectDelete = new System.Windows.Forms.Button();
			this.btnMissionObjectEdit = new System.Windows.Forms.Button();
			this.btnMissionObjectAdd = new System.Windows.Forms.Button();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(3, 48);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(909, 532);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Id";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "SubKindNo";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "VariationId";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "VariationId2";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "MetaType";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Position";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 583);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnMissionObjectDelete);
			this.panel1.Controls.Add(this.btnMissionObjectEdit);
			this.panel1.Controls.Add(this.btnMissionObjectAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(909, 39);
			this.panel1.TabIndex = 0;
			// 
			// btnMissionObjectDelete
			// 
			this.btnMissionObjectDelete.Location = new System.Drawing.Point(165, 8);
			this.btnMissionObjectDelete.Name = "btnMissionObjectDelete";
			this.btnMissionObjectDelete.Size = new System.Drawing.Size(75, 23);
			this.btnMissionObjectDelete.TabIndex = 5;
			this.btnMissionObjectDelete.Text = "Delete";
			this.btnMissionObjectDelete.UseVisualStyleBackColor = true;
			// 
			// btnMissionObjectEdit
			// 
			this.btnMissionObjectEdit.Location = new System.Drawing.Point(84, 8);
			this.btnMissionObjectEdit.Name = "btnMissionObjectEdit";
			this.btnMissionObjectEdit.Size = new System.Drawing.Size(75, 23);
			this.btnMissionObjectEdit.TabIndex = 4;
			this.btnMissionObjectEdit.Text = "Edit";
			this.btnMissionObjectEdit.UseVisualStyleBackColor = true;
			// 
			// btnMissionObjectAdd
			// 
			this.btnMissionObjectAdd.Location = new System.Drawing.Point(3, 8);
			this.btnMissionObjectAdd.Name = "btnMissionObjectAdd";
			this.btnMissionObjectAdd.Size = new System.Drawing.Size(75, 23);
			this.btnMissionObjectAdd.TabIndex = 3;
			this.btnMissionObjectAdd.Text = "Add";
			this.btnMissionObjectAdd.UseVisualStyleBackColor = true;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Scale";
			// 
			// ucMissionObjectEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ucMissionObjectEditor";
			this.Size = new System.Drawing.Size(915, 583);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMissionObjectDelete;
		private System.Windows.Forms.Button btnMissionObjectEdit;
		private System.Windows.Forms.Button btnMissionObjectAdd;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
	}
}
