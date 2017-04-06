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
        public SortedList<string, SortedList<string, string>> eventData = 
            new SortedList<string, SortedList<string, string>> { };

      

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmEdit = new frmEdit();
            frmEdit.ShowDialog();
            addItem(frmEdit);
        }
        private void updateView()
        {
            lstItinerary.Items.Clear();
            foreach(string key in eventData.Keys)
            {
                SortedList<string, string> formData = eventData[key];
                List<string> frmData = new List<string> ();
                foreach (KeyValuePair<string, string> pair in formData)
                {
                    switch (formData["tabName"])
                    {
                        case "Flights":
                            frmData = new List<string>
                            { formData["tabName"],formData["date"],
                                formData["title"],formData["origin"],
                                formData["destination"] };
                            break;
                        case "Hotels":
                            frmData = new List<string>
                            { formData["tabName"] , formData["checkIn"],
                                formData["hotelName"], formData["address"],
                                formData["guestsNumber"],formData["checkOut"] };
                            break;
                        case "Events":
                            frmData = new List<string> {formData["tabName"],formData["date"],
                                formData["title"], formData["details"] };
                            break;
                        default:
                            break;
                    }
                }
                lstItinerary.Items.Add(string.Join("  ",frmData));
            }
        }

        private void addItem(Form frmEdit)
        {
            SortedList<string, string> formData = 
                (SortedList<string, string>)frmEdit.Tag;

            if (formData.Keys.Contains("date"))
            {
                if (eventData.Keys.Contains(formData["date"]))
                {
                    MessageBox.Show("Event Already Exists For Date\n" +
                        "Please Consider Revising Entry");
                }
                else
                {eventData.Add(formData["date"], formData);}
                //formData["title"]
            }

            else if (formData.Keys.Contains("checkIn"))
            {
                if (eventData.Keys.Contains(formData["checkIn"]))
                {
                    MessageBox.Show("Event Already Exists For Date\n" +
                        "Please Consider Revising Entry");
                }
                else
                { eventData.Add(formData["checkIn"], formData); }

            }
            else { Debug.Write("No Date String"); }
            updateView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit();
        }

        public void edit()
        {
            try
            {

                int selectedIndex = lstItinerary.SelectedIndex;
                string selected = lstItinerary.SelectedItem.ToString();

                Debug.Print("ln66: " + selected + "\n");
                
                foreach (string keySelected in eventData.Keys)
                {
                    if (selected.Contains(keySelected))
                    {
                        //eventData[key];
                        Form frmEdit = new frmEdit();
                        frmEdit.Tag = eventData[keySelected];
                        frmEdit.ShowDialog();

                        if (frmEdit.DialogResult == DialogResult.OK)
                        {
                            Debug.Print(string.Join(",", eventData[keySelected].Values));
                            eventData.Remove(keySelected.ToString());
                            //addItem(frmEdit);
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please make a selection");
                //throw;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
