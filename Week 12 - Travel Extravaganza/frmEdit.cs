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

        List<string> lstTabHotels = new List<string>();
        string strButtonText;

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
                case "Hotels":
                    if (strButtonText == "Okay")
                    {
                        // Tab
                        this.lstTabHotels.Add(selectedTab);
                        // Check In
                        this.lstTabHotels.Add(dtpCheckIn.Text);
                        // Hotel Name
                        this.lstTabHotels.Add(txtHotelName.Text);
                        // Hotel Address
                        this.lstTabHotels.Add(txtAddress.Text);
                        // Number of Guests
                        this.lstTabHotels.Add(cbGuests.Text);
                        // Check Out
                        this.lstTabHotels.Add(dtpCheckOut.Text);
                        foreach (string item in lstTabHotels) {
                            Debug.Write(item + "\n");
                        }
                    }
                    else
                    {
                        //Do Nothing...
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
