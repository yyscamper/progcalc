using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CalcEngine;

namespace yyscamper.ProgCalc
{
	public partial class FormFavExp : Form, StrInputListen
	{
		public static FormFavExp m_instance = null;
		private StrInputListen m_strInputListen = null;

		private string m_filterStr = String.Empty;

		private ArrayList m_allFavStr = new ArrayList();

		private FormFavExp()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterParent;
			listBoxFavExp.SelectionMode = SelectionMode.MultiExtended;
		}

		private void FormFavExp_Load(object sender, EventArgs e)
		{

		}

		public void SetStrInputListen(StrInputListen lis)
		{

			m_strInputListen = lis;
		}

		public void AddExpression(string strExp)
		{
			if (strExp != null && strExp.Trim().Length != 0)
			{
				foreach (string str in m_allFavStr)
				{
					if (str.Equals(strExp))
						return;
				}
				m_allFavStr.Add(strExp);
				RefreshListView();
			}
		}

		private void RefreshListView()
		{
			listBoxFavExp.Items.Clear();

			foreach (string s in m_allFavStr)
			{
				if (m_filterStr != null && m_filterStr.Length > 0 
					&& s.IndexOf(m_filterStr) < 0)
				{
					continue;
				}

				listBoxFavExp.Items.Add(s);
			}
		}

		public string[] GetAllFavExpressions()
		{
			string[] allExp = new string[m_allFavStr.Count];
			int i = 0;
			foreach (string s in m_allFavStr)
			{
				allExp[i++] = s;
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

		private void listBoxFavExp_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			m_filterStr = tboxFilterStr.Text.Trim();
			RefreshListView();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			new InputBox("Add Favoriate Expression", "Please input expression here:", (StrInputListen)this).ShowDialog();
		}


		public void AcceptInputString(string str)
		{
			try
			{
				ExpTool.GetInstance().Eva(str, CalcMode.FLOAT, CalcEngine.IntegerFormat.DEC, IntegerBits.BITS_64, false);
			}
			catch
			{
				if (DialogResult.No == MessageBox.Show(
					"The expression cannot be evaluated, do you still want to add it?",
					"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					return;
				}
			}

			AddExpression(str);
		}

        private void RemoveItem()
        {
            if (DialogResult.OK != MessageBox.Show(this, "Are you sure want to delete the selected items?",
				"Confirm", MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2))
			{
				return;
			}

			foreach (int j in listBoxFavExp.SelectedIndices)
			{
				string item = listBoxFavExp.Items[j].ToString();
				for (int i = 0; i < m_allFavStr.Count; i++)
				{
					if (((string)m_allFavStr[i]).Equals(item))
					{
						m_allFavStr.RemoveAt(i);
					}
				}

				listBoxFavExp.Items.RemoveAt(j);
			}
        }

		private void btnRemove_Click(object sender, EventArgs e)
		{
            RemoveItem();
		}

		private void listBoxFavExp_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnRemove.Enabled = (listBoxFavExp.SelectedItems.Count > 0);
		}

        private void listBoxFavExp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                RemoveItem();
        }

        private void ctxMenuItemList_MouseClick(object sender, MouseEventArgs e)
        {
            RemoveItem();
        }

        private void ctxMenuItemList_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void listBoxFavExp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lbox = (ListBox)sender;
            if (lbox.SelectedIndex >= 0 && m_strInputListen != null)
            {
                m_strInputListen.AcceptInputString(lbox.SelectedItem.ToString());
            }
        }
	}
}