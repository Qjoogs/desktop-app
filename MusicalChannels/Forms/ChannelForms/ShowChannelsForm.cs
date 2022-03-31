﻿using MusicalChannels.Forms.UserControls;
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
    public partial class ShowChannelsForm : Form
    {
        public ShowChannelsForm()
        {
            InitializeComponent();
        }
        ChannelsUserControl control;
        private void LoadChannels()
        {
            var findChannel = DataService.GetChannels().Where(x => x.SongId != null);
            var distinctChannel = new List<Channel>();

            using (DBContext context = new DBContext())
            {

                foreach (Channel channel in findChannel)
                {
                    if (!distinctChannel.Any(x => x.Name == channel.Name))
                    {
                        var currControl = new ChannelsUserControl();
                        currControl.ChannelName = channel.Name;
                        currControl.PictureBox = channel.ChannelLogo;
                        currControl.ControlClicked += new EventHandler(ClickedChannel);
                        currControl.Margin = new Padding(30, 10, 50, 30);
                        flowLayoutPanel1.Controls.Add(currControl);
                        distinctChannel.Add(channel);
                    }
                }
            }

        }

        private void LoadSongs()
        {
            var findChannel = DataService.GetChannels().Where(x => x.Name == control.ChannelName).Where(x => x.SongId != null);

            using (DBContext context = new DBContext())
            {
                foreach (var item in findChannel)
                {
                    Song song = DataService.GetSongs().Where(x => x.Id == item.SongId).FirstOrDefault();
                    var currControl = new ChannelsUserControl();
                    currControl.ChannelName = song.Name;
                    currControl.PictureBox = song.ImageURL;
                    currControl.ControlClicked += new EventHandler(ClickedSong);
                    currControl.Margin = new Padding(30, 10, 50, 30);
                    flowLayoutPanel1.Controls.Add(currControl);

                }
            }
        }

        private void ClickedChannel(object sender, EventArgs e)
        {
            control = (ChannelsUserControl)sender;
            flowLayoutPanel1.Controls.Clear();
            LoadSongs();
        }

        private void ClickedSong(object sender, EventArgs e)
        {
            var song = (ChannelsUserControl)sender;

            MessageBox.Show("Song: " + song.ChannelName);
        }


        private void ShowChannelsForm_Load(object sender, EventArgs e)
        {
            LoadChannels();
        }
    }
}
