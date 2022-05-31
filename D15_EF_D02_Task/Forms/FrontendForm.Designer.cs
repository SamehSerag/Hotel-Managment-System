namespace D15_EF_D02_Task.Forms
{
    partial class FrontendForm
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
            this.reservationTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnFinalizeBill = new System.Windows.Forms.Button();
            this.checkFoodSatus = new System.Windows.Forms.CheckBox();
            this.checkSMS = new System.Windows.Forms.CheckBox();
            this.checkCheckIn = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.combRoomN = new System.Windows.Forms.ComboBox();
            this.combFloor = new System.Windows.Forms.ComboBox();
            this.combRoomType = new System.Windows.Forms.ComboBox();
            this.combQtGuest = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.comboxState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtApt = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboxGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.comboxDay = new System.Windows.Forms.ComboBox();
            this.comboxMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lablName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnSaveChangeSearch = new System.Windows.Forms.Button();
            this.gridSearchView = new System.Windows.Forms.DataGridView();
            this.lablNotFound = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUniversalSearch = new System.Windows.Forms.TextBox();
            this.tabAdvView = new System.Windows.Forms.TabPage();
            this.gridAllReservationsView = new System.Windows.Forms.DataGridView();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listboxReserved = new System.Windows.Forms.ListBox();
            this.listboxOccubied = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.reservationTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchView)).BeginInit();
            this.tabAdvView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllReservationsView)).BeginInit();
            this.tabRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reservationTab);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabAdvView);
            this.tabControl1.Controls.Add(this.tabRoom);
            this.tabControl1.Location = new System.Drawing.Point(10, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 405);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // reservationTab
            // 
            this.reservationTab.BackColor = System.Drawing.Color.White;
            this.reservationTab.Controls.Add(this.panel3);
            this.reservationTab.Controls.Add(this.panel2);
            this.reservationTab.Controls.Add(this.panel1);
            this.reservationTab.Location = new System.Drawing.Point(4, 24);
            this.reservationTab.Margin = new System.Windows.Forms.Padding(3, 2, 13, 2);
            this.reservationTab.Name = "reservationTab";
            this.reservationTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationTab.Size = new System.Drawing.Size(1095, 377);
            this.reservationTab.TabIndex = 0;
            this.reservationTab.Text = "Reservation";
            this.reservationTab.Click += new System.EventHandler(this.reservationTab_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.comboSearch);
            this.panel3.Location = new System.Drawing.Point(781, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 362);
            this.panel3.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 314);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(274, 30);
            this.btnNew.TabIndex = 38;
            this.btnNew.Text = "New Reservation";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 272);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(274, 30);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit Existing Reservation";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 211);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(274, 30);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 176);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(274, 30);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboSearch
            // 
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "[ID]    [NAME]    [PHONE NUMBER]"});
            this.comboSearch.Location = new System.Drawing.Point(13, 10);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(274, 23);
            this.comboSearch.TabIndex = 34;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.btnFinalizeBill);
            this.panel2.Controls.Add(this.checkFoodSatus);
            this.panel2.Controls.Add(this.checkSMS);
            this.panel2.Controls.Add(this.checkCheckIn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.combRoomN);
            this.panel2.Controls.Add(this.combFloor);
            this.panel2.Controls.Add(this.combRoomType);
            this.panel2.Controls.Add(this.combQtGuest);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(390, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 362);
            this.panel2.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(14, 328);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(340, 30);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnFinalizeBill
            // 
            this.btnFinalizeBill.Location = new System.Drawing.Point(15, 303);
            this.btnFinalizeBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizeBill.Name = "btnFinalizeBill";
            this.btnFinalizeBill.Size = new System.Drawing.Size(340, 22);
            this.btnFinalizeBill.TabIndex = 32;
            this.btnFinalizeBill.Text = "Finalize Bill";
            this.btnFinalizeBill.UseVisualStyleBackColor = true;
            this.btnFinalizeBill.Click += new System.EventHandler(this.btnfinalizePaymentl_Click);
            // 
            // checkFoodSatus
            // 
            this.checkFoodSatus.AutoSize = true;
            this.checkFoodSatus.Location = new System.Drawing.Point(214, 280);
            this.checkFoodSatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkFoodSatus.Name = "checkFoodSatus";
            this.checkFoodSatus.Size = new System.Drawing.Size(129, 19);
            this.checkFoodSatus.TabIndex = 31;
            this.checkFoodSatus.Text = "Food/Supply Status";
            this.checkFoodSatus.UseVisualStyleBackColor = true;
            // 
            // checkSMS
            // 
            this.checkSMS.AutoSize = true;
            this.checkSMS.Location = new System.Drawing.Point(113, 280);
            this.checkSMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSMS.Name = "checkSMS";
            this.checkSMS.Size = new System.Drawing.Size(78, 19);
            this.checkSMS.TabIndex = 30;
            this.checkSMS.Text = "Send SMS";
            this.checkSMS.UseVisualStyleBackColor = true;
            // 
            // checkCheckIn
            // 
            this.checkCheckIn.AutoSize = true;
            this.checkCheckIn.Location = new System.Drawing.Point(15, 280);
            this.checkCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkCheckIn.Name = "checkCheckIn";
            this.checkCheckIn.Size = new System.Drawing.Size(72, 19);
            this.checkCheckIn.TabIndex = 29;
            this.checkCheckIn.Text = "Check In";
            this.checkCheckIn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 22);
            this.button1.TabIndex = 28;
            this.button1.Text = "Food and Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 204);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(340, 23);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Depreture [Date]";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 154);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 23);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Entiry [Date]";
            // 
            // combRoomN
            // 
            this.combRoomN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combRoomN.FormattingEnabled = true;
            this.combRoomN.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410",
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509",
            "510"});
            this.combRoomN.Location = new System.Drawing.Point(187, 85);
            this.combRoomN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combRoomN.Name = "combRoomN";
            this.combRoomN.Size = new System.Drawing.Size(168, 23);
            this.combRoomN.TabIndex = 23;
            // 
            // combFloor
            // 
            this.combFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFloor.FormattingEnabled = true;
            this.combFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combFloor.Location = new System.Drawing.Point(15, 85);
            this.combFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combFloor.Name = "combFloor";
            this.combFloor.Size = new System.Drawing.Size(168, 23);
            this.combFloor.TabIndex = 21;
            // 
            // combRoomType
            // 
            this.combRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combRoomType.FormattingEnabled = true;
            this.combRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin",
            "Duplex",
            "Suite"});
            this.combRoomType.Location = new System.Drawing.Point(187, 34);
            this.combRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combRoomType.Name = "combRoomType";
            this.combRoomType.Size = new System.Drawing.Size(168, 23);
            this.combRoomType.TabIndex = 20;
            this.combRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // combQtGuest
            // 
            this.combQtGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combQtGuest.FormattingEnabled = true;
            this.combQtGuest.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.combQtGuest.Location = new System.Drawing.Point(15, 34);
            this.combQtGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combQtGuest.Name = "combQtGuest";
            this.combQtGuest.Size = new System.Drawing.Size(168, 23);
            this.combQtGuest.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Your Choices";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtZipCode);
            this.panel1.Controls.Add(this.comboxState);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtApt);
            this.panel1.Controls.Add(this.txtStreet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboxGender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.comboxDay);
            this.panel1.Controls.Add(this.comboxMonth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lablName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Location = new System.Drawing.Point(5, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 364);
            this.panel1.TabIndex = 0;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(185, 335);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZipCode.Multiline = true;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(164, 27);
            this.txtZipCode.TabIndex = 18;
            // 
            // comboxState
            // 
            this.comboxState.AutoCompleteCustomSource.AddRange(new string[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.comboxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxState.FormattingEnabled = true;
            this.comboxState.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.comboxState.Location = new System.Drawing.Point(8, 340);
            this.comboxState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxState.Name = "comboxState";
            this.comboxState.Size = new System.Drawing.Size(164, 23);
            this.comboxState.TabIndex = 17;
            this.comboxState.SelectedIndexChanged += new System.EventHandler(this.comboxState_SelectedIndexChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(185, 300);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(164, 27);
            this.txtCity.TabIndex = 16;
            // 
            // txtApt
            // 
            this.txtApt.Location = new System.Drawing.Point(8, 300);
            this.txtApt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApt.Multiline = true;
            this.txtApt.Name = "txtApt";
            this.txtApt.Size = new System.Drawing.Size(164, 27);
            this.txtApt.TabIndex = 15;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(8, 269);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.Multiline = true;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(341, 27);
            this.txtStreet.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(8, 238);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(341, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(8, 188);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(341, 27);
            this.txtPhone.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone Number";
            // 
            // comboxGender
            // 
            this.comboxGender.FormattingEnabled = true;
            this.comboxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboxGender.Location = new System.Drawing.Point(8, 138);
            this.comboxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxGender.Name = "comboxGender";
            this.comboxGender.Size = new System.Drawing.Size(341, 23);
            this.comboxGender.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gender";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(247, 87);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(102, 22);
            this.txtYear.TabIndex = 6;
            // 
            // comboxDay
            // 
            this.comboxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDay.FormattingEnabled = true;
            this.comboxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboxDay.Location = new System.Drawing.Point(131, 87);
            this.comboxDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxDay.Name = "comboxDay";
            this.comboxDay.Size = new System.Drawing.Size(96, 23);
            this.comboxDay.TabIndex = 5;
            this.comboxDay.SelectedIndexChanged += new System.EventHandler(this.comboxDay_SelectedIndexChanged);
            // 
            // comboxMonth
            // 
            this.comboxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxMonth.FormattingEnabled = true;
            this.comboxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboxMonth.Location = new System.Drawing.Point(8, 87);
            this.comboxMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxMonth.Name = "comboxMonth";
            this.comboxMonth.Size = new System.Drawing.Size(109, 23);
            this.comboxMonth.TabIndex = 4;
            this.comboxMonth.SelectedIndexChanged += new System.EventHandler(this.comboxMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "BirthDay";
            // 
            // lablName
            // 
            this.lablName.AutoSize = true;
            this.lablName.Location = new System.Drawing.Point(8, 14);
            this.lablName.Name = "lablName";
            this.lablName.Size = new System.Drawing.Size(39, 15);
            this.lablName.TabIndex = 2;
            this.lablName.Text = "Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(185, 31);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(172, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(8, 31);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 27);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.btnSaveChangeSearch);
            this.tabSearch.Controls.Add(this.gridSearchView);
            this.tabSearch.Controls.Add(this.lablNotFound);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.txtUniversalSearch);
            this.tabSearch.Location = new System.Drawing.Point(4, 24);
            this.tabSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearch.Size = new System.Drawing.Size(1095, 377);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "UniversalSearch";
            this.tabSearch.UseVisualStyleBackColor = true;
            this.tabSearch.Click += new System.EventHandler(this.tabSearch_Click);
            // 
            // btnSaveChangeSearch
            // 
            this.btnSaveChangeSearch.Location = new System.Drawing.Point(978, 330);
            this.btnSaveChangeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveChangeSearch.Name = "btnSaveChangeSearch";
            this.btnSaveChangeSearch.Size = new System.Drawing.Size(97, 26);
            this.btnSaveChangeSearch.TabIndex = 4;
            this.btnSaveChangeSearch.Text = "Save Change";
            this.btnSaveChangeSearch.UseVisualStyleBackColor = true;
            this.btnSaveChangeSearch.Click += new System.EventHandler(this.btnSaveChangeSearch_Click);
            // 
            // gridSearchView
            // 
            this.gridSearchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchView.Location = new System.Drawing.Point(26, 103);
            this.gridSearchView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSearchView.Name = "gridSearchView";
            this.gridSearchView.RowHeadersWidth = 51;
            this.gridSearchView.RowTemplate.Height = 29;
            this.gridSearchView.Size = new System.Drawing.Size(1049, 207);
            this.gridSearchView.TabIndex = 3;
            // 
            // lablNotFound
            // 
            this.lablNotFound.AutoSize = true;
            this.lablNotFound.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lablNotFound.ForeColor = System.Drawing.Color.Red;
            this.lablNotFound.Location = new System.Drawing.Point(316, 154);
            this.lablNotFound.Name = "lablNotFound";
            this.lablNotFound.Size = new System.Drawing.Size(255, 45);
            this.lablNotFound.TabIndex = 2;
            this.lablNotFound.Text = "Sorry Not Found";
            this.lablNotFound.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1008, 44);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUniversalSearch
            // 
            this.txtUniversalSearch.Location = new System.Drawing.Point(26, 44);
            this.txtUniversalSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUniversalSearch.Multiline = true;
            this.txtUniversalSearch.Name = "txtUniversalSearch";
            this.txtUniversalSearch.Size = new System.Drawing.Size(950, 26);
            this.txtUniversalSearch.TabIndex = 0;
            // 
            // tabAdvView
            // 
            this.tabAdvView.Controls.Add(this.gridAllReservationsView);
            this.tabAdvView.Location = new System.Drawing.Point(4, 24);
            this.tabAdvView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdvView.Name = "tabAdvView";
            this.tabAdvView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdvView.Size = new System.Drawing.Size(1095, 377);
            this.tabAdvView.TabIndex = 2;
            this.tabAdvView.Text = "Reservation Adv. View";
            this.tabAdvView.UseVisualStyleBackColor = true;
            this.tabAdvView.Click += new System.EventHandler(this.tabAdvView_Click);
            // 
            // gridAllReservationsView
            // 
            this.gridAllReservationsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllReservationsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAllReservationsView.Location = new System.Drawing.Point(3, 2);
            this.gridAllReservationsView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridAllReservationsView.Name = "gridAllReservationsView";
            this.gridAllReservationsView.RowHeadersWidth = 51;
            this.gridAllReservationsView.RowTemplate.Height = 29;
            this.gridAllReservationsView.Size = new System.Drawing.Size(1089, 373);
            this.gridAllReservationsView.TabIndex = 0;
            this.gridAllReservationsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.label12);
            this.tabRoom.Controls.Add(this.label11);
            this.tabRoom.Controls.Add(this.label10);
            this.tabRoom.Controls.Add(this.label9);
            this.tabRoom.Controls.Add(this.listboxReserved);
            this.tabRoom.Controls.Add(this.listboxOccubied);
            this.tabRoom.Location = new System.Drawing.Point(4, 24);
            this.tabRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRoom.Size = new System.Drawing.Size(1095, 377);
            this.tabRoom.TabIndex = 3;
            this.tabRoom.Text = "Room Availibility";
            this.tabRoom.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(571, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Reserved";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(11, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Occupied";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(394, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Room# | Type  |  ID#   |       Name      |      Phone #      |     Entry       | " +
    "   Depart";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Room# | Type  |  ID#   |       Name      |      Phone #";
            // 
            // listboxReserved
            // 
            this.listboxReserved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listboxReserved.FormattingEnabled = true;
            this.listboxReserved.ItemHeight = 15;
            this.listboxReserved.Location = new System.Drawing.Point(570, 73);
            this.listboxReserved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxReserved.Name = "listboxReserved";
            this.listboxReserved.Size = new System.Drawing.Size(509, 304);
            this.listboxReserved.TabIndex = 1;
            // 
            // listboxOccubied
            // 
            this.listboxOccubied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listboxOccubied.FormattingEnabled = true;
            this.listboxOccubied.ItemHeight = 15;
            this.listboxOccubied.Location = new System.Drawing.Point(11, 73);
            this.listboxOccubied.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxOccubied.Name = "listboxOccubied";
            this.listboxOccubied.Size = new System.Drawing.Size(544, 304);
            this.listboxOccubied.TabIndex = 0;
            this.listboxOccubied.SelectedIndexChanged += new System.EventHandler(this.listboxOccubied_SelectedIndexChanged);
            // 
            // FrontendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 441);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrontendForm";
            this.Text = "Frontend";
            this.Load += new System.EventHandler(this.Frontend_Load);
            this.tabControl1.ResumeLayout(false);
            this.reservationTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchView)).EndInit();
            this.tabAdvView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllReservationsView)).EndInit();
            this.tabRoom.ResumeLayout(false);
            this.tabRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage reservationTab;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtYear;
        private ComboBox comboxDay;
        private ComboBox comboxMonth;
        private Label label2;
        private Label lablName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TabPage tabSearch;
        private TabPage tabAdvView;
        private TabPage tabRoom;
        private Button btn;
        private ComboBox comboSearch;
        private Button btnSubmit;
        private Button btnFinalizeBill;
        private CheckBox checkFoodSatus;
        private CheckBox checkSMS;
        private CheckBox checkCheckIn;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox combRoomN;
        private ComboBox combFloor;
        private ComboBox combRoomType;
        private ComboBox combQtGuest;
        private Label label6;
        private TextBox txtZipCode;
        private ComboBox comboxState;
        private TextBox txtCity;
        private TextBox txtApt;
        private TextBox txtStreet;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private ComboBox comboxGender;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnNew;
        private Button btnEdit;
        private Label lablNotFound;
        private Button btnSearch;
        private TextBox txtUniversalSearch;
        private DataGridView gridSearchView;
        private Button btnSaveChangeSearch;
        private DataGridView gridAllReservationsView;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private ListBox listboxReserved;
        private ListBox listboxOccubied;
    }
}