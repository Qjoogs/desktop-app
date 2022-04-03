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
    public partial class ShowSongsForm : Form
    {
        public ShowSongsForm()
        {
            InitializeComponent();
        }

        private void ShowContentForm_Load(object sender, EventArgs e)
        {
            LoadSongs();
        }
        private void LoadSongs()
        {
            using (DBContext context = new DBContext())
            {

                foreach (Song song in context.Songs)
                {
                    var artist = DataService.GetArtists().Where(x => x.SongId == song.Id).FirstOrDefault();
                    if (artist != null)
                    {
                        var currControl = new ChannelsUserControl();
                        currControl.ChannelName = song.Name;
                        currControl.PictureBox = song.ImageURL;
                        currControl.ControlClicked += new EventHandler(ClickedSong);
                        currControl.Margin = new Padding(30, 10, 50, 30);
                        flowLayoutPanel1.Controls.Add(currControl);
                    }
                    else
                    {
                        DataService.RemoveSong(song);
                    }
                }
            }
        }
        private void ClickedSong(object sender, EventArgs e)
        {
            var song = (ChannelsUserControl)sender;

            MessageBox.Show("Song: " + song.ChannelName);
        }
    }
}
