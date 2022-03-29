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
    public partial class SongsAdminUserControl : UserControl
    {
        public SongsAdminUserControl()
        {
            InitializeComponent();
        }
        public event EventHandler ControlClicked;

        public string PictureBox
        {
            get { return songPictureBox.ImageLocation; }
            set { songPictureBox.ImageLocation = value; }
        }
        public string SongName
        {
            get { return songNameLabel.Text; }
            set { songNameLabel.Text = value; }
        }
        public string Duration
        {
            get { return songDurationLabel.Text; }
            set { songDurationLabel.Text = value; }
        }
        public string ReleaseDate
        {
            get { return songReleaseDateLabel.Text; }
            set { songReleaseDateLabel.Text = value; }
        }

        public string SongArtist
        {
            get { return songArtistNameLabel.Text; }
            set { songArtistNameLabel.Text = value; }
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
        private void Control_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

    }
}
