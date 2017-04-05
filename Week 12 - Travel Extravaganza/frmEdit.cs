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

        private void btnEditOkay_Click(object sender, EventArgs e)
        {
            SortedList<string, string> frmData = new SortedList<string, string> { };
            string dbgOut = "Control Values: " + dateTimePicker1.Text + "\n";
            Debug.Write(dbgOut);


        }
    }
}
