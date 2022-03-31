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

namespace MusicalChannels.Forms.ArtistForms
{
    public partial class AddArtistForm : Form
    {
        Panel mainPanel;
        public AddArtistForm(Panel panel)
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
            Artist artist = new Artist();

            artist.Name = addArtistNameTextBox.Text;
            artist.ImageURL = filePath;

            var (isTrue, error) = DataService.AddArtist(artist);

            if (isTrue)
            {
                string picsFile = SettingsReader.GetPicsURL() + @"\";

                File.Copy(filePath, picsFile + imgName);
                artist.ImageURL = picsFile + imgName;
            }
            else
            {
                MessageBox.Show(error);
            }


            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            this.mainPanel.Controls.Clear();
            ShowArtistsAdminForm f = new ShowArtistsAdminForm(mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

            MessageBox.Show("The artist is added");
        }
    }
}
