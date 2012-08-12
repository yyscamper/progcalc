using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace yyscamper.ProgCalc
{
    class AppRes
    {
        private Image m_addVarIcon;
        private Image m_clipboardIcon;
        private Image m_cancleIcon;

        static AppRes m_instance;

        private AppRes()
        {
        }

        static AppRes GetInstance()
        {
            if (m_instance == null)
                m_instance = new AppRes();
            return m_instance;
        }

        public bool Load()
        {
            return true;
        }


    }
}
