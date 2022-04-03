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
    public partial class EditArtistForm : Form
    {
        Artist currArtist;
        Panel mainPanel;
        public EditArtistForm(Artist artist, Panel panel)
        {
            InitializeComponent();
            currArtist = artist;
            mainPanel = panel;
        }

        string filePath = null;
        string imgName = null;

        private void EditArtistForm_Load(object sender, EventArgs e)
        {
            addArtistNameTextBox.Text = currArtist.Name;
            addRichTextBox.Text = currArtist.Description;
            addAgeTextBox.Text = currArtist.Age.ToString();
            try
            {
                addPictureBox.Image = Image.FromFile(currArtist.ImageURL);
                filePath = currArtist.ImageURL;
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
        string newFileName = null;
        private void addSaveButton_Click(object sender, EventArgs e)
        {
            int age = 0;
            if (!int.TryParse(addAgeTextBox.Text, out age))
            {
                MessageBox.Show("Invalid Age");
            }
            else if (age < 0 && age > 99)
            {
                MessageBox.Show("Invalid Age");
            }
            else if (string.IsNullOrWhiteSpace(addArtistNameTextBox.Text))
            {
                MessageBox.Show("Invalid Name");
            }
            else
            {
                if (insertButtonClicked)
                {
                    string picsFile = SettingsReader.GetPicsURL() + @"\";
                    newFileName = picsFile + (int.Parse(new DirectoryInfo(picsFile).GetFiles("*.jpg").Count().ToString()) + 1).ToString() + ".jpg";

                    File.Copy(filePath, newFileName);
                }

                
                foreach (var item in DataService.GetArtists())
                {
                    if (item.Name == currArtist.Name)
                    {
                       
                        item.Name = addArtistNameTextBox.Text;
                        item.Description = addRichTextBox.Text;
                        item.Age = int.Parse(addAgeTextBox.Text);
                        //item.Song = 
                        if (insertButtonClicked)
                        {
                            item.ImageURL = newFileName;
                        }
                        else
                        {
                            item.ImageURL = filePath;
                        }
                        DataService.UpdateArtist(item);
                    }
                }

                MessageBox.Show("The artist is saved");

                Redirect();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataService.RemoveArtist(currArtist);
            MessageBox.Show("The artist is deleted");

            Redirect();
        }

        private void Redirect()
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            this.mainPanel.Controls.Clear();
            ShowChannelsAdminForm f = new ShowChannelsAdminForm(mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

    }
}
