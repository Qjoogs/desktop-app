
namespace MusicalChannels.Forms.UserControls
{
    partial class ChannelsUserControl
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
            this.channelLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.channelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.channelLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // channelLogoPictureBox
            // 
            this.channelLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.channelLogoPictureBox.Name = "channelLogoPictureBox";
            this.channelLogoPictureBox.Size = new System.Drawing.Size(336, 214);
            this.channelLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.channelLogoPictureBox.TabIndex = 0;
            this.channelLogoPictureBox.TabStop = false;
            this.channelLogoPictureBox.Click += new System.EventHandler(this.Control_Click);
            this.channelLogoPictureBox.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.channelLogoPictureBox.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // channelName
            // 
            this.channelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.channelName.Location = new System.Drawing.Point(3, 234);
            this.channelName.Name = "channelName";
            this.channelName.Size = new System.Drawing.Size(330, 23);
            this.channelName.TabIndex = 1;
            this.channelName.Text = "label1";
            this.channelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channelName.Click += new System.EventHandler(this.Control_Click);
            this.channelName.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.channelName.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // ChannelsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.channelName);
            this.Controls.Add(this.channelLogoPictureBox);
            this.Name = "ChannelsUserControl";
            this.Size = new System.Drawing.Size(336, 283);
            this.Load += new System.EventHandler(this.ChannelsUserControl_Load);
            this.Click += new System.EventHandler(this.Control_Click);
            this.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.channelLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox channelLogoPictureBox;
        private System.Windows.Forms.Label channelName;
    }
}
