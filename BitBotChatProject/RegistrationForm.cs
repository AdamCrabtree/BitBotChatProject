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
            if (tbEmail.Text != null && tbPassword.Text != null && tbPasswordRepeat != null && tbUsername != null)
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
