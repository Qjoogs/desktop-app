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
            int age = 0;
            if (!int.TryParse(addAgeTextBox.Text, out age))
            {
                MessageBox.Show("Invalid Age");
            }
            else if(age < 0 && age > 99)
            {
                MessageBox.Show("Invalid Age");
            }
            else if(string.IsNullOrWhiteSpace(addArtistNameTextBox.Text))
            {
                MessageBox.Show("Invalid Name");
            }
            else
            {
                Artist artist = new Artist();

                artist.Name = addArtistNameTextBox.Text;
                artist.ImageURL = filePath;
                artist.Age = age;
                artist.Description = addAgeTextBox.Text;
                var (isTrue, error) = DataService.AddArtist(artist);

                if (isTrue)
                {
                    string picsFile = SettingsReader.GetPicsURL() + @"\";
                    string newFileName = picsFile + (int.Parse(new DirectoryInfo(picsFile).GetFiles("*.jpg").Count().ToString()) + 1).ToString() + ".jpg";

                    File.Copy(filePath, newFileName);
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
}
