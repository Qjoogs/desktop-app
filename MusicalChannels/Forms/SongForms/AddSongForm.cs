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
using System.IO;
using MusicalChannels.Models.Data;

namespace MusicalChannels.Forms
{
    public partial class AddSongForm : Form
    {
        Panel mainPanel;
        public AddSongForm(Panel panel)
        {
            InitializeComponent();
            mainPanel = panel;
        }

        string filePath = null;
        string imgName = null;


        private void addInsertButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "files (*.jpg)|*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;
                    imgName = filePath.Substring(filePath.LastIndexOf('\\') + 1).ToString();
                    addPictureBox.Image = Image.FromFile(filePath);
                }
            }


        }

        private void addSaveButton_Click(object sender, EventArgs e)
        {
            Song song = new Song();

            song.Name = addTextBox.Text;
            song.ImageURL = filePath;
            song.Duration = addDurationTextBox.Text;
            song.ReleaseDate = monthCalendar1.SelectionRange.Start.Date;


            var currArtist = DataService.GetArtists().Where(x => x.Name == addArtistSongTextBox.Text).FirstOrDefault();
            var currChannel = DataService.GetChannels().Where(x => x.Name == addChannelSongTextBox.Text).FirstOrDefault();


            if (currArtist != null && currChannel != null)
            {
                Artist artist = new Artist();
                artist.Name = currArtist.Name;
                artist.Age = currArtist.Age;
                artist.Description = currArtist.Description;
                artist.ImageURL = currArtist.ImageURL;
                artist.Song = song;

                Channel channel = new Channel();
                channel.Name = currChannel.Name;
                channel.ChannelLogo = currChannel.ChannelLogo;
                channel.Song = song;

                
                song.Artists.Add(artist);
                song.Channels.Add(channel);


                string picsFile = SettingsReader.GetPicsURL() + @"\";

                File.Copy(filePath, picsFile + imgName);
                song.ImageURL = picsFile + imgName;


                DataService.AddSong(song);

                MessageBox.Show("The song is added");
                Redirect();

            }
            else if (currArtist == null)
            {
                MessageBox.Show("The artist doesn't exists");
            }
            else if (currChannel == null)
            {
                MessageBox.Show("The channel doesn't exists");
            }



        }

        private void AddSongForm_Load(object sender, EventArgs e)
        {

        }

        private void Redirect()
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            this.mainPanel.Controls.Clear();
            ShowSongsAdminForm f = new ShowSongsAdminForm(mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
    }
}
