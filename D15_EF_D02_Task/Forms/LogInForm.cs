using D15_EF_D02_Task.Context;
using D15_EF_D02_Task.Entities;
using D15_EF_D02_Task.Forms;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace D15_EF_D02_Task
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        HotelContext Context = new HotelContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            Context.Database.Migrate();
            //Context.LogInFrontEnd.Add(new LogInFrontEnd() { UserName = "s", Password = "s" });
            //Context.LogInKitchen.Add(new LogInKitchen() { UserName = "k", Password = "k" });
            string userName = "s";
            string password = "s";
            Trace.WriteLine(
                (Context.LogInFrontEnd.Where(u => u.UserName.Equals(userName) && u.Password == password).FirstOrDefault() != null)
            );
            Context.SaveChanges();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (
                    Context.LogInFrontEnd.Where(u => u.UserName.Equals(txtUserName.Text)
                    && u.Password.Equals(txtPassword.Text)).FirstOrDefault() != null
                )
            {
                FrontendForm frontendForm = new FrontendForm();
                this.Hide();
                frontendForm.ShowDialog();
                this.Show();
            }
            else if (
                    Context.LogInKitchen.Where(u => u.UserName.Equals(txtUserName.Text)
                    && u.Password.Equals(txtPassword.Text)).FirstOrDefault() != null
                )
            {

            }
            else
            {
                MessageBox.Show("Wrong User Name or Pass", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}