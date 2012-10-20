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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SuspendLayout();
			// 
			// listBoxFavExp
			// 
			this.listBoxFavExp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBoxFavExp.FormattingEnabled = true;
			this.listBoxFavExp.ItemHeight = 20;
			this.listBoxFavExp.Location = new System.Drawing.Point(12, 12);
			this.listBoxFavExp.Name = "listBoxFavExp";
			this.listBoxFavExp.Size = new System.Drawing.Size(298, 464);
			this.listBoxFavExp.TabIndex = 0;
			this.listBoxFavExp.SizeChanged += new System.EventHandler(this.listBoxFavExp_SizeChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// FormFavExp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 483);
			this.Controls.Add(this.listBoxFavExp);
			this.Name = "FormFavExp";
			this.Text = "Favoriate Expression";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFavExp_FormClosing);
			this.Load += new System.EventHandler(this.FormFavExp_Load);
			this.SizeChanged += new System.EventHandler(this.FormFavExp_SizeChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxFavExp;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}