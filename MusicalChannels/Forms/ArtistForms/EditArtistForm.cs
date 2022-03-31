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

        private void addSaveButton_Click(object sender, EventArgs e)
        {

            if (insertButtonClicked)
            {
                string picsFile = SettingsReader.GetPicsURL() + @"\";
                File.Copy(filePath, picsFile + imgName);
            }


            foreach (var item in DataService.GetArtists())
            {
                if (item.Name == currArtist.Name)
                {
                    item.Name = addArtistNameTextBox.Text;
                    DataService.UpdateArtist(item);
                }
            }

            MessageBox.Show("The artist is saved");

            Redirect();
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
