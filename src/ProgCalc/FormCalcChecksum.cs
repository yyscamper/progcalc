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
	public partial class FormCalcChecksum : Form
	{
		public FormCalcChecksum()
		{
			InitializeComponent();
		}

		private int ParseByte(string str, int startPos, int len)
		{
			int val = 0;
			int i = 0;
			int tmp;
			char ch;

			if (rbtnDec.Checked)
			{
				for (i = 0; i < len; i++)
				{
					ch = str[startPos + i];
					if (ch >= '0' && ch <= '9')
						tmp = ch - '0';
					else
						throw new Exception("Invalid Dec input character \'" + ch + "\'!");

					tmp = str[startPos + i] - '0';
					val = val * 10 + tmp;
				}
			}
			else
			{

				for (i = 0; i < len; i++)
				{
					ch = str[startPos + i];
					if (ch >= '0' && ch <= '9')
						tmp = ch - '0';
					else if (ch >= 'a' && ch <= 'f')
						tmp = ch - 'a' + 10;
					else if (ch >= 'A' && ch <= 'F')
						tmp = ch - 'A' + 10;
					else
						throw new Exception("Invalid Hex input character \'" + ch + "\'!");

					val = (val << 4) + tmp;
				}
			}

			if (val < 0 || val >= 256)
			{
				throw new Exception("Invalid input value! Not in 0~255");
			}

			return val;

		}

		private void CalcChecksum()
		{

			string str = richBoxInput.Text;
			byte chksum8 = 0;
			UInt16 chksum16 = 0;
			UInt32 chksum32 = 0;
			int spos = 0, slen = 0;
			char ch;
			int i = 0;

			try
			{

				for (i = 0; i < str.Length; i++)
				{
					ch = str[i];

					if (ch == ' ' || ch == ',' || ch == 9 || ch == 10)
					{
						if (slen > 0)
						{
							chksum32 += (UInt32)ParseByte(str, spos, slen);
							spos += slen;
							slen = 0;
						}
						spos++;
						continue;
					}
					slen++;
				}

				if (slen > 0)
				{
					chksum32 += (UInt32)ParseByte(str, spos, slen);
				}

				chksum8 = (byte)chksum32;
				chksum8 = (byte)(~chksum8 + 1);

				chksum16 = (UInt16)chksum32;
				chksum16 = (UInt16)(~chksum16 + 1);

				chksum32 = (UInt32)(~chksum32 + 1);


				labelChecksumHex8.Text = "0x" + Convert.ToString(chksum8, 16);
				labelChecksumHex16.Text = "0x" + Convert.ToString(chksum16, 16);
				labelChecksumHex32.Text = "0x" + Convert.ToString(chksum32, 16);

				labelChecksumDec8.Text = chksum8.ToString();
				labelChecksumDec16.Text = chksum16.ToString();
				labelChecksumDec32.Text = chksum32.ToString();

				lableErrorMessage.Text = string.Empty;
			}
			catch (Exception ex)
			{
				labelChecksumHex8.Text =
					labelChecksumHex16.Text =
						labelChecksumHex32.Text =
							labelChecksumDec8.Text =
								labelChecksumDec16.Text =
									labelChecksumDec32.Text = "ERROR";

				lableErrorMessage.Text = ex.Message;

			}

		}

		private void FormCalcChecksum_Load(object sender, EventArgs e)
		{
			cboxInstant.Checked = true;
			rbtnHex.Checked = true;
			tboxByteHandler.Text = @"%Byte%";
			tboxChecksumHandle.Text = @"%Checksum%";

			tboxByteHandler.Enabled = false;
			tboxChecksumHandle.Enabled = false;
			btnOpenFile.Enabled = false;

			labelChecksumHex8.Text =
					labelChecksumHex16.Text =
						labelChecksumHex32.Text =
							labelChecksumDec8.Text =
								labelChecksumDec16.Text =
									labelChecksumDec32.Text = string.Empty;
		}

		private void richBoxInput_TextChanged(object sender, EventArgs e)
		{
			if (cboxInstant.Checked)
				CalcChecksum();
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			CalcChecksum();
		}

		private void rbtnHex_CheckedChanged(object sender, EventArgs e)
		{
			CalcChecksum();
		}

		private void cboxInstant_CheckedChanged(object sender, EventArgs e)
		{
			if (cboxInstant.Checked)
				CalcChecksum();
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}
	}
}
