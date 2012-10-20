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
    public partial class FormFunctionList : Form
    {
        private static FormFunctionList m_instance = null;
        private FormFunctionList()
        {
            InitializeComponent();
        }

        public static FormFunctionList GetInstance()
        {
            if (m_instance == null)
                m_instance = new FormFunctionList();
            return m_instance; ;
        }

        private void FormFunctionList_Load(object sender, EventArgs e)
        {

        }
    }
}
