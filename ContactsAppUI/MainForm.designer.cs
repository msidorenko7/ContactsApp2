
namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.DeleteContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.FindContactsLabel = new System.Windows.Forms.Label();
            this.FindContactsTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.PhoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.MainFormTableLayoutPanel.SuspendLayout();
            this.ContactsPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ProfilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTableLayoutPanel
            // 
            resources.ApplyResources(this.MainFormTableLayoutPanel, "MainFormTableLayoutPanel");
            this.MainFormTableLayoutPanel.Controls.Add(this.ContactsPanel, 0, 0);
            this.MainFormTableLayoutPanel.Controls.Add(this.ProfilePanel, 1, 0);
            this.MainFormTableLayoutPanel.Name = "MainFormTableLayoutPanel";
            // 
            // ContactsPanel
            // 
            resources.ApplyResources(this.ContactsPanel, "ContactsPanel");
            this.ContactsPanel.Controls.Add(this.ContactsListBox);
            this.ContactsPanel.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ContactsPanel.Controls.Add(this.FindContactsLabel);
            this.ContactsPanel.Controls.Add(this.FindContactsTextBox);
            this.ContactsPanel.Controls.Add(this.menuStrip1);
            this.ContactsPanel.Name = "ContactsPanel";
            // 
            // ContactsListBox
            // 
            resources.ApplyResources(this.ContactsListBox, "ContactsListBox");
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactslistBox_SelectedIndexChanged);
            this.ContactsListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactslistBox_KeyPress);
            // 
            // ButtonsTableLayoutPanel
            // 
            resources.ApplyResources(this.ButtonsTableLayoutPanel, "ButtonsTableLayoutPanel");
            this.ButtonsTableLayoutPanel.Controls.Add(this.DeleteContactButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditContactButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddContactButton, 0, 0);
            this.ButtonsTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            // 
            // AddContactButton
            // 
            resources.ApplyResources(this.AddContactButton, "AddContactButton");
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click_1);
            // 
            // DeleteContactButton
            // 
            resources.ApplyResources(this.DeleteContactButton, "DeleteContactButton");
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click_1);
            // 
            // EditContactButton
            // 
            resources.ApplyResources(this.EditContactButton, "EditContactButton");
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click_1);
            // 
            // FindContactsLabel
            // 
            resources.ApplyResources(this.FindContactsLabel, "FindContactsLabel");
            this.FindContactsLabel.Name = "FindContactsLabel";
            // 
            // FindContactsTextBox
            // 
            resources.ApplyResources(this.FindContactsTextBox, "FindContactsTextBox");
            this.FindContactsTextBox.Name = "FindContactsTextBox";
            this.FindContactsTextBox.TextChanged += new System.EventHandler(this.FindContactsTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            // 
            // addToolStripMenuItem
            // 
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            resources.ApplyResources(this.editContactToolStripMenuItem, "editContactToolStripMenuItem");
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // removeContactToolStripMenuItem
            // 
            resources.ApplyResources(this.removeContactToolStripMenuItem, "removeContactToolStripMenuItem");
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Click += new System.EventHandler(this.removeContactToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProfilePanel
            // 
            resources.ApplyResources(this.ProfilePanel, "ProfilePanel");
            this.ProfilePanel.Controls.Add(this.PhoneNumberMaskedTextBox);
            this.ProfilePanel.Controls.Add(this.DateOfBirthTextBox);
            this.ProfilePanel.Controls.Add(this.VKTextBox);
            this.ProfilePanel.Controls.Add(this.VKLabel);
            this.ProfilePanel.Controls.Add(this.DateOfBirthLabel);
            this.ProfilePanel.Controls.Add(this.PhoneNumberLabel);
            this.ProfilePanel.Controls.Add(this.EmailTextBox);
            this.ProfilePanel.Controls.Add(this.FullNameTextBox);
            this.ProfilePanel.Controls.Add(this.EmailLabel);
            this.ProfilePanel.Controls.Add(this.FullNameLabel);
            this.ProfilePanel.Name = "ProfilePanel";
            // 
            // PhoneNumberMaskedTextBox
            // 
            resources.ApplyResources(this.PhoneNumberMaskedTextBox, "PhoneNumberMaskedTextBox");
            this.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            this.PhoneNumberMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.PhoneNumberMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberMaskedTextBox_KeyPress);
            // 
            // DateOfBirthTextBox
            // 
            resources.ApplyResources(this.DateOfBirthTextBox, "DateOfBirthTextBox");
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateOfBirthTextBox_KeyPress_1);
            // 
            // VKTextBox
            // 
            resources.ApplyResources(this.VKTextBox, "VKTextBox");
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKTextBox_KeyPress);
            // 
            // VKLabel
            // 
            resources.ApplyResources(this.VKLabel, "VKLabel");
            this.VKLabel.Name = "VKLabel";
            // 
            // DateOfBirthLabel
            // 
            resources.ApplyResources(this.DateOfBirthLabel, "DateOfBirthLabel");
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            // 
            // PhoneNumberLabel
            // 
            resources.ApplyResources(this.PhoneNumberLabel, "PhoneNumberLabel");
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            // 
            // EmailTextBox
            // 
            resources.ApplyResources(this.EmailTextBox, "EmailTextBox");
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // FullNameTextBox
            // 
            resources.ApplyResources(this.FullNameTextBox, "FullNameTextBox");
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            resources.ApplyResources(this.EmailLabel, "EmailLabel");
            this.EmailLabel.Name = "EmailLabel";
            // 
            // FullNameLabel
            // 
            resources.ApplyResources(this.FullNameLabel, "FullNameLabel");
            this.FullNameLabel.Name = "FullNameLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainFormTableLayoutPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactsAppForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContactsAppForm_KeyDown);
            this.MainFormTableLayoutPanel.ResumeLayout(false);
            this.ContactsPanel.ResumeLayout(false);
            this.ContactsPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainFormTableLayoutPanel;
        private System.Windows.Forms.Button DeleteContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Panel ContactsPanel;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Label FindContactsLabel;
        private System.Windows.Forms.TextBox FindContactsTextBox;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskedTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

