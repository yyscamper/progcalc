using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yyscamper.ProgCalc
{
	public partial class FormFavExp : Form
	{
		public static FormFavExp m_instance = null;

		private FormFavExp()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
		}

		private void FormFavExp_Load(object sender, EventArgs e)
		{

		}

		public void AddExpression(string strExp)
		{
			listBoxFavExp.Items.Add(strExp);
		}

		public string[] GetAllFavExpressions()
		{
			string[] allExp = new string[this.listBoxFavExp.Items.Count];
			for (int i = 0; i < this.listBoxFavExp.Items.Count; i++)
			{
				allExp[i] = this.listBoxFavExp.Items[i].ToString();
			}
			return allExp;
		}
		public static FormFavExp GetInstance()
		{
			if (m_instance == null)
				m_instance = new FormFavExp();
			return m_instance;
		}

		private void listBoxFavExp_SizeChanged(object sender, EventArgs e)
		{

		}

		private void FormFavExp_SizeChanged(object sender, EventArgs e)
		{
			listBoxFavExp.Width = this.Width - 40;
			listBoxFavExp.Height = this.Height - 55;
		}

		private void FormFavExp_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Visible = false;
		}

	}
}