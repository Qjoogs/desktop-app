
namespace MusicalChannels
{
    partial class MainForm
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.artistsEditBTN = new System.Windows.Forms.Button();
            this.changeSide = new System.Windows.Forms.Button();
            this.songsEditBTN = new System.Windows.Forms.Button();
            this.channeleditBTN = new System.Windows.Forms.Button();
            this.usersBTN = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.filtersBTN = new System.Windows.Forms.Button();
            this.artistsBTN = new System.Windows.Forms.Button();
            this.channelsBTN = new System.Windows.Forms.Button();
            this.homeBTN = new System.Windows.Forms.Button();
            this.addSaveButton = new System.Windows.Forms.Button();
            this.addCancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.LightYellow;
            this.sidePanel.Controls.Add(this.artistsEditBTN);
            this.sidePanel.Controls.Add(this.changeSide);
            this.sidePanel.Controls.Add(this.songsEditBTN);
            this.sidePanel.Controls.Add(this.channeleditBTN);
            this.sidePanel.Controls.Add(this.usersBTN);
            this.sidePanel.Controls.Add(this.usernameLabel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(862, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 624);
            this.sidePanel.TabIndex = 0;
            // 
            // artistsEditBTN
            // 
            this.artistsEditBTN.FlatAppearance.BorderSize = 0;
            this.artistsEditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artistsEditBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistsEditBTN.Location = new System.Drawing.Point(3, 409);
            this.artistsEditBTN.Name = "artistsEditBTN";
            this.artistsEditBTN.Size = new System.Drawing.Size(194, 39);
            this.artistsEditBTN.TabIndex = 12;
            this.artistsEditBTN.Text = "Artists";
            this.artistsEditBTN.UseVisualStyleBackColor = true;
            this.artistsEditBTN.Click += new System.EventHandler(this.artistsEditBTN_Click);
            // 
            // changeSide
            // 
            this.changeSide.BackgroundImage = global::MusicalChannels.Properties.Resources.leftArrow;
            this.changeSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeSide.FlatAppearance.BorderSize = 0;
            this.changeSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSide.Location = new System.Drawing.Point(75, 568);
            this.changeSide.Name = "changeSide";
            this.changeSide.Size = new System.Drawing.Size(41, 31);
            this.changeSide.TabIndex = 11;
            this.changeSide.UseVisualStyleBackColor = true;
            this.changeSide.Click += new System.EventHandler(this.changeSide_Click);
            // 
            // songsEditBTN
            // 
            this.songsEditBTN.FlatAppearance.BorderSize = 0;
            this.songsEditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songsEditBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songsEditBTN.Location = new System.Drawing.Point(3, 326);
            this.songsEditBTN.Name = "songsEditBTN";
            this.songsEditBTN.Size = new System.Drawing.Size(194, 39);
            this.songsEditBTN.TabIndex = 10;
            this.songsEditBTN.Text = "Songs";
            this.songsEditBTN.UseVisualStyleBackColor = true;
            this.songsEditBTN.Click += new System.EventHandler(this.songsEditBTN_Click);
            // 
            // channeleditBTN
            // 
            this.channeleditBTN.FlatAppearance.BorderSize = 0;
            this.channeleditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.channeleditBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.channeleditBTN.Location = new System.Drawing.Point(3, 240);
            this.channeleditBTN.Name = "channeleditBTN";
            this.channeleditBTN.Size = new System.Drawing.Size(194, 39);
            this.channeleditBTN.TabIndex = 9;
            this.channeleditBTN.Text = "Channels";
            this.channeleditBTN.UseVisualStyleBackColor = true;
            this.channeleditBTN.Click += new System.EventHandler(this.channeleditBTN_Click);
            // 
            // usersBTN
            // 
            this.usersBTN.FlatAppearance.BorderSize = 0;
            this.usersBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersBTN.Location = new System.Drawing.Point(3, 158);
            this.usersBTN.Name = "usersBTN";
            this.usersBTN.Size = new System.Drawing.Size(194, 39);
            this.usersBTN.TabIndex = 8;
            this.usersBTN.Text = "Users";
            this.usersBTN.UseVisualStyleBackColor = true;
            this.usersBTN.Click += new System.EventHandler(this.usersBTN_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(0, 44);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(197, 20);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "label1";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.filtersBTN);
            this.topPanel.Controls.Add(this.artistsBTN);
            this.topPanel.Controls.Add(this.channelsBTN);
            this.topPanel.Controls.Add(this.homeBTN);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(862, 100);
            this.topPanel.TabIndex = 2;
            // 
            // filtersBTN
            // 
            this.filtersBTN.FlatAppearance.BorderSize = 0;
            this.filtersBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtersBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtersBTN.Location = new System.Drawing.Point(641, 33);
            this.filtersBTN.Name = "filtersBTN";
            this.filtersBTN.Size = new System.Drawing.Size(114, 39);
            this.filtersBTN.TabIndex = 7;
            this.filtersBTN.Text = "Filters";
            this.filtersBTN.UseVisualStyleBackColor = true;
            // 
            // artistsBTN
            // 
            this.artistsBTN.FlatAppearance.BorderSize = 0;
            this.artistsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artistsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistsBTN.Location = new System.Drawing.Point(448, 33);
            this.artistsBTN.Name = "artistsBTN";
            this.artistsBTN.Size = new System.Drawing.Size(114, 39);
            this.artistsBTN.TabIndex = 6;
            this.artistsBTN.Text = "Artists";
            this.artistsBTN.UseVisualStyleBackColor = true;
            this.artistsBTN.Click += new System.EventHandler(this.artistsBTN_Click);
            // 
            // channelsBTN
            // 
            this.channelsBTN.FlatAppearance.BorderSize = 0;
            this.channelsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.channelsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.channelsBTN.Location = new System.Drawing.Point(236, 33);
            this.channelsBTN.Name = "channelsBTN";
            this.channelsBTN.Size = new System.Drawing.Size(127, 39);
            this.channelsBTN.TabIndex = 5;
            this.channelsBTN.Text = "Channels";
            this.channelsBTN.UseVisualStyleBackColor = true;
            this.channelsBTN.Click += new System.EventHandler(this.channelsBTN_Click);
            // 
            // homeBTN
            // 
            this.homeBTN.FlatAppearance.BorderSize = 0;
            this.homeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeBTN.Location = new System.Drawing.Point(55, 33);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(114, 39);
            this.homeBTN.TabIndex = 4;
            this.homeBTN.Text = "Home";
            this.homeBTN.UseVisualStyleBackColor = true;
            this.homeBTN.Click += new System.EventHandler(this.homeBTN_Click);
            // 
            // addSaveButton
            // 
            this.addSaveButton.Location = new System.Drawing.Point(0, 0);
            this.addSaveButton.Name = "addSaveButton";
            this.addSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addSaveButton.TabIndex = 0;
            // 
            // addCancelButton
            // 
            this.addCancelButton.Location = new System.Drawing.Point(0, 0);
            this.addCancelButton.Name = "addCancelButton";
            this.addCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addCancelButton.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(0, 0);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 20);
            this.addTextBox.TabIndex = 0;
            // 
            // addNameLabel
            // 
            this.addNameLabel.Location = new System.Drawing.Point(0, 0);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(100, 23);
            this.addNameLabel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(862, 524);
            this.mainPanel.TabIndex = 3;
            // 
            // addPictureBox
            // 
            this.addPictureBox.Location = new System.Drawing.Point(0, 0);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(100, 50);
            this.addPictureBox.TabIndex = 0;
            this.addPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 624);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button filtersBTN;
        private System.Windows.Forms.Button artistsBTN;
        private System.Windows.Forms.Button channelsBTN;
        private System.Windows.Forms.Button homeBTN;
        private System.Windows.Forms.Button changeSide;
        private System.Windows.Forms.Button songsEditBTN;
        private System.Windows.Forms.Button channeleditBTN;
        private System.Windows.Forms.Button usersBTN;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.Button addCancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button artistsEditBTN;
    }
}