using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnForm_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            strButtonText = btn.Text;
            MessageBox.Show(strButtonText);
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
                        MessageBox.Show("case 0" + Convert.ToString(this.Tag));
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
