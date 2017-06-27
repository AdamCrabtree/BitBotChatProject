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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbEmail.Text) && !String.IsNullOrWhiteSpace(tbPassword.Text) && !String.IsNullOrWhiteSpace(tbPasswordRepeat.Text) && !String.IsNullOrWhiteSpace(tbUsername.Text))
            {
                if (tbPassword.Text == tbPasswordRepeat.Text)
                {
                    int result = RegistrationAndLogin.PublicRegisterUser(tbUsername.Text, tbPassword.Text, tbEmail.Text);
                    if (result == 1)
                    {
                        LoginForm loginForm = new LoginForm();
                        this.Close();
                        loginForm.Show();
                    }
                    else if (result == 0)
                    {
                        lRegistrationStatus.Text = "Username already exists.";
                    }
                }
                else
                {
                    lRegistrationStatus.Text = "Please make sure username and password are the same";
                }
            }
        }
    }
}
