
namespace MusicalChannels.Forms
{
    partial class AddSongForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.addLabelName = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.addInsertButton = new System.Windows.Forms.Button();
            this.addSaveButton = new System.Windows.Forms.Button();
            this.addArtistSongTextBox = new System.Windows.Forms.TextBox();
            this.addArtistSongLabel = new System.Windows.Forms.Label();
            this.addDurationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addPictureBox
            // 
            this.addPictureBox.Location = new System.Drawing.Point(424, 33);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(218, 174);
            this.addPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPictureBox.TabIndex = 0;
            this.addPictureBox.TabStop = false;
            // 
            // addLabelName
            // 
            this.addLabelName.AutoSize = true;
            this.addLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLabelName.Location = new System.Drawing.Point(121, 49);
            this.addLabelName.Name = "addLabelName";
            this.addLabelName.Size = new System.Drawing.Size(120, 24);
            this.addLabelName.TabIndex = 1;
            this.addLabelName.Text = "Song Name";
            // 
            // addTextBox
            // 
            this.addTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTextBox.Location = new System.Drawing.Point(79, 97);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(199, 31);
            this.addTextBox.TabIndex = 2;
            // 
            // addInsertButton
            // 
            this.addInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInsertButton.Location = new System.Drawing.Point(472, 242);
            this.addInsertButton.Name = "addInsertButton";
            this.addInsertButton.Size = new System.Drawing.Size(129, 61);
            this.addInsertButton.TabIndex = 3;
            this.addInsertButton.Text = "Insert";
            this.addInsertButton.UseVisualStyleBackColor = true;
            this.addInsertButton.Click += new System.EventHandler(this.addInsertButton_Click);
            // 
            // addSaveButton
            // 
            this.addSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSaveButton.Location = new System.Drawing.Point(219, 429);
            this.addSaveButton.Name = "addSaveButton";
            this.addSaveButton.Size = new System.Drawing.Size(129, 61);
            this.addSaveButton.TabIndex = 5;
            this.addSaveButton.Text = "Save";
            this.addSaveButton.UseVisualStyleBackColor = true;
            this.addSaveButton.Click += new System.EventHandler(this.addSaveButton_Click);
            // 
            // addArtistSongTextBox
            // 
            this.addArtistSongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addArtistSongTextBox.Location = new System.Drawing.Point(79, 247);
            this.addArtistSongTextBox.Name = "addArtistSongTextBox";
            this.addArtistSongTextBox.Size = new System.Drawing.Size(199, 31);
            this.addArtistSongTextBox.TabIndex = 7;
            // 
            // addArtistSongLabel
            // 
            this.addArtistSongLabel.AutoSize = true;
            this.addArtistSongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addArtistSongLabel.Location = new System.Drawing.Point(121, 199);
            this.addArtistSongLabel.Name = "addArtistSongLabel";
            this.addArtistSongLabel.Size = new System.Drawing.Size(117, 24);
            this.addArtistSongLabel.TabIndex = 6;
            this.addArtistSongLabel.Text = "Artist Name";
            // 
            // addDurationTextBox
            // 
            this.addDurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDurationTextBox.Location = new System.Drawing.Point(691, 282);
            this.addDurationTextBox.Name = "addDurationTextBox";
            this.addDurationTextBox.Size = new System.Drawing.Size(112, 31);
            this.addDurationTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(702, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Duration";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chalga",
            "Ne chalga"});
            this.comboBox1.Location = new System.Drawing.Point(117, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(135, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Genre";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(607, 344);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 524);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDurationTextBox);
            this.Controls.Add(this.addArtistSongTextBox);
            this.Controls.Add(this.addArtistSongLabel);
            this.Controls.Add(this.addSaveButton);
            this.Controls.Add(this.addInsertButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.addLabelName);
            this.Controls.Add(this.addPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSongForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.AddSongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.Label addLabelName;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button addInsertButton;
        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.TextBox addArtistSongTextBox;
        private System.Windows.Forms.Label addArtistSongLabel;
        private System.Windows.Forms.TextBox addDurationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}