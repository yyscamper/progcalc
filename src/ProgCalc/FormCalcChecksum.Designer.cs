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
			this.labelChecksumHex32 = new System.Windows.Forms.Label();
			this.labelChecksumHex16 = new System.Windows.Forms.Label();
			this.labelChecksumHex8 = new System.Windows.Forms.Label();
			this.btnCalc = new System.Windows.Forms.Button();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.richBoxInput = new System.Windows.Forms.RichTextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbtnHex = new System.Windows.Forms.RadioButton();
			this.rbtnDec = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tboxByteHandler = new System.Windows.Forms.TextBox();
			this.tboxChecksumHandle = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cboxInstant = new System.Windows.Forms.CheckBox();
			this.labelChecksumDec8 = new System.Windows.Forms.Label();
			this.labelChecksumDec16 = new System.Windows.Forms.Label();
			this.labelChecksumDec32 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lableErrorMessage = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCalc);
			this.groupBox1.Controls.Add(this.btnOpenFile);
			this.groupBox1.Controls.Add(this.cboxInstant);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.richBoxInput);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Location = new System.Drawing.Point(6, -5);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(572, 431);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// labelChecksumHex32
			// 
			this.labelChecksumHex32.AutoSize = true;
			this.labelChecksumHex32.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChecksumHex32.ForeColor = System.Drawing.Color.Green;
			this.labelChecksumHex32.Location = new System.Drawing.Point(72, 125);
			this.labelChecksumHex32.Name = "labelChecksumHex32";
			this.labelChecksumHex32.Size = new System.Drawing.Size(110, 22);
			this.labelChecksumHex32.TabIndex = 2;
			this.labelChecksumHex32.Text = "0x00000000";
			// 
			// labelChecksumHex16
			// 
			this.labelChecksumHex16.AutoSize = true;
			this.labelChecksumHex16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChecksumHex16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelChecksumHex16.Location = new System.Drawing.Point(72, 69);
			this.labelChecksumHex16.Name = "labelChecksumHex16";
			this.labelChecksumHex16.Size = new System.Drawing.Size(70, 22);
			this.labelChecksumHex16.TabIndex = 2;
			this.labelChecksumHex16.Text = "0x0000";
			// 
			// labelChecksumHex8
			// 
			this.labelChecksumHex8.AutoSize = true;
			this.labelChecksumHex8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChecksumHex8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labelChecksumHex8.Location = new System.Drawing.Point(72, 16);
			this.labelChecksumHex8.Name = "labelChecksumHex8";
			this.labelChecksumHex8.Size = new System.Drawing.Size(50, 22);
			this.labelChecksumHex8.TabIndex = 2;
			this.labelChecksumHex8.Text = "0x00";
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(488, 389);
			this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(68, 33);
			this.btnCalc.TabIndex = 1;
			this.btnCalc.Text = "Calc";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(414, 389);
			this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(68, 33);
			this.btnOpenFile.TabIndex = 1;
			this.btnOpenFile.Text = "Open";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			// 
			// richBoxInput
			// 
			this.richBoxInput.Location = new System.Drawing.Point(8, 37);
			this.richBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.richBoxInput.Name = "richBoxInput";
			this.richBoxInput.Size = new System.Drawing.Size(556, 209);
			this.richBoxInput.TabIndex = 0;
			this.richBoxInput.Text = "";
			this.richBoxInput.TextChanged += new System.EventHandler(this.richBoxInput_TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbtnDec);
			this.groupBox3.Controls.Add(this.rbtnHex);
			this.groupBox3.Location = new System.Drawing.Point(8, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(106, 36);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			// 
			// rbtnHex
			// 
			this.rbtnHex.AutoSize = true;
			this.rbtnHex.Location = new System.Drawing.Point(7, 9);
			this.rbtnHex.Name = "rbtnHex";
			this.rbtnHex.Size = new System.Drawing.Size(48, 21);
			this.rbtnHex.TabIndex = 0;
			this.rbtnHex.TabStop = true;
			this.rbtnHex.Text = "Hex";
			this.rbtnHex.UseVisualStyleBackColor = true;
			this.rbtnHex.CheckedChanged += new System.EventHandler(this.rbtnHex_CheckedChanged);
			// 
			// rbtnDec
			// 
			this.rbtnDec.AutoSize = true;
			this.rbtnDec.Location = new System.Drawing.Point(58, 9);
			this.rbtnDec.Name = "rbtnDec";
			this.rbtnDec.Size = new System.Drawing.Size(48, 21);
			this.rbtnDec.TabIndex = 0;
			this.rbtnDec.TabStop = true;
			this.rbtnDec.Text = "Dec";
			this.rbtnDec.UseVisualStyleBackColor = true;
			this.rbtnDec.CheckedChanged += new System.EventHandler(this.rbtnHex_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Byte Handler";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Checksum Handler";
			// 
			// tboxByteHandler
			// 
			this.tboxByteHandler.Location = new System.Drawing.Point(7, 31);
			this.tboxByteHandler.Name = "tboxByteHandler";
			this.tboxByteHandler.Size = new System.Drawing.Size(301, 23);
			this.tboxByteHandler.TabIndex = 6;
			// 
			// tboxChecksumHandle
			// 
			this.tboxChecksumHandle.Location = new System.Drawing.Point(7, 72);
			this.tboxChecksumHandle.Name = "tboxChecksumHandle";
			this.tboxChecksumHandle.Size = new System.Drawing.Size(301, 23);
			this.tboxChecksumHandle.TabIndex = 6;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.labelChecksumDec8);
			this.groupBox4.Controls.Add(this.labelChecksumHex8);
			this.groupBox4.Controls.Add(this.labelChecksumDec16);
			this.groupBox4.Controls.Add(this.labelChecksumHex16);
			this.groupBox4.Controls.Add(this.labelChecksumDec32);
			this.groupBox4.Controls.Add(this.labelChecksumHex32);
			this.groupBox4.Location = new System.Drawing.Point(8, 250);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(234, 173);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Checksum";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = " 8 Bits";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "16 Bits";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "32 Bits";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.tboxChecksumHandle);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Controls.Add(this.tboxByteHandler);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Location = new System.Drawing.Point(248, 250);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(318, 105);
			this.groupBox5.TabIndex = 8;
			this.groupBox5.TabStop = false;
			// 
			// cboxInstant
			// 
			this.cboxInstant.AutoSize = true;
			this.cboxInstant.Location = new System.Drawing.Point(431, 10);
			this.cboxInstant.Name = "cboxInstant";
			this.cboxInstant.Size = new System.Drawing.Size(133, 21);
			this.cboxInstant.TabIndex = 9;
			this.cboxInstant.Text = "Instant Calculation";
			this.cboxInstant.UseVisualStyleBackColor = true;
			this.cboxInstant.CheckedChanged += new System.EventHandler(this.cboxInstant_CheckedChanged);
			// 
			// labelChecksumDec8
			// 
			this.labelChecksumDec8.AutoSize = true;
			this.labelChecksumDec8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChecksumDec8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labelChecksumDec8.Location = new System.Drawing.Point(72, 37);
			this.labelChecksumDec8.Name = "labelChecksumDec8";
			this.labelChecksumDec8.Size = new System.Drawing.Size(20, 22);
			this.labelChecksumDec8.TabIndex = 2;
			this.labelChecksumDec8.Text = "0";
			// 
			// labelChecksumDec16
			// 
			this.labelChecksumDec16.AutoSize = true;
			this.labelChecksumDec16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChecksumDec16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelChecksumDec16.Location = new System.Drawing.Point(72, 91);
			this.labelChecksumDec16.Name = "labelChecksumDec16";
			this.labelChecksumDec16.Size = new System.Drawing.Size(20, 22);
			this.labelChecksumDec16.TabIndex = 2;
			this.labelChecksumDec16.Text = "0";
			// 
			// labelChecksumDec32
			// 
			this.labelChecksumDec32.AutoSize = true;
			this.labelChecksumDec32.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChecksumDec32.ForeColor = System.Drawing.Color.Green;
			this.labelChecksumDec32.Location = new System.Drawing.Point(72, 147);
			this.labelChecksumDec32.Name = "labelChecksumDec32";
			this.labelChecksumDec32.Size = new System.Drawing.Size(20, 22);
			this.labelChecksumDec32.TabIndex = 2;
			this.labelChecksumDec32.Text = "0";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lableErrorMessage});
			this.statusStrip1.Location = new System.Drawing.Point(0, 426);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(584, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lableErrorMessage
			// 
			this.lableErrorMessage.ForeColor = System.Drawing.Color.Red;
			this.lableErrorMessage.Name = "lableErrorMessage";
			this.lableErrorMessage.Size = new System.Drawing.Size(11, 17);
			this.lableErrorMessage.Text = "l";
			this.lableErrorMessage.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
			// 
			// FormCalcChecksum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 448);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormCalcChecksum";
			this.Text = "FormCalcChecksum";
			this.Load += new System.EventHandler(this.FormCalcChecksum_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richBoxInput;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label labelChecksumHex8;
        private System.Windows.Forms.Label labelChecksumHex32;
        private System.Windows.Forms.Label labelChecksumHex16;
        private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbtnDec;
		private System.Windows.Forms.RadioButton rbtnHex;
		private System.Windows.Forms.TextBox tboxChecksumHandle;
		private System.Windows.Forms.TextBox tboxByteHandler;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.CheckBox cboxInstant;
		private System.Windows.Forms.Label labelChecksumDec8;
		private System.Windows.Forms.Label labelChecksumDec16;
		private System.Windows.Forms.Label labelChecksumDec32;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lableErrorMessage;
    }
}