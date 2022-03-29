
namespace MusicalChannels
{
    partial class Form1
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.registerButtonLogin = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.passCheckBox = new System.Windows.Forms.CheckBox();
            this.loginButtonReg = new System.Windows.Forms.Button();
            this.emailTextBoxReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBoxReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.usernametextBoxReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.Controls.Add(this.checkBox1);
            this.loginPanel.Controls.Add(this.registerButtonLogin);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Location = new System.Drawing.Point(111, 76);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(335, 312);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(64, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 22);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // registerButtonLogin
            // 
            this.registerButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButtonLogin.Location = new System.Drawing.Point(3, 247);
            this.registerButtonLogin.Name = "registerButtonLogin";
            this.registerButtonLogin.Size = new System.Drawing.Size(148, 52);
            this.registerButtonLogin.TabIndex = 5;
            this.registerButtonLogin.Text = "Register";
            this.registerButtonLogin.UseVisualStyleBackColor = true;
            this.registerButtonLogin.Click += new System.EventHandler(this.registerButtonLogin_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(64, 182);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(201, 29);
            this.passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(107, 133);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 24);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(184, 247);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(148, 52);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(64, 71);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(201, 29);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.Location = new System.Drawing.Point(107, 23);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 24);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // registerPanel
            // 
            this.registerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerPanel.Controls.Add(this.passCheckBox);
            this.registerPanel.Controls.Add(this.loginButtonReg);
            this.registerPanel.Controls.Add(this.emailTextBoxReg);
            this.registerPanel.Controls.Add(this.label3);
            this.registerPanel.Controls.Add(this.passwordTextBoxReg);
            this.registerPanel.Controls.Add(this.label1);
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Controls.Add(this.usernametextBoxReg);
            this.registerPanel.Controls.Add(this.label2);
            this.registerPanel.Location = new System.Drawing.Point(50, 29);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(437, 394);
            this.registerPanel.TabIndex = 5;
            // 
            // passCheckBox
            // 
            this.passCheckBox.AutoSize = true;
            this.passCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passCheckBox.Location = new System.Drawing.Point(125, 289);
            this.passCheckBox.Name = "passCheckBox";
            this.passCheckBox.Size = new System.Drawing.Size(136, 22);
            this.passCheckBox.TabIndex = 8;
            this.passCheckBox.Text = "Show Password";
            this.passCheckBox.UseVisualStyleBackColor = true;
            this.passCheckBox.CheckedChanged += new System.EventHandler(this.passCheckBox_CheckedChanged);
            // 
            // loginButtonReg
            // 
            this.loginButtonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButtonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButtonReg.Location = new System.Drawing.Point(248, 326);
            this.loginButtonReg.Name = "loginButtonReg";
            this.loginButtonReg.Size = new System.Drawing.Size(148, 52);
            this.loginButtonReg.TabIndex = 7;
            this.loginButtonReg.Text = "Login";
            this.loginButtonReg.UseVisualStyleBackColor = true;
            this.loginButtonReg.Click += new System.EventHandler(this.loginButtonReg_Click);
            // 
            // emailTextBoxReg
            // 
            this.emailTextBoxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBoxReg.Location = new System.Drawing.Point(122, 152);
            this.emailTextBoxReg.Name = "emailTextBoxReg";
            this.emailTextBoxReg.Size = new System.Drawing.Size(201, 29);
            this.emailTextBoxReg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(183, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // passwordTextBoxReg
            // 
            this.passwordTextBoxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBoxReg.Location = new System.Drawing.Point(122, 245);
            this.passwordTextBoxReg.Name = "passwordTextBoxReg";
            this.passwordTextBoxReg.Size = new System.Drawing.Size(201, 29);
            this.passwordTextBoxReg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(64, 326);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(148, 52);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // usernametextBoxReg
            // 
            this.usernametextBoxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernametextBoxReg.Location = new System.Drawing.Point(122, 62);
            this.usernametextBoxReg.Name = "usernametextBoxReg";
            this.usernametextBoxReg.Size = new System.Drawing.Size(201, 29);
            this.usernametextBoxReg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 464);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MusicalChannels";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.TextBox emailTextBoxReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBoxReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox usernametextBoxReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButtonReg;
        private System.Windows.Forms.Button registerButtonLogin;
        private System.Windows.Forms.CheckBox passCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

