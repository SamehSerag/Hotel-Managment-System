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
    public partial class FinalizePayment : Form
    {
        public int totalAmountFromFrontend = 0;
        public int foodBill = 0;
        private double finalTotalFinalized = 0.0;
        private string paymentType;


        public double FinalTotalFinalized
        {
            get { return finalTotalFinalized; }
            set { finalTotalFinalized = value; }
        }

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        private string paymentCardNumber;

        public string PaymentCardNumber
        {
            get { return paymentCardNumber; }
            set { paymentCardNumber = value; }
        }
        private string MM_YY_Of_Card;

        public string MM_YY_Of_Card1
        {
            get { return MM_YY_Of_Card; }
            set { MM_YY_Of_Card = value; }
        }
        private string CVC_Of_Card;

        public string CVC_Of_Card1
        {
            get { return CVC_Of_Card; }
            set { CVC_Of_Card = value; }
        }
        private string CardType;

        public string CardType1
        {
            get { return CardType; }
            set { CardType = value; }
        }
        public FinalizePayment()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FinalizePayment_Load(object sender, EventArgs e)
        {

            //double totalWithTax = Convert.ToDouble(totalAmountFromFrontend) * 0.07;
            //double FinalTotal = Convert.ToDouble(totalAmountFromFrontend) + totalWithTax + foodBill;
            //txtCurrentBill.Text = "$" + Convert.ToString(totalAmountFromFrontend) + " USD";

            //if (int.TryParse(txtFoodBill.Text, out int temp))
            //{
            //    if(temp >  foodBill)
            //        foodBill = temp;
            //}

            //txtFoodBill.Text =  Convert.ToString(foodBill) ;
            //txtFoodBill.Focus();
            //txtTax.Text = "$" + Convert.ToString(totalWithTax) + " USD";
            //txtTotal.Text =  Convert.ToString(FinalTotal);
            //txtTotal.Focus();




            this.Shown += (o, e) =>
            {
                double totalWithTax = Convert.ToDouble(totalAmountFromFrontend) * 0.07;
                txtCurrentBill.Text = "$" + Convert.ToString(totalAmountFromFrontend) + " USD";

                Trace.WriteLine("Shown");
                if (foodBill < 0)
                    foodBill = int.Parse(txtFoodBill.Text);

                double FinalTotal = Convert.ToDouble(totalAmountFromFrontend) + totalWithTax + foodBill;

                txtFoodBill.Text = Convert.ToString(foodBill);
                txtFoodBill.Focus();
                txtTax.Text = "$" + Convert.ToString(totalWithTax) + " USD";
                txtTotal.Text = Convert.ToString(FinalTotal);
                txtTotal.Focus();

                FinalTotalFinalized = FinalTotal;

            };
        }

        private void btnFinalizeNext_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentType = combPayment.Text;
                PaymentCardNumber = txtPaymentNumber.Text;
                MM_YY_Of_Card1 = combMM.SelectedItem.ToString() + "/" + CombYY.SelectedItem.ToString();
                CVC_Of_Card1 = txtCVC.Text;
                CardType1 = lablCardType.Text;

                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error Closing the window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combMM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
