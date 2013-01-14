using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace yyscamper.ProgCalc
{


    public partial class FormAsciiTable : Form
    {
        static AsciiItem[] AllAsciiItems = null;
        private string m_formatStrDetail = "{0,3:D}  0x{0,-3:X}  {1,-5}  {2:26}";
        private string m_formatStrBrief =  "{0,3:D}  0x{0,-3:X}   {1,-5}";
        private string m_columnNameDetail = "Dec  Hex   Char   Description               ";
        private string m_columnNameBrief =  "Dec  Hex   Char   ";

        public FormAsciiTable()
        {
            InitializeComponent();
            InitAsciiTableString();

            dgvAscii.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgvAscii.Columns[0].HeaderText = m_columnNameDetail;
            dgvAscii.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAscii.Columns[1].HeaderText = m_columnNameBrief;

            dgvAscii.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAscii.Columns[2].HeaderText = m_columnNameBrief;

            dgvAscii.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAscii.Columns[3].HeaderText = m_columnNameBrief;

        }

        private void SetAsciiItem(int index, string ch, string desp)
        {
            AllAsciiItems[index].ch = ch;
            AllAsciiItems[index].desp = desp;
        }

        private void InitAsciiItems()
        {
            if (AllAsciiItems != null)
                return;
            int index = 0;
            AllAsciiItems = new AsciiItem[128];
            SetAsciiItem(index++, "NUL", "null");
            SetAsciiItem(index++, "SOH", "start of heading");
            SetAsciiItem(index++, "STX", "start of text");
            SetAsciiItem(index++, "ETX", "end of text");
            SetAsciiItem(index++, "EOT", "end of transmission");
            SetAsciiItem(index++, "ENQ", "enquiry");
            SetAsciiItem(index++, "ACK", "acknowledge");
            SetAsciiItem(index++, "BEL", "bell");
            SetAsciiItem(index++, "BS", "backspace");
            SetAsciiItem(index++, "TAB", "horizontal tab");
            SetAsciiItem(index++, "LF", "NL line feed, new line");
            SetAsciiItem(index++, "VT", "vertical tab");
            SetAsciiItem(index++, "FF", "NP form feed, new page");
            SetAsciiItem(index++, "CR", "carriage return");
            SetAsciiItem(index++, "SO", "shift out");
            SetAsciiItem(index++, "SI", "shift in");
            SetAsciiItem(index++, "DLE", "data link escape");
            SetAsciiItem(index++, "DC1", "device control 1");
            SetAsciiItem(index++, "DC2", "device control 2");
            SetAsciiItem(index++, "DC3", "device control 3");
            SetAsciiItem(index++, "DC4", "device control 4");
            SetAsciiItem(index++, "NAK", "nagative acknowledge");
            SetAsciiItem(index++, "SYN", "synchronous idle");
            SetAsciiItem(index++, "ETB", "end of trans. block");
            SetAsciiItem(index++, "CAN", "cancle");
            SetAsciiItem(index++, "EM", "end of medium");
            SetAsciiItem(index++, "SUB", "substitute");
            SetAsciiItem(index++, "ESC", "escape");
            SetAsciiItem(index++, "FS", "file seprator");
            SetAsciiItem(index++, "GS", "group seprator");
            SetAsciiItem(index++, "RS", "record seprator");
            SetAsciiItem(index++, "US", "unit separator");
            SetAsciiItem(index++, "space", "");
            for (; index < 127; index++)
            {
                SetAsciiItem(index, new string((char)index, 1), "");
            }
            SetAsciiItem(index, "DEL", "");
        }

        private void InitAsciiTableString()
        {
            InitAsciiItems();
            StringBuilder sb = new StringBuilder();
            dgvAscii.Rows.Add(32);
            for (int i = 0; i < 32; i++)
            {
                sb.Clear();
                sb.AppendFormat(m_formatStrDetail, i, AllAsciiItems[i].ch, AllAsciiItems[i].desp);
                dgvAscii.Rows[i].Cells[0].Value = sb.ToString();

                sb.Clear();
                sb.AppendFormat(m_formatStrBrief, 32+i, AllAsciiItems[32+i].ch);
                dgvAscii.Rows[i].Cells[1].Value = sb.ToString();

                sb.Clear();
                sb.AppendFormat(m_formatStrBrief, 64 + i, AllAsciiItems[64 + i].ch);
                dgvAscii.Rows[i].Cells[2].Value = sb.ToString();

                sb.Clear();
                sb.AppendFormat(m_formatStrBrief, 96 + i, AllAsciiItems[96 + i].ch);
                dgvAscii.Rows[i].Cells[3].Value = sb.ToString();
            }
            dgvAscii.EndEdit();
        }

        private void btnAsciiTableSetting_Click(object sender, EventArgs e)
        {

        }

        private void FormAsciiTable_Load(object sender, EventArgs e)
        {

        }

        private void dgvAscii_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 128)
                return;
            int selCol = (int)e.KeyChar / 32;
            int selRow = (int)e.KeyChar % 32;
            if (selCol < 4 && selRow < 32)
                dgvAscii.Rows[selRow].Cells[selCol].Selected = true;
        }

        private void FormAsciiTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvAscii_KeyPress(dgvAscii, e);
        }

        private void dgvAscii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                dgvAscii.Rows[31].Cells[3].Selected = true;
        }

        private void FormAsciiTable_KeyDown(object sender, KeyEventArgs e)
        {
            dgvAscii_KeyDown(dgvAscii, e);
        }

		private void dgvAscii_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			return;
		}
    }
}
