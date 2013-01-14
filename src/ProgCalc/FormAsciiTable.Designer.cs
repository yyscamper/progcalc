namespace yyscamper.ProgCalc
{
    partial class FormAsciiTable
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tboxAsciiSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAsciiTableSetting = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvAscii = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvAscii)).BeginInit();
			this.SuspendLayout();
			// 
			// tboxAsciiSearch
			// 
			this.tboxAsciiSearch.Location = new System.Drawing.Point(59, 25);
			this.tboxAsciiSearch.Name = "tboxAsciiSearch";
			this.tboxAsciiSearch.Size = new System.Drawing.Size(101, 21);
			this.tboxAsciiSearch.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search";
			// 
			// btnAsciiTableSetting
			// 
			this.btnAsciiTableSetting.Location = new System.Drawing.Point(669, 23);
			this.btnAsciiTableSetting.Name = "btnAsciiTableSetting";
			this.btnAsciiTableSetting.Size = new System.Drawing.Size(75, 23);
			this.btnAsciiTableSetting.TabIndex = 3;
			this.btnAsciiTableSetting.Text = "Setting";
			this.btnAsciiTableSetting.UseVisualStyleBackColor = true;
			this.btnAsciiTableSetting.Click += new System.EventHandler(this.btnAsciiTableSetting_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(329, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 39);
			this.label2.TabIndex = 4;
			this.label2.Text = "ASCII";
			// 
			// dgvAscii
			// 
			this.dgvAscii.AllowUserToAddRows = false;
			this.dgvAscii.AllowUserToDeleteRows = false;
			this.dgvAscii.AllowUserToResizeRows = false;
			this.dgvAscii.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.dgvAscii.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAscii.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAscii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAscii.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAscii.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvAscii.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAscii.Location = new System.Drawing.Point(0, 0);
			this.dgvAscii.MultiSelect = false;
			this.dgvAscii.Name = "dgvAscii";
			this.dgvAscii.ReadOnly = true;
			this.dgvAscii.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAscii.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvAscii.RowHeadersVisible = false;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvAscii.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvAscii.RowTemplate.Height = 23;
			this.dgvAscii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvAscii.Size = new System.Drawing.Size(863, 801);
			this.dgvAscii.TabIndex = 5;
			this.dgvAscii.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAscii_ColumnHeaderMouseClick);
			this.dgvAscii.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAscii_KeyDown);
			this.dgvAscii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvAscii_KeyPress);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 81;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column2.HeaderText = "Column2";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 81;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
			this.Column3.HeaderText = "Column3";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 81;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
			this.Column4.HeaderText = "Column4";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 81;
			// 
			// FormAsciiTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 801);
			this.Controls.Add(this.dgvAscii);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAsciiTableSetting);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tboxAsciiSearch);
			this.Name = "FormAsciiTable";
			this.Text = "ASCII Table";
			this.Load += new System.EventHandler(this.FormAsciiTable_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAsciiTable_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormAsciiTable_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.dgvAscii)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxAsciiSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsciiTableSetting;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvAscii;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}