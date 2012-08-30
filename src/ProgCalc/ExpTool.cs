using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using CalcEngine;

namespace yyscamper.ProgCalc
{
    public class CalcVar
    {
        public string name;
        public object value;
        public string description;

        public CalcVar()
        {
            this.name = string.Empty;
            this.value = 0;
            this.description = string.Empty;
        }

        public CalcVar(string name, object value, string desp)
        {
            this.name = name == null ? "unname" : name;
            this.value = value == null ? 0 : value;
            this.description = desp == null ? string.Empty : desp;
        }
    }

    public class ExpTool
    {
        public  NumberFormat m_numFmt;
        private  CalcEngine.CalcEngine m_calcEngine;
        private static ExpTool m_instance = null;
        private  Dictionary<string, object> m_varList;

        public ExpTool()
        {
            m_numFmt = NumberFormat.DEC;
            m_calcEngine = new CalcEngine.CalcEngine();
            m_varList = new Dictionary<string, object>();
        }

        public object this[string str]
        {
            get
            {
                return m_varList[str];
            }
            set
            {
                _AddVariable((CalcVar)value);
            }
        }

        public CalcVar[] GetAllVariables()
        {
            CalcVar[] allvar = new CalcVar[m_varList.Count];
            int i = 0;
            foreach (KeyValuePair<string, object> var in m_varList)
            {
                allvar[i++] = (CalcVar)(var.Value);    
            }
            return allvar;
        }

        public void SetVariables(CalcVar[] allvar)
        {
            m_varList.Clear();
            foreach (CalcVar var in allvar)
            {
                _AddVariable(var);
            }
        }

        public void _AddVariable(CalcVar v)
        {
            if (v.description == null)
                v.description = String.Empty;
            m_varList[v.name] = v;
            m_calcEngine.Variables[v.name] = v.value;           
        }

        public void AddVariable(string name, object value, string desc)
        {
            _AddVariable(new CalcVar(name, value, desc));
        }

        public string GetNextVarName()
        {
            int i = 1;
            string s;
            while (true)
            {
                s = "r" + i;
                if (m_varList.ContainsKey(s))
                    i++;
                else
                    break;
            }
            return s;
        }

        public void AddVariable(object value)
        {
            CalcVar v = new CalcVar();
            v.name = GetNextVarName();
            v.value = value;
            v.description = string.Empty;
            _AddVariable(v);
        }

        public CalcEngine.CalcEngine Engine
        {
            get { return m_calcEngine; }
        }

        static public ExpTool GetInstance()
        {
            if (m_instance == null)
                m_instance = new ExpTool();
            return m_instance;
        }

        static private bool ParseBinStr(string s, ref Int64 val)
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
                    return false;
                flag = (flag << 1);
            }
            val = tmp;
            return true;
        }

        public Object Eva(String str, NumberFormat fmt, bool updateAnswer)
        {
            Int64 result = 0;
            if (str.Length < 1)
                return false;
            try
            {
                m_numFmt = fmt;
                switch (fmt)
                {
                    case NumberFormat.DEC:
                        Object obj = m_calcEngine.Evaluate(str);
                        if (obj != null && updateAnswer)
                            AddVariable("ans", obj, "Last expression answer");   
                        return obj;
                    case NumberFormat.HEX:
                        return Int64.Parse(str, System.Globalization.NumberStyles.HexNumber);
                    case NumberFormat.BIN:
                        if (ParseBinStr(str, ref result))
                            return result;
                        else
                            throw new ArgumentException();
                    default:
                        return null;
                }
            }
            catch (Exception _ex)
            {
                throw _ex;
            }
        }
    }
}
