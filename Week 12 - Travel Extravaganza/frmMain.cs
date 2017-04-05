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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Form frmEdit = new frmEdit();
            frmEdit.ShowDialog();

            SortedList<string, string> formData = (SortedList<string, string>)frmEdit.Tag;

            string dataFromForm = "";
            foreach (var item in formData)
            {
                dataFromForm += item + "\n";
            }
            string frmData;
            switch (formData["tabName"])
            {
                case "Flights":
                    frmData = formData["tabName"] + " " + formData["date"] + " " + formData["title"] + " " +
                                     formData["origin"] + " " + formData["destination"];
                    lstItinerary.Items.Add(frmData);
                    break;
                case "Hotels":
                    frmData = formData["tabName"] + " " + formData["checkIn"] + " " + formData["hotelName"] + " " +
                                     formData["address"] + " " + formData["guestsNumber"] + " " + formData["checkOut"];
                    lstItinerary.Items.Add(frmData);
                    break;
                case "Events":
                    frmData = formData["tabName"] + " " + formData["date"] + " " + formData["title"] + " " +
                                     formData["details"];
                    lstItinerary.Items.Add(frmData);
                    break;
                default:
                    break;
            }
        }
    }
}
