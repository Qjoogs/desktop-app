
namespace MusicalChannels.Forms.ChannelForms
{
    partial class EditChannelForm
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
            this.addChannelNameTextBox = new System.Windows.Forms.TextBox();
            this.addChannelNameLabel = new System.Windows.Forms.Label();
            this.addInsertButton = new System.Windows.Forms.Button();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addSaveButton
            // 
            this.addSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSaveButton.Location = new System.Drawing.Point(282, 342);
            this.addSaveButton.Name = "addSaveButton";
            this.addSaveButton.Size = new System.Drawing.Size(129, 61);
            this.addSaveButton.TabIndex = 19;
            this.addSaveButton.Text = "Save";
            this.addSaveButton.UseVisualStyleBackColor = true;
            this.addSaveButton.Click += new System.EventHandler(this.addSaveButton_Click);
            // 
            // addChannelNameTextBox
            // 
            this.addChannelNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addChannelNameTextBox.Location = new System.Drawing.Point(63, 127);
            this.addChannelNameTextBox.Name = "addChannelNameTextBox";
            this.addChannelNameTextBox.Size = new System.Drawing.Size(199, 31);
            this.addChannelNameTextBox.TabIndex = 18;
            // 
            // addChannelNameLabel
            // 
            this.addChannelNameLabel.AutoSize = true;
            this.addChannelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addChannelNameLabel.Location = new System.Drawing.Point(92, 79);
            this.addChannelNameLabel.Name = "addChannelNameLabel";
            this.addChannelNameLabel.Size = new System.Drawing.Size(146, 24);
            this.addChannelNameLabel.TabIndex = 17;
            this.addChannelNameLabel.Text = "Channel name";
            // 
            // addInsertButton
            // 
            this.addInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInsertButton.Location = new System.Drawing.Point(481, 257);
            this.addInsertButton.Name = "addInsertButton";
            this.addInsertButton.Size = new System.Drawing.Size(129, 61);
            this.addInsertButton.TabIndex = 16;
            this.addInsertButton.Text = "Insert";
            this.addInsertButton.UseVisualStyleBackColor = true;
            this.addInsertButton.Click += new System.EventHandler(this.addInsertButton_Click);
            // 
            // addPictureBox
            // 
            this.addPictureBox.Location = new System.Drawing.Point(433, 48);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(218, 174);
            this.addPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPictureBox.TabIndex = 15;
            this.addPictureBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(63, 342);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(129, 61);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addSaveButton);
            this.Controls.Add(this.addChannelNameTextBox);
            this.Controls.Add(this.addChannelNameLabel);
            this.Controls.Add(this.addInsertButton);
            this.Controls.Add(this.addPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditChannelForm";
            this.Text = "EditChannelForm";
            this.Load += new System.EventHandler(this.EditChannelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.TextBox addChannelNameTextBox;
        private System.Windows.Forms.Label addChannelNameLabel;
        private System.Windows.Forms.Button addInsertButton;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.Button deleteButton;
    }
}