using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcEngine
{
    class CalcUtil
    {
        static Int64 ParseBinString(string s)
        {
            /*
            Int64 ival = 0;
            double fval = 0.0;
            double ftime = 0.5;
            Int64 flag = 0x01;
            int dotPos = 0;
            int i;

            s = s.Trim();
            if (s.Length > 1 && s[0] == '0' && (s[1] == 'b' || s[1] == 'B'))
            {
                s = s.Substring(2, s.Length - 2);
            }

            if (s.Length == 0)
                return (Int64)0;

            for (dotPos = 0; dotPos < s.Length; dotPos++)
            {
                if (s[dotPos] == '.')
                    break;
            }

            bool isDotFound = false;
            for (i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (ch == '.')
                {
                    isDotFound = true;
                    fval = 0.0;
                    continue;
                }
                else if (ch == ' ' || ch == ',')
                {
                    continue;
                }

                if (isDotFound)
                {
                    if (s[i] == '1')
                        fval += ftime;
                    ftime /= 2;
                }
                else
                {
                    if (s[i] == '1')
                    {
                        ival = (ival << 1);
                    }

                }
            }

            if (dotPos > 0) //Has integer part
            {
                flag = 0x01;
                for (i = dotPos - 1; i >= 0; i++)
                {
                    char ch = s[i];
                    if (ch == ',' || ch == ' '
                }
            }
            */
            Int64 iPart = 0;
            Int64 flag = 0x01;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char ch = s[i];
                if (ch == ',' || ch == ' ')
                    continue;
                else if (ch == '1')
                    iPart |= flag;
                else if (ch != '0')
                    throw new ArgumentException("Invalid binary char!");
                flag = (flag << 1);
            }
            return iPart;
        }

    }
}
