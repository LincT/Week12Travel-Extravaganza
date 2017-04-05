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
        SortedList<string, string> tabHotels = new SortedList<string, string> { };
        SortedList<string, string> tabEvents = new SortedList<string, string> { };

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
                        this.Tag = tabFlights;
                    }
                    else
                    {

                    }
                    break;
                case "Hotels":
                    if (strButtonText == "Okay")
                    {
                        tabHotels.Add("tabName", selectedTab);
                        tabHotels.Add("checkIn", dtpCheckIn.Text);
                        tabHotels.Add("hotelName", txtHotel.Text);
                        tabHotels.Add("address", txtAddress.Text);
                        tabHotels.Add("guestsNumber", cbGuests.Text);
                        tabHotels.Add("checkOut", dtpCheckOut.Text);
                        this.Tag = tabHotels;
                    }
                    else
                    {
                        // Do Nothing...
                    }
                    break;
                case "Events":
                    if (strButtonText == "Okay")
                    {
                        tabEvents.Add("tabName", selectedTab);
                        tabEvents.Add("date", dtpEvents.Text);
                        tabEvents.Add("title", txtEventTitle.Text);
                        tabEvents.Add("details", txtEventDetails.Text);
                        this.Tag = tabEvents;
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
