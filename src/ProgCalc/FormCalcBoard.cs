﻿using System;
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
    public partial class FormCalcBoard : Form
    {
        private const  string m_promptStr = "[ProgCalc] ";
        private HistoryController m_histoy;
        private int m_historyMaxSize;
        private int m_inputBeginPos;
        private CalcBoardColorScheme m_colorScheme;

        public FormCalcBoard()
        {
            InitializeComponent();
            CalcBoardColorScheme.GetInstance().LoadSchemes();
            m_colorScheme = CalcBoardColorScheme.GetInstance()["dark"];
			rtboxInputBoard.Font = m_colorScheme.Font;
            rtboxInputBoard.SelectionFont = m_colorScheme.Font;
            rtboxInputBoard.BackColor = m_colorScheme.BackColor;
            m_historyMaxSize = 20;
            m_histoy = new HistoryController(m_historyMaxSize, false, false);
            AppendPromptString();
        }


		private void menuColorSchemeItems_Click(object sender, EventArgs e)
		{

		}

        private void AppendPromptString()
        {
			rtboxInputBoard.SelectionStart = rtboxInputBoard.TextLength;
			rtboxInputBoard.SelectionLength = 0;

            rtboxInputBoard.SelectionColor = m_colorScheme.PromptColor;
            rtboxInputBoard.AppendText(m_promptStr);
            rtboxInputBoard.SelectionColor = m_colorScheme.InputColor;
            m_inputBeginPos = rtboxInputBoard.TextLength;
        }

        private void AppendAnswerString(string ans)
        {
			rtboxInputBoard.SelectionStart = rtboxInputBoard.TextLength;
			rtboxInputBoard.SelectionLength = 0;

            rtboxInputBoard.SelectionColor = m_colorScheme.AnswerColor;
            rtboxInputBoard.AppendText(ans);
			rtboxInputBoard.SelectionColor = m_colorScheme.InputColor;
        }

        private void Evaulate()
        {
            int n = rtboxInputBoard.Text.Length;
            if (n < 2)
                return;

            try
            {
                string istr = GetInputText().Trim();
				if (istr.Length <= 0)
					return;

                m_histoy.Add(istr);

                if (istr.Equals("clear") || istr.Equals("cls"))
                {
                    rtboxInputBoard.Text = String.Empty;
                    return;
                }
                else if (istr.Equals("quit"))
                {
                    this.Close();
                    return;
                }
                    
                object result = ExpTool.GetInstance().Eva(istr, CalcMode.FLOAT,  IntegerFormat.DEC, IntegerBits.BITS_64, true);
                AppendAnswerString("ans = " + result.ToString() + Environment.NewLine);
            }
            catch
            {
                AppendAnswerString("ERROR!");     
            }
        }

        private string GetInputText()
        {
            rtboxInputBoard.Select(m_inputBeginPos, rtboxInputBoard.TextLength - m_inputBeginPos);
            return rtboxInputBoard.SelectedText;
        }
        /**
         * @fn ClearInput
         * @brief Clear the input string
         * 
         * The input sring is start from m_inputBeginPos to the last
         */
        private void ClearInput()
        {
            rtboxInputBoard.Select(m_inputBeginPos, rtboxInputBoard.TextLength - m_inputBeginPos);
            rtboxInputBoard.SelectedText = "";   
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
                    AppendPromptString();
                }
                catch
                {
                    return;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                ClearInput();
                string str = m_histoy.Previous();
                if (str != null)
                    AppendAnswerString(str);
            }
            else if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                ClearInput();
                string str = m_histoy.Next();
                if (str != null)
                    AppendAnswerString(str);
            }
            else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                if (rtboxInputBoard.SelectionStart <= m_inputBeginPos)
                    e.Handled = true;
            }
        }

        private void rtboxInputBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rtboxInputBoard.SelectionStart < m_inputBeginPos)
            {
                //rtboxInputBoard.SelectionStart = m_inputBeginPos;
                //rtboxInputBoard.ScrollToCaret();
                e.Handled = true;
                return;
            }
        }

        private void FormCalcBoard_Load(object sender, EventArgs e)
        {
            string[] allSchemeNames = CalcBoardColorScheme.GetInstance().GetAllSchemeNames();
            if (allSchemeNames != null)
            {
                int i = 0;
                foreach (string str in allSchemeNames)
                {
                    menuCalcBoardSettingColorScheme.DropDownItems.Add(str);
                    ((ToolStripDropDownItem)menuCalcBoardSettingColorScheme.DropDownItems[i]).MouseHover += 
                        new System.EventHandler(this.MouseHoverEventHandle);
                    ((ToolStripDropDownItem)menuCalcBoardSettingColorScheme.DropDownItems[i]).Click +=
                        new System.EventHandler(this.ColorSchemeMenuMouseClickEventHandle);

					i++;
                }

            }
        }

        private void MouseHoverEventHandle(Object sender, System.EventArgs e)
        {

        }

		private void ColorSchemeMenuMouseClickEventHandle(object sender, System.EventArgs e)
        {
			ToolStripDropDownItem menuItem = (ToolStripDropDownItem)sender;
			CalcBoardColorScheme sch = CalcBoardColorScheme.GetInstance()[menuItem.Text];
			if (sch != null)
			{
				m_colorScheme = sch;
				rtboxInputBoard.SelectionFont = m_colorScheme.Font;
				rtboxInputBoard.Font = m_colorScheme.Font;
				rtboxInputBoard.BackColor = m_colorScheme.BackColor;
			}
        }

        private void rtboxInputBoard_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void menuCalcBoardSetting_Click(object sender, EventArgs e)
        {

        }

        private void menuCalcBoardSettingFont_Click(object sender, EventArgs e)
        {
			FontDialog fd = new FontDialog();
			fd.Font = m_colorScheme.Font;
			fd.ShowColor = false;

			DialogResult res = fd.ShowDialog();
			if (res == DialogResult.OK)
			{
				m_colorScheme.Font = fd.Font;
				rtboxInputBoard.Font = m_colorScheme.Font;
			}
        }

		private void rtboxInputBoard_TextChanged(object sender, EventArgs e)
		{

		}
    }

    public class CalcBoardColorScheme
    {
        public Font Font;
        public Color PromptColor;
        public Color InputColor;
        public Color AnswerColor;
        public Color BackColor;
        public string name;

        private CalcBoardColorScheme DefaultScheme;

        private Dictionary<string, CalcBoardColorScheme> AllSchemes;

        private static CalcBoardColorScheme m_instance  = null;

        public CalcBoardColorScheme()
        {
            AllSchemes = new Dictionary<string, CalcBoardColorScheme>();          
        }

        static public CalcBoardColorScheme GetInstance()
        {
            if (m_instance == null)
                m_instance = new CalcBoardColorScheme();
            return m_instance;
        }

        public CalcBoardColorScheme this[string name]
        {
            get
            {
                try
                {
                    CalcBoardColorScheme scheme = (CalcBoardColorScheme)AllSchemes[name];
                    if (scheme == null)
                        scheme = (CalcBoardColorScheme)AllSchemes["white"];
                    return scheme;
                }
                catch
                {
                    return DefaultScheme;
                }
            }
            set
            {
                AllSchemes[name] = value;
            }
        }

        public string[] GetAllSchemeNames()
        {
            string[] all = new string[AllSchemes.Count];
            int i = 0;
            foreach ( KeyValuePair<string, CalcBoardColorScheme> obj in AllSchemes)
            {
                all[i++] = ((CalcBoardColorScheme)(obj.Value)).name; 
            }
            return all;
        }

        private void AddScheme(CalcBoardColorScheme scheme)
        {
            AllSchemes[scheme.name] = scheme;
        }

        private void AddScheme(string name, Font font, Color back, Color prompt, Color input, Color ans)
        {
            CalcBoardColorScheme scheme = new CalcBoardColorScheme();
            scheme.name = name;
            scheme.Font = new Font("Courier New", 10, FontStyle.Regular);
            scheme.BackColor = back;
            scheme.PromptColor = prompt;
            scheme.InputColor = input;
            scheme.AnswerColor = ans;
            AllSchemes.Add(name, scheme);
        }

        public void LoadSchemes()
        {
            Font font = new Font("Courier New", 9, FontStyle.Regular);
            AllSchemes.Clear();
            AddScheme("light", font, Color.White, Color.DarkGray, Color.Black, Color.Black);
            AddScheme("dark", font, Color.Black, Color.White, Color.LightGreen, Color.Yellow);
            AddScheme("purple", font, Color.Purple, Color.Yellow, Color.White, Color.White);

            DefaultScheme = new CalcBoardColorScheme();
            DefaultScheme.Font = new Font("Courier New", 9, FontStyle.Regular);
            DefaultScheme.BackColor = Color.Azure;
            DefaultScheme.InputColor = Color.Black;
            DefaultScheme.PromptColor = Color.Blue;
            DefaultScheme.AnswerColor = Color.Green;
        }

    }
}
