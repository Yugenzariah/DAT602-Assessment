using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT602_Assessment.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            PlayerDAO dao = new PlayerDAO();
            bool success = dao.Login(username, password);

            if (success)
            {
                MessageBox.Show("Login Successful!");
                GameForm gameForm = new GameForm();
                gameForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed. Try again.");
            }
        }
    }
}