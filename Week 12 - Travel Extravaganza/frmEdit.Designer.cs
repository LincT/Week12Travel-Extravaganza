namespace Week_12___Travel_Extravaganza
{
    partial class frmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbHotels = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditOkay = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGuests = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbHotels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbHotels);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 263);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flights";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Airport:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origin Airport:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tbHotels
            // 
            this.tbHotels.Controls.Add(this.txtAddress);
            this.tbHotels.Controls.Add(this.label5);
            this.tbHotels.Controls.Add(this.txtHotelName);
            this.tbHotels.Controls.Add(this.label4);
            this.tbHotels.Controls.Add(this.cbGuests);
            this.tbHotels.Controls.Add(this.label3);
            this.tbHotels.Controls.Add(this.label6);
            this.tbHotels.Controls.Add(this.dtpCheckOut);
            this.tbHotels.Controls.Add(this.label7);
            this.tbHotels.Controls.Add(this.dtpCheckIn);
            this.tbHotels.Location = new System.Drawing.Point(4, 22);
            this.tbHotels.Name = "tbHotels";
            this.tbHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tbHotels.Size = new System.Drawing.Size(365, 237);
            this.tbHotels.TabIndex = 1;
            this.tbHotels.Text = "Hotels";
            this.tbHotels.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(365, 237);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditCancel.Location = new System.Drawing.Point(206, 268);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 3;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnEditOkay
            // 
            this.btnEditOkay.Location = new System.Drawing.Point(287, 268);
            this.btnEditOkay.Name = "btnEditOkay";
            this.btnEditOkay.Size = new System.Drawing.Size(75, 23);
            this.btnEditOkay.TabIndex = 4;
            this.btnEditOkay.Text = "Okay";
            this.btnEditOkay.UseVisualStyleBackColor = true;
            this.btnEditOkay.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 67);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Address:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(110, 41);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(200, 20);
            this.txtHotelName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hotel Name:";
            // 
            // cbGuests
            // 
            this.cbGuests.FormattingEnabled = true;
            this.cbGuests.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbGuests.Location = new System.Drawing.Point(110, 149);
            this.cbGuests.Name = "cbGuests";
            this.cbGuests.Size = new System.Drawing.Size(47, 21);
            this.cbGuests.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Guests:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Check-out:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(110, 123);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Check-in:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(110, 93);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 10;
            // 
            // frmEdit
            // 
            this.AcceptButton = this.btnEditOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEditCancel;
            this.ClientSize = new System.Drawing.Size(374, 298);
            this.Controls.Add(this.btnEditOkay);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEdit_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbHotels.ResumeLayout(false);
            this.tbHotels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbHotels;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditOkay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGuests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
    }
}