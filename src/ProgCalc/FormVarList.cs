using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalcEngine;

namespace yyscamper.ProgCalc
{
    public partial class FormVarList : Form
    {
        public ExpTool m_expTool;
        public FormVarList()
        {
            InitializeComponent();
        }

        public FormVarList(ExpTool exptool)
        {         
            InitializeComponent();
            m_expTool = exptool; 
        }

        private void FormVarList_Load(object sender, EventArgs e)
        {
            varTable.Columns.Add("Name", "Name");
            varTable.Columns.Add("Value", "Value");
            varTable.Columns.Add("Description", "Description");
            varTable.Columns[2].Width = 300;

            if (m_expTool != null)
            {
                CalcVar[] allvar = m_expTool.GetAllVariables();
                foreach (CalcVar v in allvar)
                {
                    Add(v.name, v.value, v.description);
                }
            }
            varTable.Rows[0].ReadOnly = true;
            varTable.Rows[0].Frozen = true;
            varTable.Rows[0].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void Add(String name, Object value, string desp)
        {
            //m_calcEngine.Variables.Add(name, value);
            /*DataRow dr = m_dataSet.Tables[0].NewRow();
            dr[0] = name;
            dr[1] = value;
            dr[2] = desp;
            m_dataSet.Tables[0].Rows.Add(dr);*/
            varTable.Rows.Add(name, value, desp);
        }

        private void varListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdjustVarTableView()
        {
            varTable.Size = new Size(this.Size.Width - 20, this.Size.Height - 40);
        }

        private void AdjustButtonView()
        {

        }

        private void FormVarList_Resize(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
        }

        private void varTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
