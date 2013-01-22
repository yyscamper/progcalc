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
    public partial class ProgCalc : Form, StrInputListen
    {
        private Button[] m_bntBinBox = new Button[64];
        private byte[] m_binBoxFlag = new byte[64];

        private  Color ASSERT_COLOR = Color.Black;
        private  Color DEASSERT_COLOR = Color.White;
        private ExpTool m_expTool = null;
        private ToolStripDropDownMenu m_resultMenu;


        private void InitBinBox()
        {
            m_bntBinBox[0] = btnBinBox0;
            m_bntBinBox[1] = btnBinBox1;
            m_bntBinBox[2] = btnBinBox2;
            m_bntBinBox[3] = btnBinBox3;
            m_bntBinBox[4] = btnBinBox4;
            m_bntBinBox[5] = btnBinBox5;
            m_bntBinBox[6] = btnBinBox6;
            m_bntBinBox[7] = btnBinBox7;
            m_bntBinBox[8] = btnBinBox8;
            m_bntBinBox[9] = btnBinBox9;
            m_bntBinBox[10] = btnBinBox10;
            m_bntBinBox[11] = btnBinBox11;
            m_bntBinBox[12] = btnBinBox12;
            m_bntBinBox[13] = btnBinBox13;
            m_bntBinBox[14] = btnBinBox14;
            m_bntBinBox[15] = btnBinBox15;
            m_bntBinBox[16] = btnBinBox16;
            m_bntBinBox[17] = btnBinBox17;
            m_bntBinBox[18] = btnBinBox18;
            m_bntBinBox[19] = btnBinBox19;
            m_bntBinBox[20] = btnBinBox20;
            m_bntBinBox[21] = btnBinBox21;
            m_bntBinBox[22] = btnBinBox22;
            m_bntBinBox[23] = btnBinBox23;
            m_bntBinBox[24] = btnBinBox24;
            m_bntBinBox[25] = btnBinBox25;
            m_bntBinBox[26] = btnBinBox26;
            m_bntBinBox[27] = btnBinBox27;
            m_bntBinBox[28] = btnBinBox28;
            m_bntBinBox[29] = btnBinBox29;
            m_bntBinBox[30] = btnBinBox30;
            m_bntBinBox[31] = btnBinBox31;
            m_bntBinBox[32] = btnBinBox32;
            m_bntBinBox[33] = btnBinBox33;
            m_bntBinBox[34] = btnBinBox34;
            m_bntBinBox[35] = btnBinBox35;
            m_bntBinBox[36] = btnBinBox36;
            m_bntBinBox[37] = btnBinBox37;
            m_bntBinBox[38] = btnBinBox38;
            m_bntBinBox[39] = btnBinBox39;

            m_bntBinBox[40] = btnBinBox40;
            m_bntBinBox[41] = btnBinBox41;
            m_bntBinBox[42] = btnBinBox42;
            m_bntBinBox[43] = btnBinBox43;
            m_bntBinBox[44] = btnBinBox44;
            m_bntBinBox[45] = btnBinBox45;
            m_bntBinBox[46] = btnBinBox46;
            m_bntBinBox[47] = btnBinBox47;
            m_bntBinBox[48] = btnBinBox48;
            m_bntBinBox[49] = btnBinBox49;

            m_bntBinBox[50] = btnBinBox50;
            m_bntBinBox[51] = btnBinBox51;
            m_bntBinBox[52] = btnBinBox52;
            m_bntBinBox[53] = btnBinBox53;
            m_bntBinBox[54] = btnBinBox54;
            m_bntBinBox[55] = btnBinBox55;
            m_bntBinBox[56] = btnBinBox56;
            m_bntBinBox[57] = btnBinBox57;
            m_bntBinBox[58] = btnBinBox58;
            m_bntBinBox[59] = btnBinBox59;

            m_bntBinBox[60] = btnBinBox60;
            m_bntBinBox[61] = btnBinBox61;
            m_bntBinBox[62] = btnBinBox62;
            m_bntBinBox[63] = btnBinBox63;

            int i = 0;
            foreach (Button btn in m_bntBinBox)
            {
                btn.Click += new System.EventHandler(this.btnBinBox_Click);
                btn.BackColor = DEASSERT_COLOR;
                btn.ForeColor = Color.Gray;
                m_binBoxFlag[i++] = 0;
            }
        }



        public void InitResultMenu()
        {
            m_resultMenu = new ToolStripDropDownMenu();
            m_resultMenu.Items.Add(new ToolStripMenuItem(Properties.Resources.strAddToClipboard, 
                Properties.Resources.imgAddToClipboard));
            m_resultMenu.Items.Add(new ToolStripMenuItem(Properties.Resources.strAddToVarList, 
                Properties.Resources.imgAddToVarList));
            m_resultMenu.Items.Add(new ToolStripMenuItem(Properties.Resources.strCancel));
            m_resultMenu.ItemClicked += new ToolStripItemClickedEventHandler(ResultMenuItem_Click);
        }

        public void ResultMenuItem_Click(Object sender, ToolStripItemClickedEventArgs args)
        {
            if (args.ClickedItem.Text == Properties.Resources.strAddToClipboard)
            {
                if (tboxResult.Text.Trim().Length > 0)
                    Clipboard.SetDataObject(tboxResult.Text);
            }
            else if (args.ClickedItem.Text == Properties.Resources.strAddToVarList)
            {
                try
                {
                    double r = double.Parse(tboxResult.Text);
                    ExpTool.GetInstance().AddVariable(r.ToString(), r);
					new FormVarList().Show();
                }
                catch
                {
                    MessageBox.Show(Properties.Resources.strAddVarResultErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            m_resultMenu.Hide();
        }

        public ProgCalc()
        {
            InitializeComponent();

			m_expTool = ExpTool.GetInstance();

			this.StartPosition = FormStartPosition.Manual;
			this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 3;
			this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 4;

            tboxInput.Focus();
            InitBinBox();
            //rbtnIntMode.Checked = true;

            //Register Result Mode Change handle
            //rbtnFloorMode.CheckedChanged += new System.EventHandler(this.ResultModeChange);
            //rbtnIntMode.CheckedChanged += new System.EventHandler(this.ResultModeChange);
            //rbtnCeilMode.CheckedChanged += new System.EventHandler(this.ResultModeChange);
            //rbtnRoundMode.CheckedChanged += new System.EventHandler(this.ResultModeChange);

            InitResultMenu();
        }

        private void UpdateViewByInputMode()
        {
            bool binFlag = (Setting.GetInstance().CurIntFmt == IntegerFormat.BIN);
            foreach (Button btn in m_bntBinBox)
            {
                btn.Enabled = binFlag;
            }

			bool hexFlag = (Setting.GetInstance().CurIntFmt == IntegerFormat.HEX);
			btnHexA.Enabled = hexFlag;
			btnHexB.Enabled = hexFlag;
			btnHexC.Enabled = hexFlag;
			btnHexD.Enabled = hexFlag;
			btnHexE.Enabled = hexFlag;
			btnHexF.Enabled = hexFlag;

			bool decFlag = ((Setting.GetInstance().CurIntFmt == IntegerFormat.DEC) || hexFlag);
			btnDigit0.Enabled = (decFlag || binFlag);
			btnDigit1.Enabled = (decFlag || binFlag);
			btnDigit2.Enabled = decFlag;
			btnDigit3.Enabled = decFlag;
			btnDigit4.Enabled = decFlag;
			btnDigit5.Enabled = decFlag;
			btnDigit6.Enabled = decFlag;
			btnDigit7.Enabled = decFlag;
			btnDigit8.Enabled = decFlag;
			btnDigit9.Enabled = decFlag;
        }

        private void BDHCalc_Load(object sender, EventArgs e)
        {
            tboxInput.Text = Setting.GetInstance().HomeLastInputExpression;
            tboxInput.Select();
            tboxInput.SelectionLength = 0;
            tboxInput.SelectionStart = tboxInput.Text.Length;

			ArrayList allFavExps = Setting.GetInstance().FavExpressions;
			foreach (string str in allFavExps)
			{
				FormFavExp.GetInstance().AddExpression(str);
			}

			cboxIntBits.Items.Add("64 Bits,QWORD");
			cboxIntBits.Items.Add("32 Bits,DWORD");
			cboxIntBits.Items.Add("16 Bits,WORD");
			cboxIntBits.Items.Add("8 Bits,BYTE");
			cboxIntBits.SelectedIndex = 0;

			cboxInputMode.Items.Add("Decimal");
			cboxInputMode.Items.Add("Hexadecimal");
			cboxInputMode.Items.Add("Binary");
			cboxInputMode.SelectedIndex = 0;

			radioBtnFloat.Checked = true;
			radioBtnIntegerSigned.Checked = false;
			cboxIntBits.Enabled = radioBtnIntegerSigned.Checked;
			cboxInputMode.Enabled = radioBtnIntegerSigned.Checked;	

            ToolTip lcmTip = new ToolTip();
            lcmTip.SetToolTip(btnLcm, "Least Common Multiple");

            ToolTip gcdTip = new ToolTip();
            lcmTip.SetToolTip(btnGcd, "Greatest Common Divisor");

            //ToolTip timeTip = new ToolTip();
            //timeTip.SetToolTip(btnTime, "Date Time");

			this.EvalExpression();
        }

        private bool IsWithinRect( Point p, Point rectOrigin, Size rectSize)
        {
            return (p.X >= rectOrigin.X && p.X <= (rectOrigin.X + rectSize.Width) 
                && p.Y >= rectOrigin.Y && p.Y <= (rectOrigin.Y + rectSize.Height));
        }

        private void Input(Char c)
        {          
            tboxInput.Select();
            SendKeys.Send(new string(c, 1));
            tboxInput.SelectionLength = 0;
        }

        private void Input(String str)
        {   
            tboxInput.Select();
            SendKeys.Send(str);
            tboxInput.SelectionLength = 0;
        }

        private void BDHCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = (int)e.KeyChar;
            if (k == (int)Keys.Enter)
            {
                EvalExpression();
            }
            /*
            if ((int)e.KeyChar != (int)System.Windows.Forms.Keys.Back
               && (e.KeyChar < '0' || e.KeyChar > '9')
               && (e.KeyChar < 'a' || e.KeyChar > 'f')
               && (e.KeyChar < 'A' || e.KeyChar > 'F'))
            {
                e.Handled = true;
                return;
            }
            GetInputTextbox().Text += e.KeyChar;
             * */
        }

        private void BDHCalc_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnDigit0_Click(object sender, EventArgs e)
        {
            Input('0');
        }

        private void btnDigit1_Click(object sender, EventArgs e)
        {
            Input('1');
        }

        private void btnDigit2_Click(object sender, EventArgs e)
        {
            Input('2');
        }

        private void btnDigit3_Click(object sender, EventArgs e)
        {
            Input('3');
        }

        private void btnDigit4_Click(object sender, EventArgs e)
        {
            Input('4');
        }

        private void btnDigit5_Click(object sender, EventArgs e)
        {
            Input('5');
        }

        private void btnDigit6_Click(object sender, EventArgs e)
        {
            Input('6');
        }

        private void btnDigit7_Click(object sender, EventArgs e)
        {
            Input('7');
        }

        private void btnDigit8_Click(object sender, EventArgs e)
        {
            Input('8');
        }

        private void btnDigit9_Click(object sender, EventArgs e)
        {
            Input('9');
        }

        private void btnHexA_Click(object sender, EventArgs e)
        {
            Input('A');
        }

        private void btnHexB_Click(object sender, EventArgs e)
        {
            Input('B');
        }

        private void btnHexC_Click(object sender, EventArgs e)
        {
            Input('C');
        }

        private void btnHexD_Click(object sender, EventArgs e)
        {
            Input('D');
        }

        private void btnHexE_Click(object sender, EventArgs e)
        {
            Input('E');
        }

        private void btnHexF_Click(object sender, EventArgs e)
        {
            Input('F');
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Input("{+}");
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            Input('-');
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Input('*');
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Input('/');
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Input('(');
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Input(')');
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Input('.');
        }

        private void SetBinBox(Int64 val)
        {
            Int64 flag = 0x01;

            foreach (Button btn in m_bntBinBox)
            {
                if ((val & flag) != 0)
                {
                    btn.BackColor = ASSERT_COLOR;
                }
                else
                {
                    btn.BackColor = DEASSERT_COLOR;
                }
                flag = flag << 1;
            }
        }

        private void SetCharResult(Int64 val)
        {
            char ch;
            StringBuilder sb = new StringBuilder();
            for (int i = 56; i >= 0; i-=8)
            {
                ch = (char)((val >> i) & 0xFF);
                if (ch != 0)
                    sb.Append((char)((val>>i) & 0xFF));
            }
            //tboxResultChar.Text = sb.ToString();
        }

        private Int64 GetBinString(Int64 val)
        {
            return 0;
        }

        private string calc_test(string str)
        {

            CalcEngine.CalcEngine ce = new CalcEngine.CalcEngine();
            return ce.Evaluate(str).ToString();
        }

        private void UpdateResult(Int64 val)
        {
			StringBuilder strDec = new StringBuilder(Convert.ToString(val, 10));
            StringBuilder strHex = new StringBuilder(Convert.ToString(val, 16).ToUpper());
            StringBuilder strBin = new StringBuilder(Convert.ToString(val, 2));

			int nbit = (int)Setting.GetInstance().CurIntBits;
			if (Setting.GetInstance().CurCalcMode == CalcMode.FLOAT)
				nbit = 64;

			if (strHex.Length > nbit/4)
			{
				strHex.Remove(0, strHex.Length - nbit / 4);
			}

			if (strBin.Length > nbit)
			{
				strBin.Remove(0, strBin.Length - nbit);
			}

			tboxResultDec.Text = strDec.ToString();
			tboxResultHex.Text = strHex.ToString();
			tboxResultBin.Text = strBin.ToString();


            SetBinBox(val);
            SetCharResult(val);
        }

        private Int64 ParseBinStr(string s)
        {
            Int64 tmp = 0;
            Int64 flag = 0x01;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char ch = s[i];
                if (ch == ',' || ch == ' ')
                    continue;
                else if (ch == '1')
                    tmp |= flag;
                else if (ch != '0')
                    throw new ArgumentException("Invalid binary char!");
                flag = (flag << 1);
            }
            return tmp;
        }

		private void UpdateResult(object val)
		{
			try
			{
                if (val is string)
                    UpdateResult((string)val);
                else
                {

                    long lval = (long)double.Parse(val.ToString());
                    UpdateResult(lval);
                }
			}
			catch
			{
				UpdateResultToFaultStatus();
			}
		}

        private void UpdateResult(String str)
        {
            try
            {
                if (str.Length > 2 && str[0] == '0')
                {
                    Int64 ival = 0;
                    String substr = str.Substring(2);
                    if (str[1] == 'X' || str[1] == 'x')
                    {
                        ival = Int64.Parse(substr, System.Globalization.NumberStyles.HexNumber);
                        UpdateResult(ival);
                        return;
                    }
                    else if (str[1] == 'b' || str[1] == 'B')
                    {
                        ival = ParseBinStr(substr);
                        UpdateResult(ival);
                        return;
                    }
                }
                double fval = Double.Parse(str);
                UpdateResult(fval);

                if (FormCustomResult.GetInstance().Visible)
                    FormCustomResult.GetInstance().UpdateResult();
            }
            catch
            {
                UpdateResultToFaultStatus();
            }
        }

        private void UpdateResultToFaultStatus()
        {
            tboxResultBin.Text = "ERROR!";
            tboxResultDec.Text = "ERROR!";
            tboxResultHex.Text = "ERROR!";
            SetBinBox(0);
        }

        private Int64 ParseChars(string str)
        {
            Int64 val = 0;
            int len = Math.Min(str.Length, 8);
            for (int i = len - 1; i >= 0; i--)
            {
                val |= ((Int64)str[i] << ((len - 1 - i) * 8));
            }
            return val;
        }

        private void EvalExpression()
        {
			string istr = tboxInput.Text.Trim();

			if (istr.Length <= 0)
                return;

			object val = null;

			/*

            if (m_numFmt == NumberFormat.CHAR)
            {
                Int64 val = ParseChars(tboxInput.Text.Trim());
                tboxResult.Text = val.ToString();
                UpdateResult(val);
            }
            else
            {
			 * 
			 */
            try
            {
                //this.Text = new DataTable().Compute(tboxInput.Text, "").ToString();
                //this.Text = Microsoft.JScript.Eval.JScriptEvaluate(tboxInput.Text, Microsoft.JScript.Vsa.VsaEngine.CreateEngine()).ToString();
				val = ExpTool.GetInstance().Eva(istr,
					Setting.GetInstance().CurCalcMode,
					Setting.GetInstance().CurIntFmt,
					Setting.GetInstance().CurIntBits, true);
				tboxResult.Text = val.ToString();
                labelExpErrorMessage.Text = "";

				if (FormCustomResult.GetInstance().Visible)
                    FormCustomResult.GetInstance().UpdateResult();
            }
            catch (Exception err)
            {
                tboxResult.Text = "ERROR!";
                UpdateResultToFaultStatus();
                labelExpErrorMessage.Text = err.Message;
            }
		
            try
            {
                UpdateResult(val);
            }
            catch
            {

            }

			/*
         }

			 */
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
			EvalExpression();
        }

        private void tboxInput_TextChanged(object sender, EventArgs e)
        {
            EvalExpression();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            tboxInput.Text = String.Empty;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            Input("{BS}");
        }

        private Int64 GetBinBoxValue()
        {
            Int64 val = 0;
            Int64 flag = 0x01;
            foreach (Button btn in m_bntBinBox)
            {
                if (btn.BackColor == ASSERT_COLOR)
                    val |= flag;
                flag = (flag << 1);
            }
            return val;
        }

        private void btnBinBox_Click(object sender, EventArgs e)
        {
			if (Setting.GetInstance().CurIntFmt != IntegerFormat.BIN)
                return;
            Button btn = (Button)sender;

            //toggle the color
            if (btn.BackColor == ASSERT_COLOR)
                btn.BackColor = DEASSERT_COLOR;
            else
                btn.BackColor = ASSERT_COLOR;

            Int64 val = GetBinBoxValue();
            UpdateResult(val);
        }

        private void UpdateResultWhenResultModeChange()
        {
            UpdateResult(tboxResult.Text);
        }

        private void ResultModeChange(object sender, EventArgs e)
        {
            UpdateResultWhenResultModeChange();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = ((CheckBox)sender).Checked;        
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tboxResult.Text);
        }

        private void btnOpenResultMenu_Click(object sender, EventArgs e)
        {
            m_resultMenu.Show(this, new Point(btnOpenResultMenu.Location.X, 
                btnOpenResultMenu.Location.Y + btnOpenResultMenu.Height));
        }

        private void ProgCalc_Activated(object sender, EventArgs e)
        {
            tboxInput.Focus();
        }

        private void btnLeftPar_Click(object sender, EventArgs e)
        {
            Input('(');
        }

        private void btnRightPar_Click(object sender, EventArgs e)
        {
            Input(')');
        }

        private void menuViewCustomResult_Click(object sender, EventArgs e)
        {
            FormCustomResult.GetInstance().Show();
            FormCustomResult.GetInstance().UpdateResult();
        }

        private void menuViewCalcBoard_Click(object sender, EventArgs e)
        {
            new FormCalcBoard().Show();
        }

        private void tboxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8 //Backspace
               || e.KeyChar == (char)127)
                return;
        }

        private void menuViewAsciiTable_Click(object sender, EventArgs e)
        {
            new FormAsciiTable().Show();
			//new FormAsciiTableNew().Show();
        }

        private void ProgCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Setting.GetInstance().HomeLastInputExpression = tboxInput.Text;

			string[] allExp = FormFavExp.GetInstance().GetAllFavExpressions();

			Setting.GetInstance().ClearFavExp();
			foreach (string str in allExp)
			{
				Setting.GetInstance().AddFavExp(str);
			}
			Setting.GetInstance().Save();
        }



        private void btnTime_Click(object sender, EventArgs e)
        {
            Input(@"@::@");
            tboxInput.SelectionStart = tboxInput.Text.Length - 3;
        }

        private void cboxCalcMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void cboxNumFmt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_inputClick(object sender, EventArgs e)
        {
            InputText(sender);  
        }

        private void InputText(object sender)
        {
            Input(((Button)sender).Text);
        }

        private void InputPar()
        {
            Input("{(}{)}{LEFT}");
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            InputPar();
        }

        private void btnClick_TextWithPar(object sender, EventArgs e)
        {
            InputText(sender);
            InputPar();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Input("{%}");
        }

        private void btnBitNot_Click(object sender, EventArgs e)
        {
            Input("{~}");
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Input("{^}");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            ((ToolStripMenuItem)sender).Checked = this.TopMost;
        }

        private void btnFnList_Click(object sender, EventArgs e)
        {
            FormFunctionList.GetInstance().Show();
        }

		private void button13_Click(object sender, EventArgs e)
		{
			Input("{^}");
		}

		private void menuViewFav_Click(object sender, EventArgs e)
		{
			if (!FormFavExp.GetInstance().Visible)
			{
				FormFavExp.GetInstance().DesktopLocation =
					new Point(this.DesktopLocation.X + this.Width, this.DesktopLocation.Y);

			}
			FormFavExp.GetInstance().SetStrInputListen((StrInputListen)this);
			FormFavExp.GetInstance().Show();
			FormFavExp.GetInstance().Focus();
		}

		private void btnAddFav_Click(object sender, EventArgs e)
		{
			string strExp = tboxInput.Text.Trim();

			if (strExp.Length > 0)
			{
				FormFavExp.GetInstance().AddExpression(strExp);
			}
		}

		private void menuSetting_Click(object sender, EventArgs e)
		{

		}

		private void menuTopMost_Click(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;
			((ToolStripMenuItem)sender).Checked = this.TopMost;
		}

		private void meuBinBox_Opening(object sender, CancelEventArgs e)
		{

		}

		private void enableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Setting.GetInstance().CurIntFmt == IntegerFormat.BIN)
			{
				Setting.GetInstance().CurIntFmt = IntegerFormat.DEC;
				enableToolStripMenuItem.Checked = false;
			}
			else
			{
				Setting.GetInstance().CurIntFmt = IntegerFormat.BIN;
				enableToolStripMenuItem.Checked = true;
			}

		}

		private void btnBinBox27_Click(object sender, EventArgs e)
		{

		}

		private void functionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormFunctionList.GetInstance().Show();
		}

		private void menuViewVariables_Click(object sender, EventArgs e)
		{
			new FormVarList().Show();
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		public void AcceptInputString(string str)
		{
			if (str != null)
			{
				tboxInput.Text = str;
			}
		}

		private void cboxIntBits_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox cbox = (ComboBox)sender;
			if (cbox.SelectedIndex == 1)
				Setting.GetInstance().CurIntBits = IntegerBits.BITS_32;
			else if (cbox.SelectedIndex == 2)
				Setting.GetInstance().CurIntBits = IntegerBits.BITS_16;
			else if (cbox.SelectedIndex == 3)
				Setting.GetInstance().CurIntBits = IntegerBits.BITS_8;
			else
				Setting.GetInstance().CurIntBits = IntegerBits.BITS_64;

			this.EvalExpression();
		}

		private void radioBtnInteger_CheckedChanged(object sender, EventArgs e)
		{
			bool bIntFlag = radioBtnIntegerSigned.Checked | radioBtnIntegerUnsigned.Checked;

			//radioBtnFloat.Checked = !radioBtnInteger.Checked;
			cboxIntBits.Enabled = bIntFlag;
			//cboxInputMode.Enabled = bIntFlag;

			//radioBtnInteger.Checked = !radioBtnInteger.Checked;
			if (radioBtnFloat.Checked)
			{
				Setting.GetInstance().CurCalcMode = CalcMode.FLOAT;
			}
			else if (radioBtnIntegerUnsigned.Checked)
			{
				Setting.GetInstance().CurCalcMode = CalcMode.INTEGER_UNSIGNED;
			}
			else
				Setting.GetInstance().CurCalcMode = CalcMode.INTEGER_SIGNED;

			this.EvalExpression();

		}

		private void radioBtnFloat_CheckedChanged(object sender, EventArgs e)
		{
			//radioBtnInteger.Checked = !radioBtnInteger.Checked;
			if (radioBtnFloat.Checked)
			{
				Setting.GetInstance().CurCalcMode = CalcMode.FLOAT;
			}
			else if (radioBtnIntegerUnsigned.Checked)
			{
				Setting.GetInstance().CurCalcMode = CalcMode.INTEGER_UNSIGNED;
			}
			else
				Setting.GetInstance().CurCalcMode = CalcMode.INTEGER_SIGNED;

			this.EvalExpression();

		}

		private void cboxInputMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*
			ComboBox cbox = (ComboBox)sender;
			if (cbox.SelectedIndex == 1)
				Setting.GetInstance().CurIntFmt = IntegerFormat.HEX;
			else if (cbox.SelectedIndex == 2)
				Setting.GetInstance().CurIntFmt = IntegerFormat.BIN;
			else
				Setting.GetInstance().CurIntFmt = IntegerFormat.DEC;

			UpdateViewByInputMode();
			this.EvalExpression();
			*/
		}

		private void checksumToolToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FormCalcChecksum().Show();
		}

		private void statusProgCalc_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{
			Input("CHKSUM8");
			InputPar();
		}
	}
}
