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

namespace MusicalChannels.Forms
{
    public partial class ShowSongsAdminForm : Form
    {
       
        Panel mainPanel;
        public ShowSongsAdminForm(Panel panel)
        {
            InitializeComponent();
           this.mainPanel = panel;
        }


        private void ShowSongsAdminForm_Load(object sender, EventArgs e)
        {
            LoadSongs();
        }

        private void LoadSongs()
        {
            using (DBContext context = new DBContext())
            {

                foreach (Song song in context.Songs)
                {
                    var currControl = new SongsAdminUserControl();
                    currControl.SongName = song.Name;
                    currControl.PictureBox = song.ImageURL;
                    currControl.ReleaseDate = song.ReleaseDate.ToString("dd-MM-yyyy");
                    currControl.Duration = song.Duration;
                    currControl.SongArtist = DataService.GetArtists().Where(x => x.SongId == song.Id).FirstOrDefault().Name;
                    currControl.ControlClicked += new EventHandler(ClickedSong);
                    currControl.Margin = new Padding(90, 10, 50, 30);
                    flowLayoutPanel1.Controls.Add(currControl);
                }
            }
        }
        private void ClickedSong(object sender, EventArgs e)
        {
            var song = (SongsAdminUserControl)sender;

            var findSong = DataService.GetSongs().Where(x => x.Name == song.SongName).FirstOrDefault();


            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }

            this.mainPanel.Controls.Clear();
            EditSongForm f = new EditSongForm(findSong, mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }

            this.mainPanel.Controls.Clear();
            AddSongForm f = new AddSongForm(mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
    }
}
