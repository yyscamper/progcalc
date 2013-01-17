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
	public partial class InputBox : Form
	{
		StrInputListen m_listen = null;

		public InputBox()
		{
			InitializeComponent();
		}

		public InputBox(string title, string prompt, StrInputListen listen)
		{
			InitializeComponent();

			if (title != null)
				this.Text = title;
			labelPrompt.Text = prompt;
			m_listen = listen;
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void InputBox_Load(object sender, EventArgs e)
		{

		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (m_listen != null)
			{
				m_listen.AcceptInputString(tboxInput.Text);
			}
			this.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			tboxInput.Text = String.Empty;
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
