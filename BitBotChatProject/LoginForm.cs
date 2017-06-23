using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitBotChatProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(tbPassword.Text) && string.IsNullOrWhiteSpace(tbUsername.Text)))
            {
                User currentUser = RegistrationAndLogin.PublicLoginUser(tbUsername.Text, tbPassword.Text);
                if (currentUser != null)
                {
                    MainForm mainForm = new MainForm(currentUser);
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    lLoginStatus.Text = "Login failed. Could not find user.";
                }
            }

        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();
            this.Hide();
            registerForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
