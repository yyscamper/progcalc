namespace yyscamper.ProgCalc
{
    partial class FormCalcChecksum
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richBoxInput = new System.Windows.Forms.RichTextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lableChecksum8 = new System.Windows.Forms.Label();
            this.lableChecksum16 = new System.Windows.Forms.Label();
            this.labelChecksum32 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelChecksum32);
            this.groupBox1.Controls.Add(this.lableChecksum16);
            this.groupBox1.Controls.Add(this.lableChecksum8);
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.richBoxInput);
            this.groupBox1.Location = new System.Drawing.Point(6, -3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(572, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // richBoxInput
            // 
            this.richBoxInput.Location = new System.Drawing.Point(8, 18);
            this.richBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richBoxInput.Name = "richBoxInput";
            this.richBoxInput.Size = new System.Drawing.Size(556, 228);
            this.richBoxInput.TabIndex = 0;
            this.richBoxInput.Text = "";
            this.richBoxInput.TextChanged += new System.EventHandler(this.richBoxInput_TextChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(496, 254);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(68, 30);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // lableChecksum8
            // 
            this.lableChecksum8.AutoSize = true;
            this.lableChecksum8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lableChecksum8.Location = new System.Drawing.Point(6, 254);
            this.lableChecksum8.Name = "lableChecksum8";
            this.lableChecksum8.Size = new System.Drawing.Size(162, 25);
            this.lableChecksum8.TabIndex = 2;
            this.lableChecksum8.Text = "lableChecksum8";
            // 
            // lableChecksum16
            // 
            this.lableChecksum16.AutoSize = true;
            this.lableChecksum16.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lableChecksum16.Location = new System.Drawing.Point(6, 301);
            this.lableChecksum16.Name = "lableChecksum16";
            this.lableChecksum16.Size = new System.Drawing.Size(173, 25);
            this.lableChecksum16.TabIndex = 2;
            this.lableChecksum16.Text = "labelChecksum16";
            // 
            // labelChecksum32
            // 
            this.labelChecksum32.AutoSize = true;
            this.labelChecksum32.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChecksum32.Location = new System.Drawing.Point(6, 342);
            this.labelChecksum32.Name = "labelChecksum32";
            this.labelChecksum32.Size = new System.Drawing.Size(173, 25);
            this.labelChecksum32.TabIndex = 2;
            this.labelChecksum32.Text = "labelChecksum32";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(496, 292);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(68, 30);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // FormCalcChecksum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 465);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCalcChecksum";
            this.Text = "FormCalcChecksum";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richBoxInput;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lableChecksum8;
        private System.Windows.Forms.Label labelChecksum32;
        private System.Windows.Forms.Label lableChecksum16;
        private System.Windows.Forms.Button btnCalc;
    }
}