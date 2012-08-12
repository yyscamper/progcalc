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
            this.varTable = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.varTable)).BeginInit();
            this.SuspendLayout();
            // 
            // varTable
            // 
            this.varTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varTable.Location = new System.Drawing.Point(24, 27);
            this.varTable.Name = "varTable";
            this.varTable.RowTemplate.Height = 23;
            this.varTable.Size = new System.Drawing.Size(502, 365);
            this.varTable.TabIndex = 0;
            this.varTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varTable_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(226, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormVarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 445);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.varTable);
            this.Name = "FormVarList";
            this.Text = "Variables List";
            this.Load += new System.EventHandler(this.FormVarList_Load);
            this.Resize += new System.EventHandler(this.FormVarList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.varTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView varTable;
        private System.Windows.Forms.Button btnSave;
    }
}