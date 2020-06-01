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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.vertexList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddVertex = new System.Windows.Forms.Button();
			this.btnEditVertex = new System.Windows.Forms.Button();
			this.btnDeleteVertex = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEdgeAdd = new System.Windows.Forms.Button();
			this.btnEdgeEdit = new System.Windows.Forms.Button();
			this.btnEdgeDelete = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnFaceAdd = new System.Windows.Forms.Button();
			this.btnFaceEdit = new System.Windows.Forms.Button();
			this.btnFaceDelete = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.edgeList = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.faceList = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.vertexList);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(301, 539);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vertex";
			// 
			// vertexList
			// 
			this.vertexList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.vertexList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vertexList.FullRowSelect = true;
			this.vertexList.GridLines = true;
			this.vertexList.Location = new System.Drawing.Point(3, 17);
			this.vertexList.Name = "vertexList";
			this.vertexList.Size = new System.Drawing.Size(295, 519);
			this.vertexList.TabIndex = 1;
			this.vertexList.UseCompatibleStateImageBehavior = false;
			this.vertexList.View = System.Windows.Forms.View.Details;
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
			// btnEdgeAdd
			// 
			this.btnEdgeAdd.Location = new System.Drawing.Point(3, 8);
			this.btnEdgeAdd.Name = "btnEdgeAdd";
			this.btnEdgeAdd.Size = new System.Drawing.Size(75, 23);
			this.btnEdgeAdd.TabIndex = 3;
			this.btnEdgeAdd.Text = "Add";
			this.btnEdgeAdd.UseVisualStyleBackColor = true;
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
			// btnEdgeDelete
			// 
			this.btnEdgeDelete.Location = new System.Drawing.Point(165, 8);
			this.btnEdgeDelete.Name = "btnEdgeDelete";
			this.btnEdgeDelete.Size = new System.Drawing.Size(75, 23);
			this.btnEdgeDelete.TabIndex = 5;
			this.btnEdgeDelete.Text = "Delete";
			this.btnEdgeDelete.UseVisualStyleBackColor = true;
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
			// btnFaceAdd
			// 
			this.btnFaceAdd.Location = new System.Drawing.Point(3, 8);
			this.btnFaceAdd.Name = "btnFaceAdd";
			this.btnFaceAdd.Size = new System.Drawing.Size(75, 23);
			this.btnFaceAdd.TabIndex = 3;
			this.btnFaceAdd.Text = "Add";
			this.btnFaceAdd.UseVisualStyleBackColor = true;
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
			// btnFaceDelete
			// 
			this.btnFaceDelete.Location = new System.Drawing.Point(165, 8);
			this.btnFaceDelete.Name = "btnFaceDelete";
			this.btnFaceDelete.Size = new System.Drawing.Size(75, 23);
			this.btnFaceDelete.TabIndex = 5;
			this.btnFaceDelete.Text = "Delete";
			this.btnFaceDelete.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 590);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.edgeList);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(310, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(302, 539);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Edge";
			// 
			// edgeList
			// 
			this.edgeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
			this.edgeList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.edgeList.FullRowSelect = true;
			this.edgeList.GridLines = true;
			this.edgeList.Location = new System.Drawing.Point(3, 17);
			this.edgeList.Name = "edgeList";
			this.edgeList.Size = new System.Drawing.Size(296, 519);
			this.edgeList.TabIndex = 2;
			this.edgeList.UseCompatibleStateImageBehavior = false;
			this.edgeList.View = System.Windows.Forms.View.Details;
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.faceList);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(618, 48);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(303, 539);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Face";
			// 
			// faceList
			// 
			this.faceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
			this.faceList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.faceList.FullRowSelect = true;
			this.faceList.GridLines = true;
			this.faceList.Location = new System.Drawing.Point(3, 17);
			this.faceList.Name = "faceList";
			this.faceList.Size = new System.Drawing.Size(297, 519);
			this.faceList.TabIndex = 3;
			this.faceList.UseCompatibleStateImageBehavior = false;
			this.faceList.View = System.Windows.Forms.View.Details;
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
			// ucAIMeshEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ucAIMeshEditor";
			this.Size = new System.Drawing.Size(924, 590);
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView vertexList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDeleteVertex;
		private System.Windows.Forms.Button btnEditVertex;
		private System.Windows.Forms.Button btnAddVertex;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnEdgeDelete;
		private System.Windows.Forms.Button btnEdgeEdit;
		private System.Windows.Forms.Button btnEdgeAdd;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnFaceDelete;
		private System.Windows.Forms.Button btnFaceEdit;
		private System.Windows.Forms.Button btnFaceAdd;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView edgeList;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView faceList;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
	}
}
