
namespace MusicalChannels.Forms.UserControls
{
    partial class ArtistInfoUserControl
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
            this.artistNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artistAgeLabel = new System.Windows.Forms.Label();
            this.artistDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // artistNameLabel
            // 
            this.artistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistNameLabel.Location = new System.Drawing.Point(263, 36);
            this.artistNameLabel.Name = "artistNameLabel";
            this.artistNameLabel.Size = new System.Drawing.Size(531, 23);
            this.artistNameLabel.TabIndex = 0;
            this.artistNameLabel.Text = "label1";
            this.artistNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistAgeLabel
            // 
            this.artistAgeLabel.AutoSize = true;
            this.artistAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistAgeLabel.Location = new System.Drawing.Point(332, 85);
            this.artistAgeLabel.Name = "artistAgeLabel";
            this.artistAgeLabel.Size = new System.Drawing.Size(30, 24);
            this.artistAgeLabel.TabIndex = 3;
            this.artistAgeLabel.Text = "10";
            this.artistAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistDescriptionLabel
            // 
            this.artistDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistDescriptionLabel.Location = new System.Drawing.Point(368, 85);
            this.artistDescriptionLabel.Name = "artistDescriptionLabel";
            this.artistDescriptionLabel.Size = new System.Drawing.Size(412, 204);
            this.artistDescriptionLabel.TabIndex = 4;
            this.artistDescriptionLabel.Text = "label1";
            this.artistDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArtistInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.artistDescriptionLabel);
            this.Controls.Add(this.artistAgeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.artistNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.Name = "ArtistInfoUserControl";
            this.Size = new System.Drawing.Size(797, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label artistNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label artistAgeLabel;
        private System.Windows.Forms.Label artistDescriptionLabel;
    }
}
