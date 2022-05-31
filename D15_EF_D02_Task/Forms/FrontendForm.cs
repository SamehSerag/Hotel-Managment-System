using D15_EF_D02_Task.Context;
using D15_EF_D02_Task.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

namespace D15_EF_D02_Task.Forms
{
    public partial class FrontendForm : Form
    {
        /// For Combobox Title
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
       
        public IDbConnection Connection { get; set; }
        public HotelContext context = new HotelContext();
        private string getval;

        public string Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string towelS, cleaningS, surpriseS;

        public int foodBill = -1;
        public string birthday = "";

        public string food_menu = "";
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public Int32 primartyID = 0;
        public Boolean taskFinder = false;
        public Boolean taskFinder2 = false;
        public Boolean editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private float finalizedTotalAmount = 0.0F;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;

        private int lunch = 0; private int breakfast = 0; private int dinner = 0;
        private string cleaning = "0"; private string towel = "0";
        private string surprise = "0";
        public FrontendForm()
        {
            InitializeComponent();
            Connection = new SqlConnection("Data Source=. ; Initial Catalog=HotelReservation;Integrated Security = true");

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frontend_Load(object sender, EventArgs e)
        {
            txtFirstName.PlaceholderText = "First Name";
            txtLastName.PlaceholderText = "Last Name";
            txtApt.PlaceholderText = "Apt";
            txtCity.PlaceholderText = "City";
            txtEmail.PlaceholderText = "Email";
            txtPhone.PlaceholderText = "Phone";
            txtStreet.PlaceholderText = "Street";
            txtUniversalSearch.PlaceholderText = "Search By ID";
            txtYear.PlaceholderText = "Year";
            txtZipCode.PlaceholderText = "Zip Code";
            comboxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxGender.SelectedIndex = 0;
            comboxState.SelectedIndex = 0;
            comboxDay.SelectedIndex = 0;
            comboxMonth.SelectedIndex = 0;

            //combQtGuest.Items.Insert(0, "dd");
            //combQtGuest.SelectedIndex = 0;
            SendMessage(this.combQtGuest.Handle, CB_SETCUEBANNER, 0, "# of guests");
            SendMessage(this.combRoomType.Handle, CB_SETCUEBANNER, 0, "Room Type");
            SendMessage(this.combRoomN.Handle, CB_SETCUEBANNER, 0, "Room Number ");
            SendMessage(this.combFloor.Handle, CB_SETCUEBANNER, 0, "Floor");


            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            comboSearch.Visible = false;
            gridSearchView.Visible = false;
            lablNotFound.Visible = false;

            context.Reservation.Load();
            var s = context.Reservation.Local.ToBindingList();
            gridAllReservationsView.DataSource = s;


            //listboxOccubied.DataSource = context.Reservation.Where(r => r.CheckIn == true).ToList();
            //listboxOccubied.DisplayMember = "room_number" + " " +"ID" +  " " + "room_type";

            //var result = context.Reservation.Where(r => r.CheckIn == true).ToList();
            var result = context.Reservation.Where(r => r.CheckIn == true);
            //var result = Connection.Query("Select* from Reservation where CheckIn = 'true'");
            foreach (var item in result)
            {
                listboxOccubied.Items.Add(item.RoomNumber.Trim() + "  "+ item.RoomType + "  " + item.Id 
                    + "  " + item.FirstName + " " + item.LastName + "  " + item.PhoneNumber
                    );
            }

            //var result2 = context.Reservation.Where(r => r.CheckIn == false).ToList();
            //var result2 = Connection.Query("Select* from Reservation where CheckIn = 'false'");
            var result2 = context.Reservation.Where(r => r.CheckIn == false);

            foreach (var item in result2)
            {
                listboxReserved.Items.Add(item.RoomNumber.Trim() + "  " + item.RoomType + "  " + item.Id
                    + "  " + item.FirstName + " " + item.LastName + "  " + item.PhoneNumber
                    + " " +item.ArrivalTime.Date + " " + item.LeavingTime.Date 
                    );
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combRoomType.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                combFloor.SelectedItem = "1";
            }
            else if (combRoomType.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                combFloor.SelectedItem = "2";
            }
            else if (combRoomType.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                combFloor.SelectedItem = "3";
            }
            else if (combRoomType.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                combFloor.SelectedItem = "4";
            }
            else if (combRoomType.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                combFloor.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            bool temp = int.TryParse(combQtGuest.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = combQtGuest.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }
        }

        private void reservationTab_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            birthday = (comboxMonth.SelectedItem) + "-" + (comboxDay.SelectedIndex + 1) + "-" + txtYear.Text;

            Reservation reservation
                = new Reservation(
                   txtFirstName.Text, txtFirstName.Text, birthday, 
                   comboxGender.SelectedIndex  == 0 ? "Male" : "Female" ,
                   txtPhone.Text, txtEmail.Text,
                   int.Parse(combQtGuest.SelectedItem?.ToString()??"1"), txtStreet.Text, txtApt.Text, txtCity.Text,
                   (string)comboxState.SelectedItem, txtZipCode.Text, combRoomType.Text, (string)combFloor.SelectedItem,
                   (string)combRoomN.SelectedItem, finalizedTotalAmount, paymentType, CardType, paymentCardNumber,
                   MM_YY_Of_Card, CVC_Of_Card, dateTimePicker1.Value,
                   dateTimePicker2.Value,
                   checkCheckIn.Checked, breakfast, lunch, dinner,
                   cleaning  == "1" ? true : false , towel == "1" ? true : false, surprise == "1" ? true : false, checkFoodSatus.Checked,
                   foodBill
                    );
            context.Reservation.Add(reservation);

            context.SaveChanges();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
        }

        private void comboxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((string)comboxState.SelectedItem);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            comboSearch.Visible = true;

            //var search = context.Reservation.Where(r => r.CheckIn == true)
            //    .Select(r => new { ID = r.Id, Name = r.FirstName + " " + r.LastName, Phone = r.PhoneNumber });

            var search = Connection.Query<Reservation>("select * from Reservation")?.AsList();
            foreach (var item in search)
            {
                Trace.WriteLine(item.Id);
                comboSearch.Items.Add($"{item.Id} | {item.FirstName} | {item.PhoneNumber} ");
            }
        }

        BindingSource BS = new BindingSource();
        TextBox tx = new TextBox();
        TextBox cardEx = new TextBox();
        string[] cardExArr;
        string[] txArr;
        Reservation selected = null;
        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BS = new BindingSource();
            //tx= new TextBox();
            //cardEx = new TextBox();

            this.Controls.Add(tx);
            tx.BackColor = Color.White;
            tx.ForeColor = Color.White;
            tx.BorderStyle = BorderStyle.None;
            //tx.GotFocus += (o, e) => Trace.WriteLine("Focused");
            //tx.Visible = false;
            this.Controls.Add(cardEx);
            cardEx.Visible = false;
            

            string[] selectedItem = comboSearch.SelectedItem.ToString().Split("|");

            selected = context.Reservation
                .Where(r => r.Id == int.Parse(selectedItem[0])).FirstOrDefault();

            BS.DataSource = selected;

            Trace.WriteLine(selected.ToString());

            txtFirstName.DataBindings.Clear();
            txtFirstName.DataBindings.Add("Text", BS, "firstname");

            txtLastName.DataBindings.Clear();
            txtLastName.DataBindings.Add("Text", BS, "lastname");
            
            tx.DataBindings.Clear();
            tx.DataBindings.Add("Text", BS, "birthday");
            txArr = tx.Text.Split('-');
            comboxMonth.SelectedItem = txArr[0];
            comboxDay.SelectedItem = txArr[1];
            txtYear.Text = txArr[2];
            tx.Visible = false;

            comboxGender.DataBindings.Clear();
            comboxGender.DataBindings.Add("Text", BS, "gender");


            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", BS, "phonenumber");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", BS, "email");

            txtStreet.DataBindings.Clear();
            txtStreet.DataBindings.Add("Text", BS, "streetAddress");


            txtApt.DataBindings.Clear();
            txtApt.DataBindings.Add("Text", BS, "aptSuite");

            txtCity.DataBindings.Clear();
            txtCity.DataBindings.Add("Text", BS, "city");

            comboxState.DataBindings.Clear();
            comboxState.DataBindings.Add("Text", BS, "state");


            txtZipCode.DataBindings.Clear();
            txtZipCode.DataBindings.Add("Text", BS, "zipcode");


            combQtGuest.DataBindings.Clear();
            combQtGuest.DataBindings.Add("Text", BS, "numberGuest");

            combRoomType.DataBindings.Clear();
            combRoomType.DataBindings.Add("Text", BS, "roomtype");

            combFloor.DataBindings.Clear();
            combFloor.DataBindings.Add("Text", BS, "roomfloor");

            combRoomN.DataBindings.Clear();
            combRoomN.DataBindings.Add("Text", BS, "roomnumber");

            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", BS, "arrivalTime");

            dateTimePicker2.DataBindings.Clear();
            dateTimePicker2.DataBindings.Add("Text", BS, "leavingTime");


            checkCheckIn.DataBindings.Clear();
            checkCheckIn.DataBindings.Add("checked", BS, "checkin");


            finalizePayment.txtFoodBill.DataBindings.Clear();
            finalizePayment.txtFoodBill.DataBindings.Add("text", BS, "foodBill");

            //Trace.WriteLine(BS["birthday"].Split('-')[0]);
            //comboxMonth.DataBindings.Add("Text", BS, "birthday".Split('-')[0]);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void comboxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tx.Text != "" )
            {
                txArr[0] = (string)comboxMonth.SelectedItem;
                tx.Visible = true;
                tx.Text = string.Join("-", txArr);
                tx.Focus();
                tx.Visible = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            //InitializeComponent();
            
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            comboSearch.Visible = false;

            //foreach (Control control in panel1.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        TextBox txtbox = (TextBox)control;
            //        txtbox.Text = string.Empty;
            //    }
            //    else if (control is CheckBox)
            //    {
            //        CheckBox chkbox = (CheckBox)control;
            //        chkbox.Checked = false;
            //    }
            //    else if (control is RadioButton)
            //    {
            //        RadioButton rdbtn = (RadioButton)control;
            //        rdbtn.Checked = false;
            //    }
            //    else if (control is DateTimePicker)
            //    {
            //        DateTimePicker dtp = (DateTimePicker)control;
            //        dtp.Value = DateTime.Now;
            //    }
            //}

            txtFirstName.DataBindings.Clear();
            txtFirstName.Text = "";

            txtLastName.DataBindings.Clear();
            txtLastName.Text = "";

            tx.DataBindings.Clear();
            tx.Text = "";

            comboxMonth.SelectedItem = null;
            comboxDay.SelectedItem = null;
            txtYear.Text = "";

            comboxGender.DataBindings.Clear();
            comboxGender.SelectedIndex = -1;


            txtPhone.DataBindings.Clear();
            txtPhone.Text = "";

            txtEmail.DataBindings.Clear();
            txtEmail.Text = "";

            txtStreet.DataBindings.Clear();
            txtStreet.Text = "";


            txtApt.DataBindings.Clear();
            txtApt.Text = "";

            txtCity.DataBindings.Clear();
            txtCity.Text = "";

            comboxState.DataBindings.Clear();
            comboxState.SelectedIndex = -1;


            txtZipCode.DataBindings.Clear();
            txtZipCode.Text = "";


            combQtGuest.DataBindings.Clear();
            combQtGuest.SelectedIndex = -1;

            combRoomType.DataBindings.Clear();
            combRoomType.SelectedIndex = -1;

            combFloor.DataBindings.Clear();
            combFloor.SelectedIndex = -1;

            combRoomN.DataBindings.Clear();
            combRoomN.SelectedIndex = -1;

            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.Value = DateTime.Now;

            dateTimePicker2.DataBindings.Clear();
            dateTimePicker2.Value = DateTime.Now;


            checkCheckIn.DataBindings.Clear();
            checkCheckIn.Checked = false;


            finalizePayment.txtFoodBill.DataBindings.Clear();
            finalizePayment.txtFoodBill.Text = "";



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtUniversalSearch.Text, out int temp))
            {
                var result = from r in context.Reservation
                             where r.Id == temp
                             select r;


                if (result != null /*result.Count != 0*/)
                {
                    gridSearchView.DataSource = result.ToList();
                    lablNotFound.Visible = false;
                    gridSearchView.Visible = true;
                }
                else
                {
                    gridSearchView.Visible = false;
                    lablNotFound.Visible = true;

                }
            }
            else
            {
                lablNotFound.Visible = true;
            }


        }

        private void tabSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChangeSearch_Click(object sender, EventArgs e)
        {
            gridSearchView.EndEdit();
            context.SaveChanges();
        }

        private void tabAdvView_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {



        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listboxOccubied_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            context.Reservation.Remove(selected);
            comboSearch.Items.Remove(comboSearch.SelectedItem);
            context.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodMenu foodMenu = new FoodMenu();
             
            if(selected != null)
            {
                foodMenu.txtBreakFast.DataBindings.Add("Text", BS, "breakfast");
                foodMenu.chkBreakFast.DataBindings.Add("checked", BS, "breakfast");
                
                foodMenu.txtLunch.DataBindings.Add("Text", BS, "lunch");
                foodMenu.chkLunch.DataBindings.Add("checked", BS, "lunch");

                foodMenu.txtDinner.DataBindings.Add("Text", BS, "dinner");
                foodMenu.chkDinner.DataBindings.Add("checked", BS, "dinner");

                foodMenu.chekCleaning.DataBindings.Add("checked", BS, "cleaning");
                foodMenu.chekSweetest.DataBindings.Add("checked", BS, "ssurprise");
                foodMenu.chekTowels.DataBindings.Add("checked", BS, "towel");



            }
            else if (taskFinder)
            {
                if (breakfast > 0)
                {
                    foodMenu.chkBreakFast.Checked = true;
                    foodMenu.txtBreakFast.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    foodMenu.chkLunch.Checked = true;

                    foodMenu.txtLunch.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    foodMenu.chkDinner.Checked = true;
                    foodMenu.txtDinner.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    foodMenu.chekCleaning.Checked = true;
                }
                if (towel == "1")
                {
                    foodMenu.chekTowels.Checked = true;
                }
                if (surprise == "1")
                {
                    foodMenu.chekSweetest.Checked = true;
                }
            }
            foodMenu.ShowDialog();

            breakfast = foodMenu.BreakfastQ;
            lunch = foodMenu.LunchQ;
            dinner = foodMenu.DinnerQ;

            cleaning = foodMenu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "1" : "0";
            towel = foodMenu.Towel.Replace(" ", string.Empty) == "Towels" ? "1" : "0";

            surprise = foodMenu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "1" : "0";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }

            taskFinder = true;
            //foodMenu.ShowDialog();

        }

        FinalizePayment finalizePayment = new FinalizePayment();
        private void btnfinalizePaymentl_Click(object sender, EventArgs e)
        {

            //if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
            //{
            //    foodSupplyCheckBox.Checked = true;
            //}
            btnUpdate.Enabled = true;

            //finalizePayment.totalAmountFromFrontend = totalAmount;
            //finalizePayment.foodBill = foodBill;

            if(selected != null)
            {
                finalizePayment.txtFoodBill.DataBindings.Clear();
                finalizePayment.txtFoodBill.DataBindings.Add("text", BS, "foodBill");
                //if (int.TryParse(finalizePayment.txtFoodBill.Text, out foodBill))
                //    finalizePayment.foodBill = foodBill;

                finalizePayment.txtTotal.DataBindings.Clear();
                finalizePayment.txtTotal.DataBindings.Add("text", BS, "totalBill");


                finalizePayment.combPayment.DataBindings.Clear();
                finalizePayment.combPayment.DataBindings.Add("text", BS, "paymentType");

                finalizePayment.txtPaymentNumber.DataBindings.Clear();
                finalizePayment.txtPaymentNumber.DataBindings.Add("text", BS, "cardNumber");


                finalizePayment.txtCVC.DataBindings.Clear();
                finalizePayment.txtCVC.DataBindings.Add("text", BS, "cardcvc");


                cardEx.DataBindings.Clear();
                cardEx.DataBindings.Add("text", BS, "cardExp");
                cardExArr = cardEx.Text.Split("/");
                finalizePayment.combMM.SelectedItem = cardExArr[0];
                finalizePayment.CombYY.SelectedItem = cardExArr[1];

                finalizePayment.combMM.SelectedIndexChanged += (o, e) =>
                {
                    cardEx.Visible = true;
                    cardExArr[0] = finalizePayment.combMM.SelectedItem.ToString();
                    cardEx.Text = String.Join("/", cardExArr);
                    tx.Focus();
                    cardEx.Visible = false;
                };

                finalizePayment.CombYY.SelectedIndexChanged += (o, e) =>
                {
                    cardEx.Visible = true;
                    cardExArr[1] = finalizePayment.combMM.SelectedItem.ToString();
                    cardEx.Text = String.Join("/", cardExArr);
                    tx.Focus();
                    cardEx.Visible = false;
                };

            }
            else if (taskFinder2)
            {
                finalizePayment.combPayment.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizePayment.txtPaymentNumber.Text = FCnumber;
                finalizePayment.combMM.SelectedItem = FcardExpOne;
                finalizePayment.CombYY.SelectedItem = FcardExpTwo;
                finalizePayment.txtCVC.Text = FCardCVC;
            }
            finalizePayment.totalAmountFromFrontend = totalAmount;
            finalizePayment.foodBill = foodBill;

            finalizePayment.ShowDialog();

            finalizedTotalAmount = (float) finalizePayment.FinalTotalFinalized;
            paymentType = finalizePayment.PaymentType;
            paymentCardNumber = finalizePayment.PaymentCardNumber;
            MM_YY_Of_Card = finalizePayment.MM_YY_Of_Card1;
            CVC_Of_Card = finalizePayment.CVC_Of_Card1;
            CardType = finalizePayment.CardType1;

            if (!editClicked)
            {
                btnSubmit.Visible = true;
            }


        }
    }
}
