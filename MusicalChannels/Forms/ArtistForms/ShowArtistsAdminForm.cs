using MusicalChannels.Forms.ChannelForms;
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
    public partial class ShowArtistsAdminForm : Form
    {
        Panel mainPanel;
        public ShowArtistsAdminForm(Panel panel)
        {
            InitializeComponent();
            mainPanel = panel;
        }

        private void ShowArtistsAdminForm_Load(object sender, EventArgs e)
        {
            LoadArtists();
        }

        private void LoadArtists()
        {
            var findChannel = DataService.GetArtists().Where(x => x.SongId != null);
            var distinctArtist = new List<Artist>();

            using (DBContext context = new DBContext())
            {
                foreach (Artist artist in findChannel)
                {
                    if (!distinctArtist.Any(x => x.Name == artist.Name))
                    {
                        var currControl = new ChannelsUserControl();
                        currControl.ChannelName = artist.Name;
                        currControl.PictureBox = artist.ImageURL;
                        currControl.ControlClicked += new EventHandler(ClickedSong);
                        currControl.Margin = new Padding(30, 10, 50, 30);
                        flowLayoutPanel1.Controls.Add(currControl);
                        distinctArtist.Add(artist);
                    }
                }
            }
        }

        private void ClickedSong(object sender, EventArgs e)
        {
            var channel = (ChannelsUserControl)sender;

            var findChannel = DataService.GetArtists().Where(x => x.Name == channel.ChannelName).FirstOrDefault();


            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }

            this.mainPanel.Controls.Clear();
            EditArtistForm f = new EditArtistForm(findChannel, mainPanel);
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
            AddArtistForm f = new AddArtistForm(mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
    }
}
