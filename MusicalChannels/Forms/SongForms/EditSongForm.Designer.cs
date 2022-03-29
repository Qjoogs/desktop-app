
namespace MusicalChannels.Forms
{
    partial class EditSongForm
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
            this.addDeleteButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addDurationTextBox = new System.Windows.Forms.TextBox();
            this.addArtistSongTextBox = new System.Windows.Forms.TextBox();
            this.addArtistSongLabel = new System.Windows.Forms.Label();
            this.addSaveButton = new System.Windows.Forms.Button();
            this.addInsertButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.addLabelName = new System.Windows.Forms.Label();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addDeleteButton
            // 
            this.addDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDeleteButton.Location = new System.Drawing.Point(74, 420);
            this.addDeleteButton.Name = "addDeleteButton";
            this.addDeleteButton.Size = new System.Drawing.Size(129, 61);
            this.addDeleteButton.TabIndex = 27;
            this.addDeleteButton.Text = "Delete";
            this.addDeleteButton.UseVisualStyleBackColor = true;
            this.addDeleteButton.Click += new System.EventHandler(this.addDeleteButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(602, 337);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(130, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Genre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chalga",
            "Ne chalga"});
            this.comboBox1.Location = new System.Drawing.Point(112, 348);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(697, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Duration";
            // 
            // addDurationTextBox
            // 
            this.addDurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDurationTextBox.Location = new System.Drawing.Point(686, 275);
            this.addDurationTextBox.Name = "addDurationTextBox";
            this.addDurationTextBox.Size = new System.Drawing.Size(112, 31);
            this.addDurationTextBox.TabIndex = 22;
            // 
            // addArtistSongTextBox
            // 
            this.addArtistSongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addArtistSongTextBox.Location = new System.Drawing.Point(74, 240);
            this.addArtistSongTextBox.Name = "addArtistSongTextBox";
            this.addArtistSongTextBox.Size = new System.Drawing.Size(199, 31);
            this.addArtistSongTextBox.TabIndex = 21;
            // 
            // addArtistSongLabel
            // 
            this.addArtistSongLabel.AutoSize = true;
            this.addArtistSongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addArtistSongLabel.Location = new System.Drawing.Point(116, 192);
            this.addArtistSongLabel.Name = "addArtistSongLabel";
            this.addArtistSongLabel.Size = new System.Drawing.Size(117, 24);
            this.addArtistSongLabel.TabIndex = 20;
            this.addArtistSongLabel.Text = "Artist Name";
            // 
            // addSaveButton
            // 
            this.addSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSaveButton.Location = new System.Drawing.Point(348, 420);
            this.addSaveButton.Name = "addSaveButton";
            this.addSaveButton.Size = new System.Drawing.Size(129, 61);
            this.addSaveButton.TabIndex = 19;
            this.addSaveButton.Text = "Save";
            this.addSaveButton.UseVisualStyleBackColor = true;
            this.addSaveButton.Click += new System.EventHandler(this.addSaveButton_Click);
            // 
            // addInsertButton
            // 
            this.addInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInsertButton.Location = new System.Drawing.Point(467, 235);
            this.addInsertButton.Name = "addInsertButton";
            this.addInsertButton.Size = new System.Drawing.Size(129, 61);
            this.addInsertButton.TabIndex = 17;
            this.addInsertButton.Text = "Insert";
            this.addInsertButton.UseVisualStyleBackColor = true;
            this.addInsertButton.Click += new System.EventHandler(this.addInsertButton_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTextBox.Location = new System.Drawing.Point(74, 90);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(199, 31);
            this.addTextBox.TabIndex = 16;
            // 
            // addLabelName
            // 
            this.addLabelName.AutoSize = true;
            this.addLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLabelName.Location = new System.Drawing.Point(116, 42);
            this.addLabelName.Name = "addLabelName";
            this.addLabelName.Size = new System.Drawing.Size(120, 24);
            this.addLabelName.TabIndex = 15;
            this.addLabelName.Text = "Song Name";
            // 
            // addPictureBox
            // 
            this.addPictureBox.Location = new System.Drawing.Point(419, 26);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(218, 174);
            this.addPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPictureBox.TabIndex = 14;
            this.addPictureBox.TabStop = false;
            // 
            // EditSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 524);
            this.Controls.Add(this.addDeleteButton);
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
            this.Name = "EditSongForm";
            this.Text = "EditSongForm";
            this.Load += new System.EventHandler(this.EditSongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDeleteButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addDurationTextBox;
        private System.Windows.Forms.TextBox addArtistSongTextBox;
        private System.Windows.Forms.Label addArtistSongLabel;
        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.Button addInsertButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Label addLabelName;
        private System.Windows.Forms.PictureBox addPictureBox;
    }
}