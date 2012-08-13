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
    public partial class FormCalcBoard : Form
    {
        private const  string m_promptStr = "[ProgCalc] ";
        private int m_promptStrLen;

        public FormCalcBoard()
        {
            InitializeComponent();
            m_promptStrLen = m_promptStr.Length;
            rtboxInputBoard.AppendText(m_promptStr);
        }

        private void Evaulate()
        {
            int n = rtboxInputBoard.Text.Length;
            if (n < 2)
                return;

            int i = rtboxInputBoard.Text.LastIndexOf('\n', n-2);
            if (i < 0)
                i = 0;
            try
            {
                string istr = rtboxInputBoard.Text.Substring(i + m_promptStrLen).Trim();
                if (istr.Equals("clear"))
                {
                    rtboxInputBoard.Text = String.Empty;
                    return;
                }
                else if (istr.Equals("quit"))
                {
                    this.Close();
                    return;
                }
                    
                object result = ExpTool.GetInstance().Eva(rtboxInputBoard.Text.Substring(i+m_promptStrLen), NumberType.DEC, true);
                rtboxInputBoard.AppendText("ans = " + result.ToString());
            }
            catch
            {
                rtboxInputBoard.AppendText("ERROR!");      
            }
        }

        private void rtboxInputBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    e.Handled = true;
                    rtboxInputBoard.AppendText(System.Environment.NewLine);
                    Evaulate();
                    rtboxInputBoard.AppendText(System.Environment.NewLine);
                    rtboxInputBoard.AppendText(m_promptStr);
                }
                catch
                {
                    return;
                }
            }
        }

        private void rtboxInputBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rtboxInputBoard.SelectionStart < rtboxInputBoard.Text.Length)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
