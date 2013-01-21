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

        private byte ParseByte(string str)
        {
            int i = 0;
            while (i < str.Length && str[i++] == ' ') ;
            if (str.Length - i < 2)
            {
                
            }

        }

        private void richBoxInput_TextChanged(object sender, EventArgs e)
        {
            string str = richBoxInput.Text;
            byte byteVal = 0;
            int i = 0;
            long cnt = 0;
            byte chksum8 = 0;
            UInt16 chksum16 = 0;
            UInt32 chksum32 = 0;
            int admit = 0x04; //1: hex_digit0, 2: hex_digit1, 4: break

            byte tmpVal = 0;
            while (i < str.Length)
            {
                if ((admit & 0x04) == 0x04)
                {
                    if (str[i] == ' ' || str[i] == ',')
                        continue;
                    else
                        admit = 0x01;
                }

                if (str[i] >= '0' && str[i] <= '9')
                    tmpVal = (byte)(str[i] - '0');
                else if (str[i] >= 'A' && str[i] <= 'F')
                    tmpVal = (byte)(str[i] - 'A' + 10);
                else if (str[i] >= 'a' && str[i] <= 'f')
                    tmpVal = (byte)(str[i] - 'a' + 10);
                else
                    throw new Exception("Invalid hex character");


                if (admit == 0x02) //hex_digit 1
                {
                    byteVal = (byte)((byte)(byteVal << 4) + tmpVal);
                    admit = 0x02;
                }
                else if (admit == 0x01)
                {
                    byteVal = tmpVal;
                    admit = 0x01; 
                }
            }
           
        }
    }
}
