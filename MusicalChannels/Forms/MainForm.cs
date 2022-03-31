using MusicalChannels.Forms;
using MusicalChannels.Forms.ArtistForms;
using MusicalChannels.Forms.UserControls;
using MusicalChannels.Models.Data;
using MusicalChannels.Models.Services;
using MusicalChannels.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalChannels
{
    public partial class MainForm : Form
    {
        private User user;
        //1 - left | 2 - right
        private int side;
        public MainForm(User user)
        {
            InitializeComponent();
            // mainPanel.Hide();


            HideButtons();
            LoadForms(new ShowSongsForm());

            this.user = user;
            this.usernameLabel.Text = user.Username;
            
            side = 1;
        }

        private void changeSide_Click(object sender, EventArgs e)
        {
            if (side == 1)
            {
                sidePanel.Dock = DockStyle.Right;
                changeSide.BackgroundImage = Resources.leftArrow;
                side++;
            }
            else if (side == 2)
            {
                sidePanel.Dock = DockStyle.Left;
                changeSide.BackgroundImage = Resources.rightArrow;
                side--;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (UserServices.IsAdmin(user))
            {
                ShowButtons();
            }
        }
        private void HideButtons()
        {
            usersBTN.Hide();
            channeleditBTN.Hide();
            songsEditBTN.Hide();
            artistsEditBTN.Hide();
        }
        private void ShowButtons()
        {
            usersBTN.Show();
            channeleditBTN.Show();
            songsEditBTN.Show();
            artistsEditBTN.Show();
        }
        public void LoadForms(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            this.mainPanel.Controls.Clear();
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }



        private void songsEditBTN_Click(object sender, EventArgs e)
        {
            //LoadForms(new AddSongForm());
            LoadForms(new ShowSongsAdminForm(mainPanel));
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            LoadForms(new ShowSongsForm());
        }

        private void channelsBTN_Click(object sender, EventArgs e)
        {
            LoadForms(new ShowChannelsForm());
        }

        private void channeleditBTN_Click(object sender, EventArgs e)
        {
            LoadForms(new ShowChannelsAdminForm(mainPanel));
        }

        private void artistsBTN_Click(object sender, EventArgs e)
        {
            LoadForms(new ShowArtistsForm());
        }

        private void artistsEditBTN_Click(object sender, EventArgs e)
        {
            LoadForms(new ShowArtistsAdminForm(mainPanel));
        }
























































        //private void LoadDataAddSongs()
        //{
        //    foreach (Song song in DataService.GetSongs())
        //    {
        //        channelSongsListBox.Items.Add(song.Name + " - " + DataService.GetArtists().First(x => x.SongId == song.Id).Name);
        //    }
        //}

        //private void channeleditBTN_Click(object sender, EventArgs e)
        //{
        //    LoadDataAddSongs();
        //    channelCreatePanel.Show();
        //}






    }
}
