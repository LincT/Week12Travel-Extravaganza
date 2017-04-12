using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_12___Travel_Extravaganza
{
    public partial class frmMain : Form
    {
        //private SortedList<string, SortedList<string, string>> eventData = 
        //    new SortedList<string, SortedList<string, string>> { };
        DataStorage resource = new DataStorage();
        
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmEdit = new frmEdit();
            frmEdit.ShowDialog();
            resource.addItem(frmEdit);
            updateView();
        }
        private void apiTester()
        {
            
        }
        private void updateView()
        {
            lstItinerary.Items.Clear();
            SortedList<string, SortedList<string, string>> eventData =
                (SortedList < string, SortedList< string, string>> )resource.getData();
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

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit();
        }

        public void edit()
        {
            try
            {
                string selected = lstItinerary.SelectedItem.ToString();
                foreach (string keySelected in resource.getItems())
                {
                    if (selected.Contains(keySelected))
                    {

                        Form frmEdit = new frmEdit();
                        frmEdit.Tag = resource.getItem(keySelected);
                        frmEdit.ShowDialog();

                        if (frmEdit.DialogResult == DialogResult.OK)
                        {
                            resource.addItem(frmEdit);
                        }
                        break;
                    }
                }
                updateView();
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
            try
            {
                string selected = lstItinerary.SelectedItem.ToString();
               
                foreach (string keySelected in resource.getItems())
                {
                    if (selected.Contains(keySelected))
                    {
                        Debug.Write("Selected: " + keySelected);
                        resource.remData(keySelected);
                        updateView();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }

        private void btnTester_Click(object sender, EventArgs e)
        {
            resource.connectionTest();
        }
    }
}
