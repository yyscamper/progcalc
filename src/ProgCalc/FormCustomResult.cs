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
    public partial class FormCustomResult : Form
    {
        private int m_maxHistorySize = 10;
        private static FormCustomResult m_instance = null;

        private FormCustomResult()
        {
            InitializeComponent();
        }

        public static FormCustomResult GetInstance()
        {
            if (m_instance == null)
                m_instance = new FormCustomResult();
            return m_instance;
        }

        private void FormCustomResult_Load(object sender, EventArgs e)
        {
            cboxExp1.Text = Setting.GetInstance().CustomResultExpression[0];
            cboxExp2.Text = Setting.GetInstance().CustomResultExpression[1];
            cboxExp3.Text = Setting.GetInstance().CustomResultExpression[2];
        }

        private void SetErrorValue(TextBox tbox)
        {
            tbox.Text = "ERROR!";
        }

        private void CopyItemsToComboBox(ComboBox src, ComboBox dst, int selectIndex)
        {
            dst.Items.Clear();
            foreach ( object item in src.Items)
                dst.Items.Add(item);
            dst.SelectedIndex = selectIndex;
        }

        private void AddToHitoryList(string exp)
        {
            int i;
            exp = exp.Trim();
            for (i = 0; i < cboxExp1.Items.Count; i++)
            {
                string s = cboxExp1.Items[0].ToString();
                if (cboxExp1.Items[i].ToString().Trim() == exp)
                    break;
            }
            if (i == cboxExp1.Items.Count)
            {
                cboxExp1.Items.Add(exp);
            }

            CopyItemsToComboBox(cboxExp1, cboxExp2, cboxExp2.SelectedIndex);
            CopyItemsToComboBox(cboxExp1, cboxExp3, cboxExp3.SelectedIndex);
        }

        private void UpdateResult(ComboBox cbox, TextBox tbox)
        {
            Object obj;
            if (cbox.Text.Trim().Length > 0)
            {
                obj = GetExpValue(cbox.Text);
                if (obj != null)
                    tbox.Text = obj.ToString();
                else
                    SetErrorValue(tbox);
            }
        }
        public void UpdateResult()
        {
            UpdateResult(cboxExp1, tboxResult1);
            UpdateResult(cboxExp2, tboxResult2);
            UpdateResult(cboxExp3, tboxResult3);
        }

        public object GetExpValue(string str)
        {
            if (str == null || str.Length == 0)
                return null;
            try
            {
                return ExpTool.GetInstance().Eva(str, 
					Setting.GetInstance().CurCalcMode,
					Setting.GetInstance().CurIntFmt,
					Setting.GetInstance().CurIntBits, false);
            }
            catch
            {
                return null;
            }           
        }


        private void cboxExp_Leave(object sender, EventArgs e)
        {
            if (GetExpValue(((ComboBox)sender).Text) != null)
                AddToHitoryList(((ComboBox)sender).Text);
        }

        private void cboxExp1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxExp1_TextChanged(object sender, EventArgs e)
        {
            UpdateResult((ComboBox)sender, tboxResult1);
        }

        private void FormCustomResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Setting.GetInstance().CustomResultExpression[0] = cboxExp1.Text;
            Setting.GetInstance().CustomResultExpression[1] = cboxExp2.Text;
            Setting.GetInstance().CustomResultExpression[2] = cboxExp3.Text;
        }

        private void cboxExp3_TextChanged(object sender, EventArgs e)
        {
            UpdateResult((ComboBox)sender, tboxResult3);             
        }

        private void cboxExp2_TextChanged(object sender, EventArgs e)
        {
            UpdateResult((ComboBox)sender, tboxResult2);
        }
    }
}
