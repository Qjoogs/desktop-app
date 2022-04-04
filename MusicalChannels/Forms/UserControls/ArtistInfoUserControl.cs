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
    public partial class ArtistInfoUserControl : UserControl
    {
        public ArtistInfoUserControl()
        {
            InitializeComponent();
        }

        public string ArtistNameLabel
        {
            get { return artistNameLabel.Text; }
            set { artistNameLabel.Text = value; }
        }
        public string ArtistAgeLabel
        {
            get { return artistAgeLabel.Text; }
            set { artistAgeLabel.Text = value; }
        }
        public string ArtistDescriptionLabel
        {
            get { return artistDescriptionLabel.Text; }
            set { artistDescriptionLabel.Text = value; }
        }
        public string PictureBox
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }

       
    }
}
