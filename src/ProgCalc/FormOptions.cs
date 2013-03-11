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
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxBinDelimiter_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboxBinDelimiter_TextChanged(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            if (cbox.Text.Trim().Length == 0)
            {
                Setting.GetInstance().BinDelimiter = (char)0;
                return;
            }

            if (cbox.Text == "SPACE")
                Setting.GetInstance().BinDelimiter = ' ';
            else if (cbox.Text == "NONE")
                Setting.GetInstance().BinDelimiter = (char)0;
            else
                Setting.GetInstance().BinDelimiter = cbox.Text[0];
        }


    }
}
