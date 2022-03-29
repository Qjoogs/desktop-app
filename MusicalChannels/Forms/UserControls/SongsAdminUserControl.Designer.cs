
namespace MusicalChannels.Forms.UserControls
{
    partial class SongsAdminUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.songPictureBox = new System.Windows.Forms.PictureBox();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.songReleaseDateLabel = new System.Windows.Forms.Label();
            this.songDurationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.songArtistNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // songPictureBox
            // 
            this.songPictureBox.Location = new System.Drawing.Point(14, 13);
            this.songPictureBox.Name = "songPictureBox";
            this.songPictureBox.Size = new System.Drawing.Size(175, 137);
            this.songPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songPictureBox.TabIndex = 0;
            this.songPictureBox.TabStop = false;
            this.songPictureBox.Click += new System.EventHandler(this.Control_Click);
            this.songPictureBox.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.songPictureBox.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // songNameLabel
            // 
            this.songNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.songNameLabel.Location = new System.Drawing.Point(195, 23);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(392, 23);
            this.songNameLabel.TabIndex = 1;
            this.songNameLabel.Text = "label1";
            this.songNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songNameLabel.Click += new System.EventHandler(this.Control_Click);
            this.songNameLabel.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.songNameLabel.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // songReleaseDateLabel
            // 
            this.songReleaseDateLabel.AutoSize = true;
            this.songReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songReleaseDateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.songReleaseDateLabel.Location = new System.Drawing.Point(439, 118);
            this.songReleaseDateLabel.Name = "songReleaseDateLabel";
            this.songReleaseDateLabel.Size = new System.Drawing.Size(60, 24);
            this.songReleaseDateLabel.TabIndex = 2;
            this.songReleaseDateLabel.Text = "label1";
            this.songReleaseDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songReleaseDateLabel.Click += new System.EventHandler(this.Control_Click);
            this.songReleaseDateLabel.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.songReleaseDateLabel.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // songDurationLabel
            // 
            this.songDurationLabel.AutoSize = true;
            this.songDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songDurationLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.songDurationLabel.Location = new System.Drawing.Point(229, 118);
            this.songDurationLabel.Name = "songDurationLabel";
            this.songDurationLabel.Size = new System.Drawing.Size(60, 24);
            this.songDurationLabel.TabIndex = 3;
            this.songDurationLabel.Text = "label1";
            this.songDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songDurationLabel.Click += new System.EventHandler(this.Control_Click);
            this.songDurationLabel.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.songDurationLabel.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(229, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artist:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songArtistNameLabel
            // 
            this.songArtistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songArtistNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.songArtistNameLabel.Location = new System.Drawing.Point(308, 73);
            this.songArtistNameLabel.Name = "songArtistNameLabel";
            this.songArtistNameLabel.Size = new System.Drawing.Size(248, 23);
            this.songArtistNameLabel.TabIndex = 5;
            this.songArtistNameLabel.Text = "label1";
            this.songArtistNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songArtistNameLabel.Click += new System.EventHandler(this.Control_Click);
            this.songArtistNameLabel.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.songArtistNameLabel.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // SongsAdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.songArtistNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songDurationLabel);
            this.Controls.Add(this.songReleaseDateLabel);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.songPictureBox);
            this.Name = "SongsAdminUserControl";
            this.Size = new System.Drawing.Size(590, 169);
            this.Load += new System.EventHandler(this.Control_Load);
            this.Click += new System.EventHandler(this.Control_Click);
            this.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox songPictureBox;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Label songReleaseDateLabel;
        private System.Windows.Forms.Label songDurationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label songArtistNameLabel;
    }
}
