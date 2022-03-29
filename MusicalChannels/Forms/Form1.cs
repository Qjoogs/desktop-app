using MusicalChannels.Models.Data;
using MusicalChannels.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MusicalChannels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registerPanel.Visible = true;
            loginPanel.Visible = false;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBoxReg.UseSystemPasswordChar = true;
            checkBox1.Checked = true;
            passCheckBox.Checked = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!new Regex(@"^[a-zA-Z0-9]{3,15}$").IsMatch(usernameTextBox.Text))
            {
                MessageBox.Show("Wrong username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!new Regex(@"^[a-zA-Z0-9,.?!@#$%^&*()-=]{6,36}$").IsMatch(passwordTextBox.Text))
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UserServices.Login(new User
                {
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text
                }))
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(new User
                    {
                        Username = usernameTextBox.Text
                    });
                    mainForm.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("oburkal si accounta we");
                }
            }
        }

        private void loginButtonReg_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void registerButtonLogin_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = true;
            loginPanel.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!new Regex(@"^[a-zA-Z0-9]{3,15}$").IsMatch(usernametextBoxReg.Text))
            {
                MessageBox.Show("Wrong username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").IsMatch(emailTextBoxReg.Text))
            {
                MessageBox.Show("Wrong email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!new Regex(@"^[a-zA-Z0-9,.?!@#$%^&*()-=]{6,36}$").IsMatch(passwordTextBoxReg.Text))
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var (isTrue, error) = UserServices.Register(new User
                {
                    Username = usernametextBoxReg.Text,
                    Email = emailTextBoxReg.Text,
                    Password = passwordTextBoxReg.Text
                });

                if (isTrue)
                {
                    registerPanel.Visible = false;
                    loginPanel.Visible = true;
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void passCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheckBox.Checked)
            {
                passwordTextBoxReg.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTextBoxReg.UseSystemPasswordChar = false;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
