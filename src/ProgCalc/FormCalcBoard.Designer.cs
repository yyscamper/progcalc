namespace yyscamper.ProgCalc
{
    partial class FormCalcBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalcBoard));
            this.rtboxInputBoard = new System.Windows.Forms.RichTextBox();
            this.menuCalcBoard = new System.Windows.Forms.ToolStrip();
            this.menuCalcBoardFile = new System.Windows.Forms.ToolStripButton();
            this.menuCalcBoardEdit = new System.Windows.Forms.ToolStripButton();
            this.menuCalcBoardSetting = new System.Windows.Forms.ToolStripButton();
            this.menuCalcBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtboxInputBoard
            // 
            this.rtboxInputBoard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtboxInputBoard.Location = new System.Drawing.Point(12, 28);
            this.rtboxInputBoard.Name = "rtboxInputBoard";
            this.rtboxInputBoard.Size = new System.Drawing.Size(485, 458);
            this.rtboxInputBoard.TabIndex = 0;
            this.rtboxInputBoard.Text = "";
            this.rtboxInputBoard.SelectionChanged += new System.EventHandler(this.rtboxInputBoard_SelectionChanged);
            this.rtboxInputBoard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtboxInputBoard_KeyDown);
            this.rtboxInputBoard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtboxInputBoard_KeyPress);
            // 
            // menuCalcBoard
            // 
            this.menuCalcBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalcBoardFile,
            this.menuCalcBoardEdit,
            this.menuCalcBoardSetting});
            this.menuCalcBoard.Location = new System.Drawing.Point(0, 0);
            this.menuCalcBoard.Name = "menuCalcBoard";
            this.menuCalcBoard.Size = new System.Drawing.Size(509, 25);
            this.menuCalcBoard.TabIndex = 1;
            this.menuCalcBoard.Text = "toolStrip1";
            // 
            // menuCalcBoardFile
            // 
            this.menuCalcBoardFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuCalcBoardFile.Image = ((System.Drawing.Image)(resources.GetObject("menuCalcBoardFile.Image")));
            this.menuCalcBoardFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCalcBoardFile.Name = "menuCalcBoardFile";
            this.menuCalcBoardFile.Size = new System.Drawing.Size(31, 22);
            this.menuCalcBoardFile.Text = "File";
            // 
            // menuCalcBoardEdit
            // 
            this.menuCalcBoardEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuCalcBoardEdit.Image = ((System.Drawing.Image)(resources.GetObject("menuCalcBoardEdit.Image")));
            this.menuCalcBoardEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCalcBoardEdit.Name = "menuCalcBoardEdit";
            this.menuCalcBoardEdit.Size = new System.Drawing.Size(34, 22);
            this.menuCalcBoardEdit.Text = "Edit";
            // 
            // menuCalcBoardSetting
            // 
            this.menuCalcBoardSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuCalcBoardSetting.Image = ((System.Drawing.Image)(resources.GetObject("menuCalcBoardSetting.Image")));
            this.menuCalcBoardSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCalcBoardSetting.Name = "menuCalcBoardSetting";
            this.menuCalcBoardSetting.Size = new System.Drawing.Size(52, 22);
            this.menuCalcBoardSetting.Text = "Setting";
            // 
            // FormCalcBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 498);
            this.Controls.Add(this.menuCalcBoard);
            this.Controls.Add(this.rtboxInputBoard);
            this.Name = "FormCalcBoard";
            this.Text = "Calc Board";
            this.Load += new System.EventHandler(this.FormCalcBoard_Load);
            this.menuCalcBoard.ResumeLayout(false);
            this.menuCalcBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtboxInputBoard;
        private System.Windows.Forms.ToolStrip menuCalcBoard;
        private System.Windows.Forms.ToolStripButton menuCalcBoardFile;
        private System.Windows.Forms.ToolStripButton menuCalcBoardEdit;
        private System.Windows.Forms.ToolStripButton menuCalcBoardSetting;
    }
}