namespace yyscamper.ProgCalc
{
	partial class FormFavExp
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
            this.components = new System.ComponentModel.Container();
            this.listBoxFavExp = new System.Windows.Forms.ListBox();
            this.ctxMenuItemList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tboxFilterStr = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctxMenuItemList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFavExp
            // 
            this.listBoxFavExp.ContextMenuStrip = this.ctxMenuItemList;
            this.listBoxFavExp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxFavExp.FormattingEnabled = true;
            this.listBoxFavExp.ItemHeight = 20;
            this.listBoxFavExp.Location = new System.Drawing.Point(6, 34);
            this.listBoxFavExp.Name = "listBoxFavExp";
            this.listBoxFavExp.Size = new System.Drawing.Size(417, 424);
            this.listBoxFavExp.TabIndex = 1;
            this.listBoxFavExp.SelectedIndexChanged += new System.EventHandler(this.listBoxFavExp_SelectedIndexChanged);
            this.listBoxFavExp.SizeChanged += new System.EventHandler(this.listBoxFavExp_SizeChanged);
            this.listBoxFavExp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxFavExp_KeyDown);
            this.listBoxFavExp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFavExp_MouseDoubleClick);
            // 
            // ctxMenuItemList
            // 
            this.ctxMenuItemList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.ctxMenuItemList.Name = "contextMenuStrip1";
            this.ctxMenuItemList.Size = new System.Drawing.Size(124, 26);
            this.ctxMenuItemList.VisibleChanged += new System.EventHandler(this.ctxMenuItemList_VisibleChanged);
            this.ctxMenuItemList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctxMenuItemList_MouseClick);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(374, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.Location = new System.Drawing.Point(328, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(43, 26);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tboxFilterStr
            // 
            this.tboxFilterStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxFilterStr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxFilterStr.Location = new System.Drawing.Point(12, 5);
            this.tboxFilterStr.Name = "tboxFilterStr";
            this.tboxFilterStr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tboxFilterStr.Size = new System.Drawing.Size(233, 23);
            this.tboxFilterStr.TabIndex = 0;
            this.tboxFilterStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFilter.Location = new System.Drawing.Point(245, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(62, 26);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 38);
            this.panel1.TabIndex = 3;
            // 
            // FormFavExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 466);
            this.Controls.Add(this.tboxFilterStr);
            this.Controls.Add(this.listBoxFavExp);
            this.Controls.Add(this.panel1);
            this.Name = "FormFavExp";
            this.Text = "Favoriate Expression";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFavExp_FormClosing);
            this.Load += new System.EventHandler(this.FormFavExp_Load);
            this.SizeChanged += new System.EventHandler(this.FormFavExp_SizeChanged);
            this.ctxMenuItemList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxFavExp;
		private System.Windows.Forms.ContextMenuStrip ctxMenuItemList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.TextBox tboxFilterStr;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
	}
}