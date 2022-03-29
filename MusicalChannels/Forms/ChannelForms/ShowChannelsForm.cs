﻿using MusicalChannels.Forms.UserControls;
using MusicalChannels.Models.Data;
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

        private void LoadChannels()
        {
         

            using (DBContext context = new DBContext())
            {

                foreach (Channel channel in context.Channels)
                {
                    var currControl = new ChannelsUserControl();
                    currControl.ChannelName = channel.Name;
                    currControl.PictureBox = channel.ChannelLogo;
                    currControl.ControlClicked += new EventHandler(ClickedChannel);
                    currControl.Margin = new Padding(30, 10, 50, 30);
                    flowLayoutPanel1.Controls.Add(currControl);
                }
            }

        }



        private void ClickedChannel(object sender, EventArgs e)
        {

        }

        private void ShowChannelsForm_Load(object sender, EventArgs e)
        {
            LoadChannels();
        }
    }
}