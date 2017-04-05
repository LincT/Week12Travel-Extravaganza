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
        SortedList<string, string> tabFlights = new SortedList<string, string> { };

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
                        tabFlights.Add("tabName", selectedTab);
                        tabFlights.Add("date", dtpFlights.Text);
                        tabFlights.Add("title", "Flight");
                        tabFlights.Add("origin", txtOriginAP.Text);
                        tabFlights.Add("destination", txtDestinationAP.Text);

                        //tabFlights.Add(selectedTab);
                        //tabFlights.Add(dtpFlights.Text);
                        //tabFlights.Add("Flight");
                        //tabFlights.Add(txtOriginAP.Text);
                        //tabFlights.Add(txtDestinationAP.Text);

                        this.Tag = tabFlights;
                        
                        //Debug.Write("case 0" + Convert.ToString(this.Tag) + "\n");
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
                case "2":
                    if (strButtonText == "")
                    {

                    }
                    else
                    {

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
