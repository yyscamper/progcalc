namespace yyscamper.ProgCalc
{
    partial class FormVarList
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
            this.lviewVar = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxFilterStr = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ctxMenuListItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.ctxMenuListItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviewVar
            // 
            this.lviewVar.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lviewVar.FullRowSelect = true;
            this.lviewVar.Location = new System.Drawing.Point(9, 40);
            this.lviewVar.Name = "lviewVar";
            this.lviewVar.Size = new System.Drawing.Size(320, 360);
            this.lviewVar.TabIndex = 0;
            this.lviewVar.UseCompatibleStateImageBehavior = false;
            this.lviewVar.View = System.Windows.Forms.View.Details;
            this.lviewVar.SelectedIndexChanged += new System.EventHandler(this.lviewVar_SelectedIndexChanged);
            this.lviewVar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lviewVar_KeyDown);
            this.lviewVar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lviewVar_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxFilterStr);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Location = new System.Drawing.Point(10, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 31);
            this.panel1.TabIndex = 1;
            // 
            // tboxFilterStr
            // 
            this.tboxFilterStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxFilterStr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxFilterStr.Location = new System.Drawing.Point(5, 4);
            this.tboxFilterStr.Name = "tboxFilterStr";
            this.tboxFilterStr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tboxFilterStr.Size = new System.Drawing.Size(164, 23);
            this.tboxFilterStr.TabIndex = 2;
            this.tboxFilterStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFilter.Location = new System.Drawing.Point(173, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(49, 26);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(291, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.Location = new System.Drawing.Point(258, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(28, 26);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ctxMenuListItem
            // 
            this.ctxMenuListItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.ctxMenuListItem.Name = "ctxMenuListItem";
            this.ctxMenuListItem.Size = new System.Drawing.Size(124, 26);
            this.ctxMenuListItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctxMenuListItem_MouseClick);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // FormVarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lviewVar);
            this.Name = "FormVarList";
            this.Text = "Variables List";
            this.Load += new System.EventHandler(this.FormVarList_Load);
            this.Resize += new System.EventHandler(this.FormVarList_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ctxMenuListItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.ListView lviewVar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tboxFilterStr;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ContextMenuStrip ctxMenuListItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;

	}
}