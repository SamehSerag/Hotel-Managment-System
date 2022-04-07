using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D15_EF_D02_Task.Forms
{
    public partial class FoodMenu : Form
    {
        private int lunchQ = 0;

        public int LunchQ
        {
            get { return lunchQ; }
            set { lunchQ = value; }
        }
        private int breakfastQ = 0;

        public int BreakfastQ
        {
            get { return breakfastQ; }
            set { breakfastQ = value; }
        }
        private int dinnerQ = 0;

        public int DinnerQ
        {
            get { return dinnerQ; }
            set { dinnerQ = value; }
        }

        private string cleaning = "";

        public string Cleaning
        {
            get { return cleaning; }
            set { cleaning = value; }
        }
        private string towel = "";

        public string Towel
        {
            get { return towel; }
            set { towel = value; }
        }

        private string surprise = "";

        public string Surprise
        {
            get { return surprise; }
            set { surprise = value; }
        }

        public FoodMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFoodMenuFrmNext_Click(object sender, EventArgs e)
        {
            if (chkBreakFast.Checked)
            {
                BreakfastQ = Convert.ToInt32(txtBreakFast.Text);
            }
            if (chkLunch.Checked)
            {
                LunchQ = Convert.ToInt32(txtLunch.Text);
            }
            if (chkDinner.Checked)
            {
                DinnerQ = Convert.ToInt32(txtDinner.Text);
            }
            if (chekCleaning.Checked)
            {
                Cleaning = chekCleaning.Text;
            }
            if (chekTowels.Checked)
            {
                Towel = chekTowels.Text;
            }
            if (chekSweetest.Checked)
            {
                Surprise = chekSweetest.Text;
            }

            this.Hide();
        }

        private void chkBreakFast_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBreakFast.Checked)
                txtBreakFast.Enabled = true;
            else
                txtBreakFast.Enabled = false;
        }

        private void chkLunch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLunch.Checked)
                txtLunch.Enabled = true;
            else
                txtLunch.Enabled = false;
        }

        private void chekDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDinner.Checked)
                txtDinner.Enabled = true;
            else
                txtDinner.Enabled = false;
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            if(!chkBreakFast.Checked)
                txtBreakFast.Enabled = false;
            if(!chkLunch.Checked)
                txtLunch.Enabled = false;
            if(!chkDinner.Checked)
                txtDinner.Enabled = false;
        }
    }
}
