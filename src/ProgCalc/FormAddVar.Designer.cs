namespace yyscamper.ProgCalc
{
	partial class FormAddVar
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
			this.lableInputName = new System.Windows.Forms.Label();
			this.tboxVarName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tboxVarValue = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// lableInputName
			// 
			this.lableInputName.AutoSize = true;
			this.lableInputName.Location = new System.Drawing.Point(12, 14);
			this.lableInputName.Name = "lableInputName";
			this.lableInputName.Size = new System.Drawing.Size(213, 17);
			this.lableInputName.TabIndex = 0;
			this.lableInputName.Text = "Please Input the NAME of Variable:";
			// 
			// tboxVarName
			// 
			this.tboxVarName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tboxVarName.Location = new System.Drawing.Point(15, 36);
			this.tboxVarName.Name = "tboxVarName";
			this.tboxVarName.Size = new System.Drawing.Size(256, 23);
			this.tboxVarName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please Input the VALUE of Variable";
			// 
			// tboxVarValue
			// 
			this.tboxVarValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tboxVarValue.Location = new System.Drawing.Point(15, 92);
			this.tboxVarValue.Name = "tboxVarValue";
			this.tboxVarValue.Size = new System.Drawing.Size(256, 23);
			this.tboxVarValue.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(134, 130);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(61, 28);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancle.Location = new System.Drawing.Point(210, 130);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(61, 28);
			this.btnCancle.TabIndex = 2;
			this.btnCancle.Text = "Cancle";
			this.btnCancle.UseVisualStyleBackColor = true;
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(8, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 123);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// FormAddVar
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancle;
			this.ClientSize = new System.Drawing.Size(286, 166);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tboxVarValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tboxVarName);
			this.Controls.Add(this.lableInputName);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormAddVar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Variable";
			this.Load += new System.EventHandler(this.FormAddVar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lableInputName;
		private System.Windows.Forms.TextBox tboxVarName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tboxVarValue;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}