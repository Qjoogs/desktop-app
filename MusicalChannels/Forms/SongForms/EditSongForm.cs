using MusicalChannels.Models.Data;
using MusicalChannels.Models.Services;
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

namespace MusicalChannels.Forms
{
    public partial class EditSongForm : Form
    {
        Song currSong;
        Panel mainPanel;
        public EditSongForm(Song song, Panel panel)
        {
            InitializeComponent();

            currSong = song;
            mainPanel = panel;
        }

        string filePath = null;
        string imgName = null;

        private void EditSongForm_Load(object sender, EventArgs e)
        {
            var artist = DataService.GetArtists().Where(x => x.SongId == currSong.Id).FirstOrDefault();
            addTextBox.Text = currSong.Name;
            addArtistSongTextBox.Text = artist.Name;
            monthCalendar1.SetDate(currSong.ReleaseDate);
            addDurationTextBox.Text = currSong.Duration.ToString();
            try
            {
                addPictureBox.Image = Image.FromFile(currSong.ImageURL);
                filePath = currSong.ImageURL;
            }
            catch
            {
                MessageBox.Show("The image is not found");
            }
        }
        bool insertButtonClicked = false;
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
                    insertButtonClicked = true;
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



            if (currArtist != null)
            {

                if (insertButtonClicked)
                {
                    string picsFile = SettingsReader.GetPicsURL() + @"\";
                    File.Copy(filePath, picsFile + imgName);
                }


                Artist artist = new Artist();
                artist.Name = currArtist.Name;
                artist.Age = currArtist.Age;
                artist.Description = currArtist.Description;
                artist.ImageURL = currArtist.ImageURL;
                artist.Song = song;


              

                artist.Song = song;

                
                DataService.RemoveSong(currSong);
                DataService.AddArtistSong(artist);
                DataService.AddSong(song);
                MessageBox.Show("The song is saved");

                Redirect();
            }
            else
            {
                MessageBox.Show("The artist doesn't exists");
            }

           
        }

        private void addDeleteButton_Click(object sender, EventArgs e)
        {
            DataService.RemoveSong(currSong);
            MessageBox.Show("The song is deleted");

            Redirect();
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
