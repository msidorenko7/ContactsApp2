
namespace ContactsApp.View
{
    partial class ContactForm
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
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ContactFullNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactEmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.VKLabel = new System.Windows.Forms.Label();
            this.ContactVKTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContactPhoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ContactTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InformationPanel.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.ContactTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationPanel
            // 
            this.InformationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationPanel.AutoSize = true;
            this.InformationPanel.BackColor = System.Drawing.SystemColors.Control;
            this.InformationPanel.Controls.Add(this.OkButton);
            this.InformationPanel.Controls.Add(this.CancelButton);
            this.InformationPanel.Location = new System.Drawing.Point(1, 373);
            this.InformationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(691, 59);
            this.InformationPanel.TabIndex = 18;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(526, 18);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(607, 18);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Controls.Add(this.ContactPhoneNumberMaskedTextBox);
            this.ProfilePanel.Controls.Add(this.DateOfBirthDateTimePicker);
            this.ProfilePanel.Controls.Add(this.ContactVKTextBox);
            this.ProfilePanel.Controls.Add(this.VKLabel);
            this.ProfilePanel.Controls.Add(this.DateOfBirthLabel);
            this.ProfilePanel.Controls.Add(this.PhoneNumberLabel);
            this.ProfilePanel.Controls.Add(this.ContactEmailTextBox);
            this.ProfilePanel.Controls.Add(this.ContactFullNameTextBox);
            this.ProfilePanel.Controls.Add(this.EmailLabel);
            this.ProfilePanel.Controls.Add(this.FullNameLabel);
            this.ProfilePanel.Location = new System.Drawing.Point(12, 2);
            this.ProfilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(499, 366);
            this.ProfilePanel.TabIndex = 1;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.ForeColor = System.Drawing.Color.Black;
            this.FullNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FullNameLabel.Location = new System.Drawing.Point(13, 18);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(71, 16);
            this.FullNameLabel.TabIndex = 18;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmailLabel.Location = new System.Drawing.Point(13, 90);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 16);
            this.EmailLabel.TabIndex = 19;
            this.EmailLabel.Text = "E-mail:";
            // 
            // ContactFullNameTextBox
            // 
            this.ContactFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactFullNameTextBox.Location = new System.Drawing.Point(16, 37);
            this.ContactFullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactFullNameTextBox.Name = "ContactFullNameTextBox";
            this.ContactFullNameTextBox.Size = new System.Drawing.Size(478, 22);
            this.ContactFullNameTextBox.TabIndex = 17;
            this.ContactFullNameTextBox.TextChanged += new System.EventHandler(this.ContactFullNameTextBox_TextChanged);
            // 
            // ContactEmailTextBox
            // 
            this.ContactEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactEmailTextBox.Location = new System.Drawing.Point(16, 110);
            this.ContactEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactEmailTextBox.Name = "ContactEmailTextBox";
            this.ContactEmailTextBox.Size = new System.Drawing.Size(478, 22);
            this.ContactEmailTextBox.TabIndex = 20;
            this.ContactEmailTextBox.TextChanged += new System.EventHandler(this.ContactEmailTextBox_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.PhoneNumberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(13, 159);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(97, 16);
            this.PhoneNumberLabel.TabIndex = 21;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.ForeColor = System.Drawing.Color.Black;
            this.DateOfBirthLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(13, 219);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(82, 16);
            this.DateOfBirthLabel.TabIndex = 23;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.ForeColor = System.Drawing.Color.Black;
            this.VKLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VKLabel.Location = new System.Drawing.Point(12, 276);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(27, 16);
            this.VKLabel.TabIndex = 24;
            this.VKLabel.Text = "VK:";
            // 
            // ContactVKTextBox
            // 
            this.ContactVKTextBox.Location = new System.Drawing.Point(16, 294);
            this.ContactVKTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactVKTextBox.Name = "ContactVKTextBox";
            this.ContactVKTextBox.Size = new System.Drawing.Size(200, 22);
            this.ContactVKTextBox.TabIndex = 25;
            this.ContactVKTextBox.TextChanged += new System.EventHandler(this.ContactVKTextBox_TextChanged);
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(17, 238);
            this.DateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateOfBirthDateTimePicker.TabIndex = 27;
            this.DateOfBirthDateTimePicker.ValueChanged += new System.EventHandler(this.DateOfBirthdateTimePicker_ValueChanged);
            // 
            // ContactPhoneNumberMaskedTextBox
            // 
            this.ContactPhoneNumberMaskedTextBox.Location = new System.Drawing.Point(16, 178);
            this.ContactPhoneNumberMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.ContactPhoneNumberMaskedTextBox.Name = "ContactPhoneNumberMaskedTextBox";
            this.ContactPhoneNumberMaskedTextBox.Size = new System.Drawing.Size(201, 22);
            this.ContactPhoneNumberMaskedTextBox.TabIndex = 28;
            this.ContactPhoneNumberMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.ContactPhoneNumberMaskedTextBox.TextChanged += new System.EventHandler(this.ContactPhoneNumberMaskedTextBox_TextChanged);
            // 
            // ContactTableLayoutPanel
            // 
            this.ContactTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContactTableLayoutPanel.ColumnCount = 2;
            this.ContactTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.30246F));
            this.ContactTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.69754F));
            this.ContactTableLayoutPanel.Controls.Add(this.ProfilePanel, 1, 0);
            this.ContactTableLayoutPanel.ForeColor = System.Drawing.Color.Transparent;
            this.ContactTableLayoutPanel.Location = new System.Drawing.Point(1, 0);
            this.ContactTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactTableLayoutPanel.Name = "ContactTableLayoutPanel";
            this.ContactTableLayoutPanel.RowCount = 1;
            this.ContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.ContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.ContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.ContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.ContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.ContactTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.ContactTableLayoutPanel.Size = new System.Drawing.Size(691, 356);
            this.ContactTableLayoutPanel.TabIndex = 0;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 434);
            this.Controls.Add(this.InformationPanel);
            this.Controls.Add(this.ContactTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.InformationPanel.ResumeLayout(false);
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.ContactTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.MaskedTextBox ContactPhoneNumberMaskedTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox ContactVKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox ContactEmailTextBox;
        private System.Windows.Forms.TextBox ContactFullNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TableLayoutPanel ContactTableLayoutPanel;
    }
}