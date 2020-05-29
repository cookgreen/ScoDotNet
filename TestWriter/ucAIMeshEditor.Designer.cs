namespace SCO.TestWriter
{
	partial class ucAIMeshEditor
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView3 = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnAddVertex = new System.Windows.Forms.Button();
			this.btnEditVertex = new System.Windows.Forms.Button();
			this.btnDeleteVertex = new System.Windows.Forms.Button();
			this.btnEdgeDelete = new System.Windows.Forms.Button();
			this.btnEdgeEdit = new System.Windows.Forms.Button();
			this.btnEdgeAdd = new System.Windows.Forms.Button();
			this.btnFaceDelete = new System.Windows.Forms.Button();
			this.btnFaceEdit = new System.Windows.Forms.Button();
			this.btnFaceAdd = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.listView2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.listView3, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 590);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(3, 48);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(301, 539);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
			this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new System.Drawing.Point(310, 48);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(302, 539);
			this.listView2.TabIndex = 1;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "X";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Y";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Z";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "StartIndex";
			this.columnHeader4.Width = 152;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "EndIndex";
			this.columnHeader5.Width = 107;
			// 
			// listView3
			// 
			this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView3.FullRowSelect = true;
			this.listView3.GridLines = true;
			this.listView3.Location = new System.Drawing.Point(618, 48);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(303, 539);
			this.listView3.TabIndex = 2;
			this.listView3.UseCompatibleStateImageBehavior = false;
			this.listView3.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Vertics Number";
			this.columnHeader6.Width = 116;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Edge Number";
			this.columnHeader7.Width = 118;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDeleteVertex);
			this.panel1.Controls.Add(this.btnEditVertex);
			this.panel1.Controls.Add(this.btnAddVertex);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(301, 39);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnEdgeDelete);
			this.panel2.Controls.Add(this.btnEdgeEdit);
			this.panel2.Controls.Add(this.btnEdgeAdd);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(310, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(302, 39);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnFaceDelete);
			this.panel3.Controls.Add(this.btnFaceEdit);
			this.panel3.Controls.Add(this.btnFaceAdd);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(618, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(303, 39);
			this.panel3.TabIndex = 5;
			// 
			// btnAddVertex
			// 
			this.btnAddVertex.Location = new System.Drawing.Point(3, 8);
			this.btnAddVertex.Name = "btnAddVertex";
			this.btnAddVertex.Size = new System.Drawing.Size(75, 23);
			this.btnAddVertex.TabIndex = 0;
			this.btnAddVertex.Text = "Add";
			this.btnAddVertex.UseVisualStyleBackColor = true;
			// 
			// btnEditVertex
			// 
			this.btnEditVertex.Location = new System.Drawing.Point(84, 8);
			this.btnEditVertex.Name = "btnEditVertex";
			this.btnEditVertex.Size = new System.Drawing.Size(75, 23);
			this.btnEditVertex.TabIndex = 1;
			this.btnEditVertex.Text = "Edit";
			this.btnEditVertex.UseVisualStyleBackColor = true;
			// 
			// btnDeleteVertex
			// 
			this.btnDeleteVertex.Location = new System.Drawing.Point(165, 8);
			this.btnDeleteVertex.Name = "btnDeleteVertex";
			this.btnDeleteVertex.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteVertex.TabIndex = 2;
			this.btnDeleteVertex.Text = "Delete";
			this.btnDeleteVertex.UseVisualStyleBackColor = true;
			// 
			// btnEdgeDelete
			// 
			this.btnEdgeDelete.Location = new System.Drawing.Point(165, 8);
			this.btnEdgeDelete.Name = "btnEdgeDelete";
			this.btnEdgeDelete.Size = new System.Drawing.Size(75, 23);
			this.btnEdgeDelete.TabIndex = 5;
			this.btnEdgeDelete.Text = "Delete";
			this.btnEdgeDelete.UseVisualStyleBackColor = true;
			// 
			// btnEdgeEdit
			// 
			this.btnEdgeEdit.Location = new System.Drawing.Point(84, 8);
			this.btnEdgeEdit.Name = "btnEdgeEdit";
			this.btnEdgeEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdgeEdit.TabIndex = 4;
			this.btnEdgeEdit.Text = "Edit";
			this.btnEdgeEdit.UseVisualStyleBackColor = true;
			// 
			// btnEdgeAdd
			// 
			this.btnEdgeAdd.Location = new System.Drawing.Point(3, 8);
			this.btnEdgeAdd.Name = "btnEdgeAdd";
			this.btnEdgeAdd.Size = new System.Drawing.Size(75, 23);
			this.btnEdgeAdd.TabIndex = 3;
			this.btnEdgeAdd.Text = "Add";
			this.btnEdgeAdd.UseVisualStyleBackColor = true;
			// 
			// btnFaceDelete
			// 
			this.btnFaceDelete.Location = new System.Drawing.Point(165, 8);
			this.btnFaceDelete.Name = "btnFaceDelete";
			this.btnFaceDelete.Size = new System.Drawing.Size(75, 23);
			this.btnFaceDelete.TabIndex = 5;
			this.btnFaceDelete.Text = "Delete";
			this.btnFaceDelete.UseVisualStyleBackColor = true;
			// 
			// btnFaceEdit
			// 
			this.btnFaceEdit.Location = new System.Drawing.Point(84, 8);
			this.btnFaceEdit.Name = "btnFaceEdit";
			this.btnFaceEdit.Size = new System.Drawing.Size(75, 23);
			this.btnFaceEdit.TabIndex = 4;
			this.btnFaceEdit.Text = "Edit";
			this.btnFaceEdit.UseVisualStyleBackColor = true;
			// 
			// btnFaceAdd
			// 
			this.btnFaceAdd.Location = new System.Drawing.Point(3, 8);
			this.btnFaceAdd.Name = "btnFaceAdd";
			this.btnFaceAdd.Size = new System.Drawing.Size(75, 23);
			this.btnFaceAdd.TabIndex = 3;
			this.btnFaceAdd.Text = "Add";
			this.btnFaceAdd.UseVisualStyleBackColor = true;
			// 
			// ucAIMeshEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ucAIMeshEditor";
			this.Size = new System.Drawing.Size(924, 590);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddVertex;
		private System.Windows.Forms.Button btnDeleteVertex;
		private System.Windows.Forms.Button btnEditVertex;
		private System.Windows.Forms.Button btnEdgeDelete;
		private System.Windows.Forms.Button btnEdgeEdit;
		private System.Windows.Forms.Button btnEdgeAdd;
		private System.Windows.Forms.Button btnFaceDelete;
		private System.Windows.Forms.Button btnFaceEdit;
		private System.Windows.Forms.Button btnFaceAdd;
	}
}
