using MusicalChannels.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalChannels.Forms.UserControls
{
    public partial class UsersAdminUserControl : UserControl
    {

        public UsersAdminUserControl()
        {
            InitializeComponent();
        }

        public event EventHandler ControlClicked;

        public string Username
        {
            get { return usernameLabel.Text; }
            set { usernameLabel.Text = value; }
        }
        public string Email
        {
            get { return emailLabel.Text; }
            set { emailLabel.Text = value; }
        }
        public bool CheckBoxChecked
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }
        bool isLoaded = false;
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                var currUser = UserServices.GetUsers().FirstOrDefault(x => x.Username == this.Username);
                if (checkBox.Checked)
                {
                    if (!UserServices.IsAdmin(currUser))
                    {
                        currUser.IsAdmin = true;
                        UserServices.UpdateUser(currUser);
                    }
                    MessageBox.Show("the user is updated");
                }
                else
                {
                    if (UserServices.IsAdmin(currUser))
                    {
                        currUser.IsAdmin = false;
                        UserServices.UpdateUser(currUser);
                    }
                    MessageBox.Show("the user is updated");
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            ControlClicked?.Invoke(this, e);
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Control_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            isLoaded = true;

        }
    }
}
