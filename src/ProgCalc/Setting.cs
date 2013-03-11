using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;
using CalcEngine;

namespace yyscamper.ProgCalc
{
    class Setting
    {
        private XmlDocument xmlDoc;
        private static Setting m_instance = null;
        private string m_homeLastInputExpression;
        private string[] m_customResultExpression = new string[3];
		private ArrayList m_allFavExp = new ArrayList();
		private IntegerBits m_intBits = IntegerBits.BITS_64;
		private IntegerFormat m_intFmt = IntegerFormat.DEC;
		private CalcMode m_calcMode = CalcMode.FLOAT;
        private char m_binDelimiter = ',';

        public Setting()
        {
            SetDefault();
        }

        public char BinDelimiter
        {
            get
            {
                return m_binDelimiter;
            }
            set
            {
                m_binDelimiter = value;
            }
        }

		public CalcMode CurCalcMode
		{
			get
			{
				return m_calcMode;
			}
			set
			{
				m_calcMode = value;
			}
		}

		public IntegerBits CurIntBits
		{
			get
			{
				return m_intBits;
			}
			set
			{
				m_intBits = value;
			}
		}


		public IntegerFormat CurIntFmt
		{
			get
			{
				return m_intFmt;
			}
			set
			{
				m_intFmt = value;
			}
		}

        public string HomeLastInputExpression
        {
            get
            {
               return m_homeLastInputExpression;
            }
            set
            {
                m_homeLastInputExpression = value;
            }
        }

        public string[] CustomResultExpression
        {
            get
            {
                return m_customResultExpression;
            }
            set
            {
                m_customResultExpression = value;
            }
        }

		public ArrayList FavExpressions
		{
			get
			{
				return m_allFavExp;
			}
			set
			{
				if (value != null)
					m_allFavExp = value;
			}
		}
		public void AddFavExp(string str)
		{
			m_allFavExp.Add(str);
		}

		public void ClearFavExp()
		{
			m_allFavExp.Clear();
		}

        public void SetDefault()
        {
            m_customResultExpression[0] = "ans+1";
            m_customResultExpression[1] = "ans*2";
            m_customResultExpression[2] = "ans/2 + sin(pi/3)";

            m_homeLastInputExpression = "";
        }

        public bool Save()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement rootNode = xmlDoc.CreateElement(Properties.Resources.strAppName);
            xmlDoc.AppendChild(rootNode);

            XmlElement node = xmlDoc.CreateElement("Home");
            rootNode.AppendChild(node);

            XmlElement subNode = xmlDoc.CreateElement("LastInputExpression");
            subNode.InnerText = m_homeLastInputExpression;
            node.AppendChild(subNode);

            subNode = xmlDoc.CreateElement("InputMode");
            subNode.InnerText = "HEX";
            node.AppendChild(subNode);

            subNode = xmlDoc.CreateElement("FormatResult");
            subNode.InnerText = "Round";
            node.AppendChild(subNode);

            subNode = xmlDoc.CreateElement(Properties.Resources.strBinDelimiter);
            if (m_binDelimiter == (char)0)
                subNode.InnerText = "NONE";
            else if (m_binDelimiter == ' ')
                subNode.InnerText = "SPACE";
            else 
                subNode.InnerText = m_binDelimiter.ToString();
            node.AppendChild(subNode);

            /////////////////BEGIN Calc Board History //////////////////////////////
            node = xmlDoc.CreateElement("CalcBoardHistory");
            node.SetAttribute("max", "10");
            rootNode.AppendChild(node);

            subNode = xmlDoc.CreateElement("NO.1");
            subNode.InnerText = "Sin(2)+2/2 +2";
            node.AppendChild(subNode);

            subNode = xmlDoc.CreateElement("NO.2");
            subNode.InnerText = "cos(2)+2/2 +2";
            node.AppendChild(subNode);

            /////////////////END Calc Board History //////////////////////////////

            /////////////////BEGIN Custom Result //////////////////////////////
            node = xmlDoc.CreateElement(Properties.Resources.strXmlCustomResultNodeName);
            rootNode.AppendChild(node);

            subNode = xmlDoc.CreateElement("NO.1");
            subNode.InnerText = m_customResultExpression[0];
            node.AppendChild(subNode);

            subNode = xmlDoc.CreateElement("NO.2");
            subNode.InnerText = m_customResultExpression[1];
            node.AppendChild(subNode);

            subNode = xmlDoc.CreateElement("NO.3");
            subNode.InnerText = m_customResultExpression[2];
            node.AppendChild(subNode);
            /////////////////END Custom Result //////////////////////////////

			/////////////////BEGIN Favorite Expression //////////////////////////////
			node = xmlDoc.CreateElement(Properties.Resources.strXmlFavExpNodeName);
			rootNode.AppendChild(node);

			if (m_allFavExp != null)
			{
				node.SetAttribute("count", m_allFavExp.Count.ToString());

				for (int i = 0; i < m_allFavExp.Count; i++ )
				{
					subNode = xmlDoc.CreateElement("NO." + (i+1).ToString());
					subNode.InnerText = (string)m_allFavExp[i];
					node.AppendChild(subNode);
				}
			}
			/////////////////END Favorite //////////////////////////////

			/////////////////BEGIN Variable //////////////////////////////
			node = xmlDoc.CreateElement(Properties.Resources.strXmlVarNodeName);
			rootNode.AppendChild(node);

			CalcVar[] allVar = ExpTool.GetInstance().GetAllVariables();
			if (allVar != null)
			{
				node.SetAttribute("count", allVar.Length.ToString());

				for (int i = 0; i < allVar.Length; i++)
				{
					subNode = xmlDoc.CreateElement("NO." + i);
					subNode.SetAttribute("name", allVar[i].name);
					subNode.SetAttribute("value", allVar[i].value.ToString());
					node.AppendChild(subNode);
				}
			}
			/////////////////END Variable //////////////////////////////

            xmlDoc.Save(Properties.Resources.strConfigFileName);

            return true;
        }

        public bool Load()
        {
            SetDefault();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Properties.Resources.strConfigFileName);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode(Properties.Resources.strAppName).ChildNodes;

                foreach (XmlElement ele in nodeList)
                {
                    if (ele.Name == "Home")
                    {
                        try
                        {
                            m_homeLastInputExpression = ele["LastInputExpression"].InnerText;
                        }
                        catch
                        {
                        }
                    }
                    else if (ele.Name == Properties.Resources.strBinDelimiter)
                    {
                        if (ele.InnerText.Length == 0 || ele.InnerText == "NONE")
                            m_binDelimiter = (char)0;
                        else if (ele.InnerText == "SPACE")
                            m_binDelimiter = ' ';
                        else
                            m_binDelimiter = ele.InnerText[0];
                
                    }
                    else if (ele.Name == Properties.Resources.strXmlCustomResultNodeName)
                    {
                        m_customResultExpression[0] = ele["NO.1"].InnerText;
                        m_customResultExpression[1] = ele["NO.2"].InnerText;
                        m_customResultExpression[2] = ele["NO.3"].InnerText;
                    }
                    else if (ele.Name == Properties.Resources.strXmlFavExpNodeName)
                    {
                        XmlNodeList allFavExpNode = ele.ChildNodes;

                        int len = allFavExpNode.Count;
                        m_allFavExp.Clear();
                        int i = 0;

                        foreach (XmlElement favNode in allFavExpNode)
                        {
                            m_allFavExp.Add(favNode.InnerText);
                            i++;
                        }


                    }
                    else if (ele.Name == Properties.Resources.strXmlVarNodeName)
                    {
                        XmlNodeList allVarNodes = ele.ChildNodes;
                        int len = allVarNodes.Count;
                        ExpTool.GetInstance().ClearVariables();

                        foreach (XmlElement varNode in allVarNodes)
                        {
                            try
                            {
                                string name = CalcVar.ValidateName(varNode.GetAttribute("name"));
                                object val = CalcVar.ParseValue(varNode.GetAttribute("value"));
                                ExpTool.GetInstance().AddVariable(name, val);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Setting GetInstance()
        {
            if (m_instance == null)
                m_instance = new Setting();
            return m_instance;
        }
    }
}
