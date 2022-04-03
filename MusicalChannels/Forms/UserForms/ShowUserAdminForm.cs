using MusicalChannels.Forms.UserControls;
using MusicalChannels.Models.Data;
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

namespace MusicalChannels.Forms.UserForms
{
    public partial class ShowUserAdminForm : Form
    {
        Panel mainPanel;
        public ShowUserAdminForm(Panel panel)
        {
            InitializeComponent();
            mainPanel = panel;
        }

        private void ShowUserAdminForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (DBContext context = new DBContext())
            {

                foreach (User user in context.Users)
                {
                    var currControl = new UsersAdminUserControl();
                    currControl.Username = user.Username;
                    currControl.Email = user.Email;
                    currControl.CheckBoxChecked = UserServices.IsAdmin(user) ? true : false;
                    currControl.ControlClicked += new EventHandler(ClickedSong);
                    currControl.Margin = new Padding(90, 10, 50, 30);
                    flowLayoutPanel1.Controls.Add(currControl);
                }
            }
        }

        private void ClickedSong(object sender, EventArgs e)
        {
            //var song = (SongsAdminUserControl)sender;


            //if (mainPanel.Controls.Count > 0)
            //{
            //    mainPanel.Controls.RemoveAt(0);
            //}

            //this.mainPanel.Controls.Clear();
            //EditSongForm f = new EditSongForm(findSong, mainPanel);
            //f.TopLevel = false;
            //f.Dock = DockStyle.Fill;
            //this.mainPanel.Controls.Add(f);
            //this.mainPanel.Tag = f;
            //f.Show();

        }
    }
}
