using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;


namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле для хранения всех контактов во время работы
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Список отображаемых контактов 
        /// </summary>
        private List<Contact> _contacts;

        private ProjectSerializer _projectSerializer = new ProjectSerializer();
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public MainForm()
        {
            _project = _projectSerializer.LoadFromFile();
            InitializeComponent();

        }

        /// <summary>
        /// Добавление нового контакта
        /// </summary>
        private void AddContact()
        {
            var contact = new ContactForm(new Contact());
            contact.ShowDialog();

            if (contact.DialogResult == DialogResult.OK)
            {
                _project.AddContact(contact.Contact);
                _projectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Удаление контакта 
        /// </summary>
        private void RemoveContact(int IndexContact)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Чтобы удалить контакт, выберите его!", "Ошибка", 
                    MessageBoxButtons.OK);
            }
            else
            {
                var selectedContact = _project.Contacts[IndexContact];
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить этот контакт:"
                    + selectedContact.FullName + "?", "Ошибка!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ContactsListBox.Items.Remove(ContactsListBox.SelectedIndex);
                    int index_contact = ContactsListBox.SelectedIndex;
                    _project.Contacts.RemoveAt(index_contact);
                    _projectSerializer.SaveToFile(_project);
                    ClearSelectedContact();
                }
            }
        }

        ///<summary>
        ///Отображение данных о контакте в правой части формы
        ///</summary>
        private void UpdateSelectedContact(int IndexContact)
        {
            var selectedContact = _contacts[IndexContact];
            FullNameTextBox.Text = selectedContact.FullName;
            EmailTextBox.Text = selectedContact.Email;
            PhoneNumberMaskedTextBox.Text = selectedContact.PhoneNumber;
            DateOfBirthTextBox.Text = selectedContact.DateOfBirth.ToShortDateString();
            VKTextBox.Text = selectedContact.Vk;
        }

        ///<summary>
        ///Очищение элементов если не выбран/нет ни одного контакта
        ///</summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Clear();
            EmailTextBox.Clear();
            PhoneNumberMaskedTextBox.Clear();
            DateOfBirthTextBox.Clear();
            VKTextBox.Clear();
        }

        /// <summary>
        /// Обновление списка листбокса
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();

            if(FindContactsTextBox.Text != "")
            {
                _contacts = _project.FindByFullName(FindContactsTextBox.Text);
                foreach(Contact contact in _contacts)
                {
                    ContactsListBox.Items.Add(contact.FullName);
                    ContactsListBox.SelectedIndex = 0;
                }
            }
            else
            {
                _contacts = _project.SortContactsByFullName();
                foreach (Contact contact in _contacts)
                {
                    ContactsListBox.Items.Add(contact.FullName);
                    ContactsListBox.SelectedIndex = 0;
                }
            }
        }

        private void ContactsAppForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                AboutForm aboutForm = new AboutForm();
                aboutForm.ShowDialog();
            }
        }
    
        private void ContactslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                UpdateSelectedContact(ContactsListBox.SelectedIndex);
            }
            else
            {
                ClearSelectedContact();
            }
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ContactslistBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ContactsAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрыть программу?",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                _projectSerializer.SaveToFile(_project);
                e.Cancel = true;
            }
        }

        private void PhoneNumberMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FindContactsTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox(); 
        }

        private void DateOfBirthTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Собитие вызова кнопки для редактирования данных о контакте
        /// </summary>

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void AddContactButton_Click_1(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        private void EditContactButton_Click_1(object sender, EventArgs e)
        {
            int index = ContactsListBox.SelectedIndex;
            var indexInProject = _project.Contacts.IndexOf(_contacts[index]);
            if (index != -1)
            {
                var Contact = new ContactForm((Contact)_project.Contacts
                    [indexInProject]);
                Contact.ShowDialog();

                if (Contact.DialogResult == DialogResult.OK)
                {
                    _project.Contacts.RemoveAt(indexInProject);
                    _project.AddContact(Contact.Contact);
                    UpdateListBox();
                    UpdateSelectedContact(index);
                    _projectSerializer.SaveToFile(_project);
                    ContactsListBox.SelectedIndex = indexInProject;
                }
            }
        }

        private void DeleteContactButton_Click_1(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = ContactsListBox.SelectedIndex;
            var indexInProject = _project.Contacts.IndexOf(_contacts[index]);
            if (index != -1)
            {
                var Contact = new ContactForm((Contact)_project.Contacts
                    [indexInProject]);
                Contact.ShowDialog();

                if (Contact.DialogResult == DialogResult.OK)
                {
                    _project.Contacts.RemoveAt(indexInProject);
                    _project.AddContact(Contact.Contact);
                    UpdateListBox();
                    UpdateSelectedContact(index);
                    _projectSerializer.SaveToFile(_project);
                    ContactsListBox.SelectedIndex = indexInProject;
                }
            }
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
