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
        private HistoryController m_histoy;
        private int m_historyMaxSize;
        private int m_inputBeginPos;

        public FormCalcBoard()
        {
            InitializeComponent();
            m_historyMaxSize = 20;
            m_promptStrLen = m_promptStr.Length;
            rtboxInputBoard.AppendText(m_promptStr);
            m_histoy = new HistoryController(m_historyMaxSize, false, false);
            m_inputBeginPos = rtboxInputBoard.Text.Length;
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

                m_histoy.Add(istr);

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
                    m_inputBeginPos = rtboxInputBoard.Text.Length;
                }
                catch
                {
                    return;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                string str = m_histoy.Previous();
                if (str != null)
                    rtboxInputBoard.AppendText(str);
            }
            else if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                string str = m_histoy.Next();
                if (str != null)
                    rtboxInputBoard.AppendText(str);
            }
        }

        private void rtboxInputBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rtboxInputBoard.SelectionStart < m_inputBeginPos)
            {
                //rtboxInputBoard.SelectionStart = m_inputBeginPos;
                //rtboxInputBoard.ScrollToCaret();
                //e.Handled = true;
                return;
            }
        }

        private void FormCalcBoard_Load(object sender, EventArgs e)
        {
        }

        private void rtboxInputBoard_SelectionChanged(object sender, EventArgs e)
        {
            //rtboxInputBoard.SelectionStart = m_inputBeginPos;
            //rtboxInputBoard.ScrollToCaret();
        }
    }
}
