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
        //SortedList<string, string> tabFlights = new SortedList<string, string> { };
        //SortedList<string, string> tabHotels = new SortedList<string, string> { };
        //SortedList<string, string> tabEvents = new SortedList<string, string> { };
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
                        //this.Tag = tabFlights;
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
                        //this.Tag = tabHotels;
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
                        //this.Tag = tabEvents;
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
    }
}
