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
        SortedList<string, string> tabData = new SortedList<string, string> { };

        private void btnForm_Click(object sender, EventArgs e)
        {
            strButtonText = ((Button)sender).Text;
            Debug.Write(strButtonText + "\n");
            this.Close();
        }

        private void frmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Write("Sender:" + sender.ToString() + "\n");
            string selectedTab = tabControl1.SelectedTab.Text;
            switch (selectedTab)
            {
                case "Flights":
                    if (strButtonText == "Okay")
                    {
                        tabData.Add("tabName", selectedTab);
                        tabData.Add("date", dtpFlights.Text);
                        tabData.Add("title", "Flight");
                        tabData.Add("origin", txtOriginAP.Text);
                        tabData.Add("destination", txtDestinationAP.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {

                    }
                    break;
                case "Hotels":
                    if (strButtonText == "Okay")
                    {
                        tabData.Add("tabName", selectedTab);
                        tabData.Add("checkIn", dtpCheckIn.Text);
                        tabData.Add("hotelName", txtHotel.Text);
                        tabData.Add("address", txtAddress.Text);
                        tabData.Add("guestsNumber", cbGuests.Text);
                        tabData.Add("checkOut", dtpCheckOut.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        // Do Nothing...
                    }
                    break;
                case "Events":
                    if (strButtonText == "Okay")
                    {
                        tabData.Add("tabName", selectedTab);
                        tabData.Add("date", dtpEvents.Text);
                        tabData.Add("title", txtEventTitle.Text);
                        tabData.Add("details", txtEventDetails.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {

                    }
                    break;
                default:
                    break;
            }
            this.Tag = tabData;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                SortedList<string, string> inputData = new SortedList<string, string> { };
                foreach (KeyValuePair<string, string> pair in readInput())
                    inputData.Add(pair.Key,pair.Value);
                switch (inputData["tabName"])
                {
                    case "Events":
                        dtpEvents.Text = inputData["date"];
                        txtEventTitle.Text = inputData["title"];
                        txtEventDetails.Text = inputData["details"];
                        tabControl1.SelectedTab = tabPage3;
                        break;
                    case "Flights":
                        dtpFlights.Text = inputData["date"];
                        txtOriginAP.Text = inputData["origin"];
                        txtDestinationAP.Text = inputData["destination"];
                        tabControl1.SelectedTab = tabPage1;
                        break;
                    case "Hotels":
                        dtpCheckIn.Text = inputData["checkIn"];
                        dtpCheckOut.Text = inputData["checkOut"];
                        txtHotel.Text = inputData["hotelName"];
                        txtAddress.Text = inputData["address"];
                        cbGuests.Text = inputData["guestsNumber"];
                        tabControl1.SelectedTab = tbHotels;
                        break;
                }

            }
            else { Debug.Write("frmEdit Null"); }
        }
        public SortedList<string,string> readInput()
        {
            SortedList<string, string> inData = new SortedList<string, string> { };
            string resultDbg = "frmEdit readInput() = \n";
            foreach(KeyValuePair<string,string> pair in (SortedList<string,string>)this.Tag)
            {
                resultDbg += pair.Key+ ": " + pair.Value + "\n";
            }
            Debug.Write(resultDbg);
            return (SortedList<string, string>)this.Tag;
        }
    }
}
