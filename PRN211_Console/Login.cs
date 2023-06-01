using Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace PRN211_Console
{
    public partial class Login : Form
    {
        UserService _user = new UserService();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool check = Validation.checkLogin(username, password);

            if (check)
            {
                var users = _user.GetAll();
                var user = users.FirstOrDefault(u => u.UserId == username
                && u.Password == password);

                if (user != null && user.UserRole == 1)
                {
                    this.Hide();
                    Form frBankAccount = new BankAccountManagement();
                    frBankAccount.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You are not allowed to access this function", "Warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please input", this.Text);
            }

            btnLogin.Enabled = true;
        }
    }
}
