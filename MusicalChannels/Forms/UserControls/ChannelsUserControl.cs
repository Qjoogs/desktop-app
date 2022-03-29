using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalChannels.Forms.UserControls
{
    public partial class ChannelsUserControl : UserControl
    {
        public ChannelsUserControl()
        {
            InitializeComponent();
        }

        public event EventHandler ControlClicked;

        public string PictureBox
        {
            get { return channelLogoPictureBox.ImageLocation; }
            set { channelLogoPictureBox.ImageLocation = value; }
        }
        public string ChannelName
        {
            get { return channelName.Text; }
            set { channelName.Text = value; }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            ControlClicked?.Invoke(this, e);
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 220, 220);
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void ChannelsUserControl_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
