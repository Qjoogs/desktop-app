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

namespace MusicalChannels.Forms.ArtistForms
{
    public partial class ShowArtistsForm : Form
    {
        public ShowArtistsForm()
        {
            InitializeComponent();
        }


        ChannelsUserControl control;
        private void LoadArtists()
        {
            var findArtists = DataService.GetArtists().Where(x => x.SongId != null);
            var distinctArtist = new List<Artist>();

            using (DBContext context = new DBContext())
            {

                foreach (Artist artist in findArtists)
                {
                    if (!distinctArtist.Any(x => x.Name == artist.Name))
                    {
                        var currControl = new ChannelsUserControl();
                        currControl.ChannelName = artist.Name;
                        currControl.PictureBox = artist.ImageURL;
                        currControl.ControlClicked += new EventHandler(ClickedChannel);
                        currControl.Margin = new Padding(30, 10, 50, 30);
                        flowLayoutPanel1.Controls.Add(currControl);
                        distinctArtist.Add(artist);
                    }
                }
            }

        }

        private void LoadSongs()
        {
            var findChannel = DataService.GetArtists().Where(x => x.Name == control.ChannelName).Where(x => x.SongId != null);

            using (DBContext context = new DBContext())
            {
                foreach (var item in findChannel)
                {
                    Song song = DataService.GetSongs().Where(x => x.Id == item.SongId).FirstOrDefault();
                    var currControl = new ChannelsUserControl();
                    currControl.ChannelName = song.Name;
                    currControl.PictureBox = song.ImageURL;
                    currControl.ControlClicked += new EventHandler(ClickedSong);
                    currControl.Margin = new Padding(30, 10, 50, 30);
                    flowLayoutPanel1.Controls.Add(currControl);

                }
            }
        }

        private void ClickedChannel(object sender, EventArgs e)
        {
            control = (ChannelsUserControl)sender;
            flowLayoutPanel1.Controls.Clear();
            LoadSongs();
        }

        private void ClickedSong(object sender, EventArgs e)
        {
            var song = (ChannelsUserControl)sender;

            MessageBox.Show("Song: " + song.ChannelName);
        }

        private void ShowArtistsForm_Load(object sender, EventArgs e)
        {
            LoadArtists();
        }
    }
}
