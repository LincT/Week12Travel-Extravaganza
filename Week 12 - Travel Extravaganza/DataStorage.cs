using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_12___Travel_Extravaganza
{
    class DataStorage
    {
        private SortedList<string, SortedList<string, string>> masterData =
            new SortedList<string, SortedList<string, string>> { };

        public void addItem(Form frmEdit)
        {
            SortedList<string, string> formData =
                (SortedList<string, string>)frmEdit.Tag;

            if (formData.Keys.Contains("date"))
            {
                if (masterData.Keys.Contains(formData["date"]))
                { masterData[formData["date"]] = formData; }
                else
                { masterData.Add(formData["date"], formData); }
            }

            else if (formData.Keys.Contains("checkIn"))
            {
                if (masterData.Keys.Contains(formData["checkIn"]))
                { masterData[formData["checkIn"]] = formData; }
                else
                { masterData.Add(formData["checkIn"], formData); }

            }
            else { Debug.Write("No Date String"); }
           
        }
        public Object getData()
        {
            return masterData;
        }
        public void remData(string item)
        {
            if (masterData.Keys.Contains(item))
            { masterData.Remove(item); }
            
        }
        public SortedList<string,string> getItem(string item)
        {
            try {
                return masterData[item];
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
            
        }
        public IList<string> getItems()
        {
            return masterData.Keys;
        }
        public void clearData()
        {
            masterData.Clear();
        }
    }
}
