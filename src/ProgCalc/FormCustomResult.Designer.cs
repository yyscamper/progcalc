namespace yyscamper.ProgCalc
{
    partial class FormCustomResult
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
            this.cboxExp1 = new System.Windows.Forms.ComboBox();
            this.tboxResult1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxExp2 = new System.Windows.Forms.ComboBox();
            this.tboxResult2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxExp3 = new System.Windows.Forms.ComboBox();
            this.tboxResult3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboxExp1
            // 
            this.cboxExp1.BackColor = System.Drawing.Color.LightCyan;
            this.cboxExp1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxExp1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxExp1.FormattingEnabled = true;
            this.cboxExp1.Location = new System.Drawing.Point(23, 30);
            this.cboxExp1.Name = "cboxExp1";
            this.cboxExp1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboxExp1.Size = new System.Drawing.Size(526, 28);
            this.cboxExp1.TabIndex = 1;
            this.cboxExp1.Text = "ans+1";
            this.cboxExp1.SelectedIndexChanged += new System.EventHandler(this.cboxExp1_SelectedIndexChanged);
            this.cboxExp1.TextChanged += new System.EventHandler(this.cboxExp1_TextChanged);
            this.cboxExp1.Leave += new System.EventHandler(this.cboxExp_Leave);
            // 
            // tboxResult1
            // 
            this.tboxResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxResult1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxResult1.Location = new System.Drawing.Point(23, 64);
            this.tboxResult1.Name = "tboxResult1";
            this.tboxResult1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tboxResult1.Size = new System.Drawing.Size(526, 26);
            this.tboxResult1.TabIndex = 2;
            this.tboxResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2";
            // 
            // cboxExp2
            // 
            this.cboxExp2.BackColor = System.Drawing.Color.LightCyan;
            this.cboxExp2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxExp2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxExp2.FormattingEnabled = true;
            this.cboxExp2.Location = new System.Drawing.Point(23, 133);
            this.cboxExp2.Name = "cboxExp2";
            this.cboxExp2.Size = new System.Drawing.Size(526, 28);
            this.cboxExp2.TabIndex = 1;
            this.cboxExp2.Text = "2^(ans+ 1)";
            this.cboxExp2.TextChanged += new System.EventHandler(this.cboxExp2_TextChanged);
            this.cboxExp2.Leave += new System.EventHandler(this.cboxExp_Leave);
            // 
            // tboxResult2
            // 
            this.tboxResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxResult2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxResult2.Location = new System.Drawing.Point(23, 167);
            this.tboxResult2.Name = "tboxResult2";
            this.tboxResult2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tboxResult2.Size = new System.Drawing.Size(526, 26);
            this.tboxResult2.TabIndex = 2;
            this.tboxResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 92);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3";
            // 
            // cboxExp3
            // 
            this.cboxExp3.BackColor = System.Drawing.Color.LightCyan;
            this.cboxExp3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxExp3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxExp3.FormattingEnabled = true;
            this.cboxExp3.Location = new System.Drawing.Point(23, 239);
            this.cboxExp3.Name = "cboxExp3";
            this.cboxExp3.Size = new System.Drawing.Size(526, 28);
            this.cboxExp3.TabIndex = 1;
            this.cboxExp3.Text = "ans+ ans/2 +ans * 3";
            this.cboxExp3.TextChanged += new System.EventHandler(this.cboxExp3_TextChanged);
            this.cboxExp3.Leave += new System.EventHandler(this.cboxExp_Leave);
            // 
            // tboxResult3
            // 
            this.tboxResult3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxResult3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxResult3.Location = new System.Drawing.Point(23, 273);
            this.tboxResult3.Name = "tboxResult3";
            this.tboxResult3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tboxResult3.Size = new System.Drawing.Size(526, 26);
            this.tboxResult3.TabIndex = 2;
            this.tboxResult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormCustomResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 322);
            this.Controls.Add(this.tboxResult3);
            this.Controls.Add(this.tboxResult2);
            this.Controls.Add(this.cboxExp3);
            this.Controls.Add(this.cboxExp2);
            this.Controls.Add(this.tboxResult1);
            this.Controls.Add(this.cboxExp1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCustomResult";
            this.Text = "Custom Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomResult_FormClosing);
            this.Load += new System.EventHandler(this.FormCustomResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxExp1;
        private System.Windows.Forms.TextBox tboxResult1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboxExp2;
        private System.Windows.Forms.TextBox tboxResult2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxExp3;
        private System.Windows.Forms.TextBox tboxResult3;
    }
}