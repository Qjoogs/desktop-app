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

namespace MusicalChannels.Forms.ChannelForms
{
    public partial class EditChannelForm : Form
    {
        Channel currChannel;
        Panel mainPanel;
        public EditChannelForm(Channel channel, Panel panel)
        {
            InitializeComponent();
            currChannel = channel;
            mainPanel = panel;
        }

        string filePath = null;
        string imgName = null;
        private void EditChannelForm_Load(object sender, EventArgs e)
        {
            addChannelNameTextBox.Text = currChannel.Name;
            try
            {
                addPictureBox.Image = Image.FromFile(currChannel.ChannelLogo);
                filePath = currChannel.ChannelLogo;
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
        string newFileName=null;
        private void addSaveButton_Click(object sender, EventArgs e)
        {
            if (insertButtonClicked)
            {
                string picsFile = SettingsReader.GetPicsURL() + @"\";
                newFileName = picsFile + (int.Parse(new DirectoryInfo(picsFile).GetFiles("*.jpg").Count().ToString()) + 1).ToString() + ".jpg";

                File.Copy(filePath, newFileName);
            }


            foreach (var item in DataService.GetChannels())
            {
                if (item.Name == currChannel.Name)
                {
                    item.Name = addChannelNameTextBox.Text;
                    if (insertButtonClicked)
                    {
                        item.ChannelLogo = newFileName;
                    }
                    else
                    {
                        item.ChannelLogo = filePath;
                    }
                    DataService.UpdateChannel(item);
                }
            }

            MessageBox.Show("The channel is saved");

            Redirect();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataService.RemoveChannel(currChannel);
            MessageBox.Show("The channel is deleted");

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
