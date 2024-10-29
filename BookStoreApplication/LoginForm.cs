using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication
{
    public partial class LoginForm : Form
    {
        private BookStoreEntities dbContext;
        public LoginForm()
        {
            InitializeComponent();
            dbContext = new BookStoreEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var user = dbContext.Users
                .FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

            if (user != null)
            {
                //MessageBox.Show("Login successful!");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
    }
}
