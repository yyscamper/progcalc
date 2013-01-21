namespace yyscamper.ProgCalc
{
	partial class FormAsciiTableNew
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
			this.listviewAsciiTable = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// listviewAsciiTable
			// 
			this.listviewAsciiTable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listviewAsciiTable.Location = new System.Drawing.Point(12, 12);
			this.listviewAsciiTable.Name = "listviewAsciiTable";
			this.listviewAsciiTable.Size = new System.Drawing.Size(796, 693);
			this.listviewAsciiTable.TabIndex = 0;
			this.listviewAsciiTable.UseCompatibleStateImageBehavior = false;
			this.listviewAsciiTable.View = System.Windows.Forms.View.Details;
			// 
			// FormAsciiTableNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 717);
			this.Controls.Add(this.listviewAsciiTable);
			this.Name = "FormAsciiTableNew";
			this.Text = "ASCII Table";
			this.Load += new System.EventHandler(this.FormAsciiTableNew_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listviewAsciiTable;
	}
}