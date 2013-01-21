namespace yyscamper.ProgCalc
{
	partial class InputBox
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
			this.tboxInput = new System.Windows.Forms.TextBox();
			this.labelPrompt = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tboxInput
			// 
			this.tboxInput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tboxInput.Location = new System.Drawing.Point(13, 34);
			this.tboxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tboxInput.Multiline = true;
			this.tboxInput.Name = "tboxInput";
			this.tboxInput.Size = new System.Drawing.Size(445, 127);
			this.tboxInput.TabIndex = 0;
			this.tboxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// labelPrompt
			// 
			this.labelPrompt.AutoSize = true;
			this.labelPrompt.Location = new System.Drawing.Point(13, 9);
			this.labelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPrompt.Name = "labelPrompt";
			this.labelPrompt.Size = new System.Drawing.Size(129, 20);
			this.labelPrompt.TabIndex = 1;
			this.labelPrompt.Text = "Please input here:";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(302, 169);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 34);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(383, 169);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(75, 34);
			this.btnCancle.TabIndex = 3;
			this.btnCancle.Text = "Cancle";
			this.btnCancle.UseVisualStyleBackColor = true;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(13, 169);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 34);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// InputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 213);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.labelPrompt);
			this.Controls.Add(this.tboxInput);
			this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "InputBox";
			this.Text = "InputBox";
			this.Load += new System.EventHandler(this.InputBox_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tboxInput;
		private System.Windows.Forms.Label labelPrompt;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnClear;
	}
}