using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalcEngine;
using System.Collections;

namespace yyscamper.ProgCalc
{
    public partial class FormVarList : Form, VariableInputListen
    {
        public ExpTool m_expTool;

        public FormVarList()
        {
            InitializeComponent();
			m_expTool = ExpTool.GetInstance();


			lviewVar.Columns.Add("Variable Name", 160);
			lviewVar.Columns.Add("Value", 160);
			tboxFilterStr.Text = string.Empty;
        }

		public void AddVarListItem(string varName, object varValue)
		{
			ListViewItem item = new ListViewItem();
			item.SubItems[0].Text = varName;
			item.SubItems.Add(varValue.ToString());
			if (varName == "ans")
			{
				item.BackColor = Color.LightGray;
				item.ForeColor = Color.Black;
			}
			lviewVar.Items.Add(item);
		}

		private void RefreshListContent()
		{
			lviewVar.Items.Clear();

			if (m_expTool != null)
			{
				CalcVar[] allvar = m_expTool.GetAllVariables();
				string filterStr = tboxFilterStr.Text.Trim();
				foreach (CalcVar v in allvar)
				{
					if (filterStr.Length > 0
						&& v.name.IndexOf(filterStr) < 0)
					{
						continue;
					}
					AddVarListItem(v.name, v.value);
				}
			}
		}

        private void FormVarList_Load(object sender, EventArgs e)
        {
			RefreshListContent();
        }

		private void Add(String name, Object value, string desp)
		{

		}
        private void varListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdjustVarTableView()
        {
        }

        private void AdjustButtonView()
        {

        }

        private void FormVarList_Resize(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			/*
            CalcVar[] allvar = new CalcVar[varTable.RowCount-1];
            for (int i = 0; i < varTable.RowCount-1; i++)
            {
                CalcVar v = new CalcVar();
                try
                {
                    v.name = varTable[0, i].Value.ToString();
                }
                catch
                {
                    String msg = String.Format("The name in row {0} is not valid!", i + 1);
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    v.value = Double.Parse(varTable[1, i].Value.ToString());
                }
                catch
                {
                    String msg = String.Format("The value in row {0} is not valid!", i + 1);
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    v.description = varTable[2, i].Value.ToString();
                }
                catch
                {
                    String msg = String.Format("The description in row {0} is not valid!", i + 1);
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                allvar[i] = v;
            }
            m_expTool.SetVariables(allvar);
			 * 
			 * */
        }

        private void varTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void lviewVar_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView lv = (ListView)sender;
			foreach (int i in lv.SelectedIndices)
			{
				if (lv.Items[i].SubItems[0].Text != "ans")
				{
					btnRemove.Enabled = true;
					return;
				}
			}

			btnRemove.Enabled = false;
		}

		public void VariableInputCallback(string varName, object varValue, VarChangeMode mode)
		{
			if (mode == VarChangeMode.ADD_NEW)
			{
				m_expTool.AddVariable(varName, varValue);
				AddVarListItem(varName, varValue);
			}
			else if (mode == VarChangeMode.UPDATE)
			{
				m_expTool.UpdateVariable(varName, varValue);
				RefreshListContent();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			new FormAddVar(this, "Add Variable", null, null, VarChangeMode.ADD_NEW).ShowDialog();
		}

        private void RemoveItem()
        {
            if (lviewVar.SelectedIndices.Count > 0
                && lviewVar.Items[lviewVar.SelectedIndices[0]].SubItems[0].Text == "ans")
            {
                MessageBox.Show(lviewVar, "Sorry, the \"ans\" variable should not be removed!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (DialogResult.OK != MessageBox.Show(lviewVar, "Are you sure want to delete the selected items?",
				"Confirm", MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2))
			{
				return;
			}

			foreach (int j in lviewVar.SelectedIndices)
			{
				string item = lviewVar.Items[j].SubItems[0].Text;
				if (item != "ans")
				{
					m_expTool.DeleteVariable(item);
					lviewVar.Items.RemoveAt(j);
				}
			}
        }

		private void btnRemove_Click(object sender, EventArgs e)
		{
            RemoveItem();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			RefreshListContent();
		}

		private void lviewVar_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lviewVar.SelectedItems.Count <= 0)
				return;
			
			string name = lviewVar.SelectedItems[0].SubItems[0].Text;
			string val = lviewVar.SelectedItems[0].SubItems[1].Text;

			new FormAddVar(this, "Add Variable", 
				name, val, VarChangeMode.UPDATE).ShowDialog();
		}

        private void lviewVar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                RemoveItem();
        }

        private void ctxMenuListItem_MouseClick(object sender, MouseEventArgs e)
        {
            RemoveItem();
        }
	}
}
