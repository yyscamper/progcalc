using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace yyscamper.ProgCalc
{
    class HistoryEntry
    {
        public Object value;
        public DateTime time;

        public HistoryEntry()
        {
            value = null;
            time = DateTime.Now;
        }

        public HistoryEntry(object obj)
        {
            value = obj;
            time = DateTime.Now;
        }
    }

    class HistoryController
    {
        private bool m_ignoreSame;
        private bool m_ignoreCase;
        private ArrayList m_history;
        private int m_maxSize;
        private int m_travelIndex;

        public HistoryController()
        {
            m_ignoreCase = false;
            m_ignoreSame = true;
            m_history = new ArrayList();
            m_maxSize = 100;
            m_travelIndex = 0;
        }

        public int Count
        {
            get
            {
                return m_history.Count;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= m_history.Count)
                    return null;
                else
                    return ((HistoryEntry)m_history[index]).value.ToString();
            }
        }

        public HistoryController(int maxSize, bool ignoreSame, bool ignoreCase)
        {
            m_maxSize = maxSize;
            m_ignoreSame = ignoreSame;
            m_ignoreCase = ignoreCase;
            m_history = new ArrayList();
            m_travelIndex = 0;
        }

        public bool Add(object obj)
        {
            if (obj == null)
                return false;

            //Find a same history entry already in the history list
            if (m_ignoreSame)
            {
                foreach (HistoryEntry et in m_history)
                {
                    bool ret = true;
                    if (m_ignoreCase)
                        ret = et.value.ToString().Equals(obj.ToString(), StringComparison.OrdinalIgnoreCase);
                    else
                        ret = et.value.ToString().Equals(obj.ToString());
                    if (ret)
                        return false;
                }
            }

            if (m_history.Count >= m_maxSize)
            {
                m_history.RemoveAt(0);
            }

            HistoryEntry he = new HistoryEntry(obj);
            m_history.Add(he);
            m_travelIndex = m_history.Count - 1;
            return true;
        }

        public string[] AllHistory()
        {
            string[] hl = new string[m_history.Count];
            for (int i=0; i<m_history.Count; i++)
            {
                hl[i] = ((HistoryEntry)m_history[i]).value.ToString();
            }
            return hl;
        }

        public string Previous()
        {
            if (m_travelIndex >= m_history.Count)
                m_travelIndex = m_history.Count - 1;
            
            if (m_travelIndex < 0)
                return null;
            string str = ((HistoryEntry)m_history[m_travelIndex]).value.ToString();
            m_travelIndex--;
            return str;
        }

        public string Next()
        {
            if (m_travelIndex < 0)
                m_travelIndex = 0;
            if (m_travelIndex >= m_history.Count)
                return null;
            string str = ((HistoryEntry)m_history[m_travelIndex]).value.ToString();
            m_travelIndex++;
            return str;   
        }

        public void ResetTravel()
        {
            m_travelIndex = 0;
        }
    }
}
