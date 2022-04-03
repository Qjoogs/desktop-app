
namespace MusicalChannels.Forms.ArtistForms
{
    partial class AddArtistForm
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
            this.addSaveButton = new System.Windows.Forms.Button();
            this.addArtistNameTextBox = new System.Windows.Forms.TextBox();
            this.addArtistNameLabel = new System.Windows.Forms.Label();
            this.addInsertButton = new System.Windows.Forms.Button();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.addAgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addSaveButton
            // 
            this.addSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSaveButton.Location = new System.Drawing.Point(301, 362);
            this.addSaveButton.Name = "addSaveButton";
            this.addSaveButton.Size = new System.Drawing.Size(129, 61);
            this.addSaveButton.TabIndex = 19;
            this.addSaveButton.Text = "Save";
            this.addSaveButton.UseVisualStyleBackColor = true;
            this.addSaveButton.Click += new System.EventHandler(this.addSaveButton_Click);
            // 
            // addArtistNameTextBox
            // 
            this.addArtistNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addArtistNameTextBox.Location = new System.Drawing.Point(80, 85);
            this.addArtistNameTextBox.Name = "addArtistNameTextBox";
            this.addArtistNameTextBox.Size = new System.Drawing.Size(199, 31);
            this.addArtistNameTextBox.TabIndex = 18;
            // 
            // addArtistNameLabel
            // 
            this.addArtistNameLabel.AutoSize = true;
            this.addArtistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addArtistNameLabel.Location = new System.Drawing.Point(109, 37);
            this.addArtistNameLabel.Name = "addArtistNameLabel";
            this.addArtistNameLabel.Size = new System.Drawing.Size(114, 24);
            this.addArtistNameLabel.TabIndex = 17;
            this.addArtistNameLabel.Text = "Artist name";
            // 
            // addInsertButton
            // 
            this.addInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInsertButton.Location = new System.Drawing.Point(489, 263);
            this.addInsertButton.Name = "addInsertButton";
            this.addInsertButton.Size = new System.Drawing.Size(129, 61);
            this.addInsertButton.TabIndex = 16;
            this.addInsertButton.Text = "Insert";
            this.addInsertButton.UseVisualStyleBackColor = true;
            this.addInsertButton.Click += new System.EventHandler(this.addInsertButton_Click);
            // 
            // addPictureBox
            // 
            this.addPictureBox.Location = new System.Drawing.Point(441, 54);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(218, 174);
            this.addPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPictureBox.TabIndex = 15;
            this.addPictureBox.TabStop = false;
            // 
            // addAgeTextBox
            // 
            this.addAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAgeTextBox.Location = new System.Drawing.Point(168, 149);
            this.addAgeTextBox.Name = "addAgeTextBox";
            this.addAgeTextBox.Size = new System.Drawing.Size(92, 31);
            this.addAgeTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Artist description";
            // 
            // addRichTextBox
            // 
            this.addRichTextBox.Location = new System.Drawing.Point(39, 241);
            this.addRichTextBox.Name = "addRichTextBox";
            this.addRichTextBox.Size = new System.Drawing.Size(184, 182);
            this.addRichTextBox.TabIndex = 23;
            this.addRichTextBox.Text = "";
            // 
            // AddArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addAgeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSaveButton);
            this.Controls.Add(this.addArtistNameTextBox);
            this.Controls.Add(this.addArtistNameLabel);
            this.Controls.Add(this.addInsertButton);
            this.Controls.Add(this.addPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddArtistForm";
            this.Text = "AddArtistForm";
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.TextBox addArtistNameTextBox;
        private System.Windows.Forms.Label addArtistNameLabel;
        private System.Windows.Forms.Button addInsertButton;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.TextBox addAgeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox addRichTextBox;
    }
}