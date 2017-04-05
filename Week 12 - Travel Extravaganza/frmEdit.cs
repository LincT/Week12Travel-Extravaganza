using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_12___Travel_Extravaganza
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        string strButtonText;
        SortedList<string, string> dataList = new SortedList<string, string> { };

        private void btnForm_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            strButtonText = btn.Text;
            Debug.Write(strButtonText + "\n");
            this.Close();
        }

        private void frmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            string selectedTab = tabControl1.SelectedTab.Text;
            switch (selectedTab)
            {
                case "Flights":
                    if (strButtonText == "Okay")
                    {
                        this.Tag = "test";
                        Debug.Write("case 0" + Convert.ToString(this.Tag) + "\n");
                    }
                    else
                    {

                    }
                    break;
                case "1":
                    if (strButtonText == "")
                    {

                    }
                    else
                    {

                    }
                    break;
                case "Events":
                    if (strButtonText == "Okay")
                    {
                        dataList.Add("type",tabControl1.SelectedTab.Text);
                        dataList.Add("date", dtpEventDate.Text);
                        dataList.Add("Title", "");
                        dataList.Add("Details", "");
                        this.Tag = dataList;

                    }
                    else
                    {
                        
                    }
                    break;
                default:
                    break;
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
