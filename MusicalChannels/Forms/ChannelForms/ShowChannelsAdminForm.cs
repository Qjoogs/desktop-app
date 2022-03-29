using MusicalChannels.Forms.ChannelForms;
using MusicalChannels.Forms.UserControls;
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
    public partial class ShowChannelsAdminForm : Form
    {
        Panel mainPanel;
        public ShowChannelsAdminForm(Panel panel)
        {
            InitializeComponent();
            mainPanel = panel;
        }

        private void ShowChannelsAdminForm_Load(object sender, EventArgs e)
        {
            LoadChannels();
        }

        private void LoadChannels()
        {
            using(DBContext context = new DBContext())
            {
                foreach (Channel channel in context.Channels)
                {
                    var currControl = new ChannelsUserControl();
                    currControl.ChannelName = channel.Name;
                    currControl.PictureBox = channel.ChannelLogo;
                    currControl.ControlClicked += new EventHandler(ClickedSong);
                    currControl.Margin = new Padding(30, 10, 50, 30);
                    flowLayoutPanel1.Controls.Add(currControl);
                }
            }
        }

        private void ClickedSong(object sender, EventArgs e)
        {
            var channel = (ChannelsUserControl)sender;

            var findChannel = DataService.GetChannels().Where(x => x.Name == channel.ChannelName).FirstOrDefault();


            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }

            this.mainPanel.Controls.Clear();
            EditChannelForm f = new EditChannelForm(findChannel, mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }

            this.mainPanel.Controls.Clear();
            AddChannelForm f = new AddChannelForm(mainPanel);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
    }
}
