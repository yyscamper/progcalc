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
	public struct AsciiItem
	{
		public string ch;
		public string desp;
	}

	public partial class FormAsciiTableNew : Form
	{
		static AsciiItem[] AllAsciiItems = null;

		public FormAsciiTableNew()
		{
			InitializeComponent();
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

		private void InitAsciiTable()
		{
			InitAsciiItems();
			for (int i = 0; i < 32; i++)
			{
				ListViewItem litem = new ListViewItem();
				litem.UseItemStyleForSubItems = false;
				litem.SubItems[0].Text = (i.ToString());


				litem.SubItems.Add(i.ToString("X2"));
				litem.SubItems.Add(AllAsciiItems[i].ch);
				litem.SubItems.Add(AllAsciiItems[i].desp);

				int idx = i + 32;
				litem.SubItems.Add(idx.ToString());
				litem.SubItems.Add(idx.ToString("X2"));
				litem.SubItems.Add(AllAsciiItems[idx].ch);

				idx = i + 64;
				litem.SubItems.Add(idx.ToString());
				litem.SubItems.Add(idx.ToString("X2"));
				litem.SubItems.Add(AllAsciiItems[idx].ch);

				idx = i + 96;
				litem.SubItems.Add(idx.ToString());
				litem.SubItems.Add(idx.ToString("X2"));
				litem.SubItems.Add(AllAsciiItems[idx].ch);
				litem.SubItems.Add(AllAsciiItems[idx].desp);

				litem.SubItems[0].BackColor = Color.LightGray;
				litem.SubItems[4].BackColor = Color.LightGray;
				litem.SubItems[7].BackColor = Color.LightGray;
				litem.SubItems[10].BackColor = Color.LightGray;

				listviewAsciiTable.Items.Add(litem);
			}
		}

		private void FormAsciiTableNew_Load(object sender, EventArgs e)
		{

			listviewAsciiTable.Columns.Add("DEC", 50);
			listviewAsciiTable.Columns.Add("HEX", 50);
			listviewAsciiTable.Columns.Add("CHAR", 50);
			listviewAsciiTable.Columns.Add("Description", 150);
			listviewAsciiTable.Columns.Add("DEC", 50);
			listviewAsciiTable.Columns.Add("HEX", 50);
			listviewAsciiTable.Columns.Add("CHAR", 50);
			listviewAsciiTable.Columns.Add("DEC", 50);
			listviewAsciiTable.Columns.Add("HEX", 50);
			listviewAsciiTable.Columns.Add("CHAR", 50);
			listviewAsciiTable.Columns.Add("DEC", 50);
			listviewAsciiTable.Columns.Add("HEX", 50);
			listviewAsciiTable.Columns.Add("CHAR", 50);

			InitAsciiTable();
		}

        private void listviewAsciiTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
	}
}
