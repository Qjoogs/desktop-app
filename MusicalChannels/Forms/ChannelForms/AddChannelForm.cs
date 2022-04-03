﻿using MusicalChannels.Models.Data;
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
    public partial class AddChannelForm : Form
    {
        Panel mainPanel;
        public AddChannelForm(Panel panel)
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
            string picsFile = SettingsReader.GetPicsURL() + @"\";
            string newFileName = picsFile + (int.Parse(new DirectoryInfo(picsFile).GetFiles("*.jpg").Count().ToString()) + 1).ToString() + ".jpg";

            Channel channel = new Channel();
            channel.Name = addChannelNameTextBox.Text;
            channel.ChannelLogo = newFileName;

           
            var (isTrue, error) = DataService.AddChannel(channel);

            if (isTrue)
            {
                File.Copy(filePath, newFileName);
                channel.ChannelLogo = newFileName;
                MessageBox.Show("The channel is added");
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
            ShowChannelsAdminForm f = new ShowChannelsAdminForm(mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

            

        }

       
    }
}
