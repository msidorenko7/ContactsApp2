
namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.AuthorFullNameLabel = new System.Windows.Forms.Label();
            this.AuthorEmailLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LicenseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.AutoSize = true;
            this.ContactsAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAppLabel.Location = new System.Drawing.Point(16, 31);
            this.ContactsAppLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(160, 29);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(23, 63);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(34, 16);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v 1.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(23, 102);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(48, 16);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(23, 146);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 16);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email:";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(23, 186);
            this.GithubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(48, 16);
            this.GithubLabel.TabIndex = 4;
            this.GithubLabel.Text = "Github:";
            // 
            // AuthorFullNameLabel
            // 
            this.AuthorFullNameLabel.AutoSize = true;
            this.AuthorFullNameLabel.Location = new System.Drawing.Point(140, 102);
            this.AuthorFullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorFullNameLabel.Name = "AuthorFullNameLabel";
            this.AuthorFullNameLabel.Size = new System.Drawing.Size(183, 16);
            this.AuthorFullNameLabel.TabIndex = 5;
            this.AuthorFullNameLabel.Text = "Sidorenko Mikhail Antonovich";
            // 
            // AuthorEmailLabel
            // 
            this.AuthorEmailLabel.AutoSize = true;
            this.AuthorEmailLabel.Location = new System.Drawing.Point(140, 146);
            this.AuthorEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorEmailLabel.Name = "AuthorEmailLabel";
            this.AuthorEmailLabel.Size = new System.Drawing.Size(175, 16);
            this.AuthorEmailLabel.TabIndex = 6;
            this.AuthorEmailLabel.Text = "msidorenko600@gmail.com";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(574, 451);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 28);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // GithubLinkLabel
            // 
            this.GithubLinkLabel.AutoSize = true;
            this.GithubLinkLabel.Location = new System.Drawing.Point(140, 186);
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.Size = new System.Drawing.Size(193, 16);
            this.GithubLinkLabel.TabIndex = 11;
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.Text = "https://github.com/msidorenko7";
            this.GithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithublinkLabel_LinkClicked);
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.Location = new System.Drawing.Point(21, 226);
            this.LicenseTextBox.Multiline = true;
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LicenseTextBox.Size = new System.Drawing.Size(653, 185);
            this.LicenseTextBox.TabIndex = 20;
            this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
            this.LicenseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseTextBox_KeyPress);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 505);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.LicenseTextBox);
            this.Controls.Add(this.GithubLinkLabel);
            this.Controls.Add(this.AuthorEmailLabel);
            this.Controls.Add(this.AuthorFullNameLabel);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ContactsAppLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.Label AuthorFullNameLabel;
        private System.Windows.Forms.Label AuthorEmailLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.LinkLabel GithubLinkLabel;
        private System.Windows.Forms.TextBox LicenseTextBox;
    }
}