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
    public partial class ProgCalc : Form
    {
        private NumberType m_inputMode;
        private Button[] m_bntBinBox = new Button[64];
        private byte[] m_binBoxFlag = new byte[64];

        private  Color ASSERT_COLOR = Color.Black;
        private  Color DEASSERT_COLOR = Color.White;
        private ExpTool m_expTool = new ExpTool();
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
                    ExpTool.GetInstance().AddVariable(r);
                    new FormVarList(ExpTool.GetInstance()).Show();
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
            m_inputMode = NumberType.DEC;
            tboxInput.Focus();
            InitBinBox();
            rbtnDecMode.Checked = true;
            rbtnIntMode.Checked = true;
            grpFormatResult.Text = GetGroupFormatResultTitle();

            //Register Result Mode Change handle
            rbtnFloorMode.CheckedChanged += new System.EventHandler(this.ResultModeChange);
            rbtnIntMode.CheckedChanged += new System.EventHandler(this.ResultModeChange);
            rbtnCeilMode.CheckedChanged += new System.EventHandler(this.ResultModeChange);
            rbtnRoundMode.CheckedChanged += new System.EventHandler(this.ResultModeChange);

            InitResultMenu();
        }

        private void UpdateViewByInputMode()
        {
            bool decFlag = (m_inputMode == NumberType.DEC);
            bool hexFlag = (m_inputMode == NumberType.HEX);
            bool binFlag = (m_inputMode == NumberType.BIN);
            //tboxResultDec.ReadOnly = !decFlag;
            //tboxResultHex.ReadOnly = !hexFlag;
            //tboxResultBin.ReadOnly = !binFlag;

            btnHexA.Enabled = hexFlag;
            btnHexB.Enabled = hexFlag;
            btnHexC.Enabled = hexFlag;
            btnHexD.Enabled = hexFlag;
            btnHexE.Enabled = hexFlag;
            btnHexC.Enabled = hexFlag;

            btnDigit2.Enabled = !binFlag;
            btnDigit3.Enabled = !binFlag;
            btnDigit4.Enabled = !binFlag;
            btnDigit5.Enabled = !binFlag;
            btnDigit6.Enabled = !binFlag;
            btnDigit7.Enabled = !binFlag;
            btnDigit8.Enabled = !binFlag;
            btnDigit9.Enabled = !binFlag;

            foreach (Button btn in m_bntBinBox)
            {
                btn.Enabled = binFlag;
            }
        }

        private TextBox GetInputTextbox()
        {
            switch (m_inputMode)
            {
                case NumberType.DEC:
                    return tboxResultDec;
                case NumberType.HEX:
                    return tboxResultHex;
                case NumberType.BIN:
                    return tboxResultBin;
                default:
                    return null;
            }
        }

        private void BDHCalc_Load(object sender, EventArgs e)
        {
            //UpdateViewByInputMode();
            tboxInput.Focus();
        }


        private void button65_Click(object sender, EventArgs e)
        {

        }

        private void button98_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void rbtnSelectDecInput_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool IsWithinRect( Point p, Point rectOrigin, Size rectSize)
        {
            return (p.X >= rectOrigin.X && p.X <= (rectOrigin.X + rectSize.Width) 
                && p.Y >= rectOrigin.Y && p.Y <= (rectOrigin.Y + rectSize.Height));
        }

        private void BDHCalc_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void tboxResultDec_MouseClick(object sender, MouseEventArgs e)
        {
            //m_inputMode = INPUT_MODE_DEC;
            //UpdateViewByInputMode();
        }

        private void tboxResultHex_MouseClick(object sender, MouseEventArgs e)
        {
            //m_inputMode = INPUT_MODE_HEX;
            //UpdateViewByInputMode();
        }

        private void tboxResultBin_MouseClick(object sender, MouseEventArgs e)
        {
            //m_inputMode = INPUT_MODE_BIN;
            //UpdateViewByInputMode();
        }

        private void Input(Char c)
        {
            tboxInput.Text += c;
        }

        private void Input(String str)
        {
            tboxInput.Text += str;
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

        private void tboxResultDec_TextChanged(object sender, EventArgs e)
        {

        }

        private void BDHCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.D1)
                {
                    rbtnDecMode.Checked = true;
                }
                else if (e.KeyCode == Keys.D2)
                {
                    rbtnHexMode.Checked = true;
                }
                else if (e.KeyCode == Keys.D3)
                {
                    rbtnBinMode.Checked = true;
                }
                else if (e.KeyCode == Keys.D4)
                {
                    rbtnCharMode.Checked = true;
                }
            }
        }

        private void SendKey(String str)
        {
            SendKeys.Send(str);
            //System.Threading.Thread.Sleep(1);
            SendKeys.Flush();
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
            Input('+');
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

        private string GetGroupFormatResultTitle()
        {
            if (rbtnIntMode.Checked)
                return "INT result";
            else if (rbtnRoundMode.Checked)
                return "ROUND result";
            else if (rbtnCeilMode.Checked)
                return "CEIL result";
            else
                return "FLOOR result";
        }

        private void UpdateResult(Int64 val)
        {
            tboxResultDec.Text = Convert.ToString(val, 10);
            tboxResultHex.Text = Convert.ToString(val, 16).ToUpper();
            tboxResultBin.Text = Convert.ToString(val, 2);
            SetBinBox(val);
            SetCharResult(val);
        }

        private void UpdateResult(double fval)
        {
            Int64 result = 0;
            grpFormatResult.Text = GetGroupFormatResultTitle();
            if (rbtnIntMode.Checked)
                result = (Int64)fval;
            else if (rbtnRoundMode.Checked)
                result = (Int64)Math.Round(fval);
            else if (rbtnCeilMode.Checked)
                result = (Int64)Math.Ceiling(fval);
            else
                result = (Int64)Math.Floor(fval);
            UpdateResult(result);
        }

        private void UpdateResult(String str)
        {
            try
            {
                double fval = Double.Parse(str);
                UpdateResult(fval);

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

        private void EvalExpression()
        {
            if (tboxInput.Text.Length <= 0)
                return;
            try
            {
                //this.Text = new DataTable().Compute(tboxInput.Text, "").ToString();
                //this.Text = Microsoft.JScript.Eval.JScriptEvaluate(tboxInput.Text, Microsoft.JScript.Vsa.VsaEngine.CreateEngine()).ToString();
                tboxResult.Text = ExpTool.GetInstance().Eva(tboxInput.Text, m_inputMode, true).ToString();
                labelExpErrorMessage.Text = "";
            }
            catch (Exception err)
            {
                tboxResult.Text = "ERROR!";
                UpdateResultToFaultStatus();
                labelExpErrorMessage.Text = err.Message;
            }

            try
            {
                UpdateResult(tboxResult.Text);
            }
            catch
            {

            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Int64 val = 0;
            string str = tboxInput.Text;
            int len = Math.Min(str.Length, 8);
            if (m_inputMode == NumberType.CHAR)
            {
                for (int i=len-1; i>=0; i--)
                {
                    val |= ((Int64)str[i]<<((len-1-i)*8));
                }
                UpdateResult(val);
                //tboxResultChar.Text = str;
            }
            else if (m_inputMode == NumberType.BINBOX)
            {

            }else
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
            if (tboxInput.Text.Length < 1)
                return;
            tboxInput.Text = tboxInput.Text.Substring(0, tboxInput.Text.Length - 1);
        }

        private void rbtnDecMode_CheckedChanged(object sender, EventArgs e)
        {
            tboxInput.Text = String.Empty;
            m_inputMode = NumberType.DEC;
            UpdateViewByInputMode();
            //rbtnDecMode.Checked = true;
            //rbtnHexMode.Checked = false;
            //rbtnBinMode.Checked = false;
            //rbtnCharMode.Checked = false;
        }

        private void rbtnHexMode_CheckedChanged(object sender, EventArgs e)
        {
            tboxInput.Text = String.Empty;
            m_inputMode = NumberType.HEX;
            UpdateViewByInputMode();
            //rbtnDecMode.Checked = false;
            //rbtnHexMode.Checked = true;
            //rbtnBinMode.Checked = false;
            //rbtnCharMode.Checked = false;
        }

        private void rbtnBinMode_CheckedChanged(object sender, EventArgs e)
        {
            tboxInput.Text = String.Empty;
            m_inputMode = NumberType.BIN;
            UpdateViewByInputMode();
            //rbtnDecMode.Checked = false;
            //rbtnHexMode.Checked = false;
            //rbtnBinMode.Checked = true;
            //rbtnCharMode.Checked = false;
        }

        private void rbtnCharMode_CheckedChanged(object sender, EventArgs e)
        {
            tboxInput.Text = String.Empty;
            m_inputMode = NumberType.CHAR;
            UpdateViewByInputMode();
            //rbtnDecMode.Checked = false;
            //rbtnHexMode.Checked = false;
            //rbtnBinMode.Checked = false;
            //rbtnCharMode.Checked = true;
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
            if (m_inputMode != NumberType.BIN)
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

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLeftPar_Click(object sender, EventArgs e)
        {
            Input('(');
        }

        private void btnRightPar_Click(object sender, EventArgs e)
        {
            Input(')');
        }

        private void menuSetting_Click(object sender, EventArgs e)
        {

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
    }
}
