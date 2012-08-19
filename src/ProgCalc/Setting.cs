using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace yyscamper.ProgCalc
{
    class Setting
    {
        private XmlDocument xmlDoc;
        private static Setting m_instance = null;
        private string m_homeLastInputExpression;
        private string[] m_customResultExpression = new string[3];

        public Setting()
        {
            SetDefault();
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
            rootNode.AppendChild(subNode);

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
                    else if (ele.Name == Properties.Resources.strXmlCustomResultNodeName)
                    {
                        m_customResultExpression[0] = ele["NO.1"].InnerText;
                        m_customResultExpression[1] = ele["NO.2"].InnerText;
                        m_customResultExpression[2] = ele["NO.3"].InnerText;
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
