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
using System.Data.SqlClient;



namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        /// <summary>
        ///Поле для хранения контакта
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Переменная содержащая текст исключения для имени
        /// </summary>
        private string _fullNameError = null;

        /// <summary>
        ///  Переменная содержащая текст исключения для емайла
        /// </summary>
        private string _emailError = null;

        /// <summary>
        ///  Переменная содержащая текст исключения для ID vk
        /// </summary>
        private string _vkError = null;

        /// <summary>
        ///  Переменная содержащая текст исключения для даты рождения
        /// </summary>
        private string _dateOfBirthError = null;

        /// <summary>
        ///  Переменная содержащая текст исключения для номера телефона
        /// </summary>
        private string _phoneNumberError = null;

        /// <summary>
        /// Переменная цвета для нормального состояния элементов
        /// </summary>
        private Color CurrentColor = Color.White;

        /// <summary>
        /// Переменная цвета для неправильно введеных элементов
        /// </summary>
        private Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Конcтруктор для контакта
        /// </summary>
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            Contact = contact;
        
        }

        /// <summary>
        /// Возвращает или задает контакт
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                if (_contact != null)
                {
                    UpdateForm();
                }
            }
        }

        /// <summary>
        /// Присваивание данных из объекта
        /// </summary>
        private void UpdateForm()
        {
            ContactFullNameTextBox.Text = _contact.FullName;
            ContactPhoneNumberMaskedTextBox.Text = _contact.PhoneNumber;
            ContactEmailTextBox.Text = _contact.Email;
            ContactVKTextBox.Text = _contact.Vk;
            DateOfBirthDateTimePicker.Value = _contact.DateOfBirth;
        }

       
       
        private void Okbutton_Click(object sender, EventArgs e)
        {
            if(CheckFormErrors())
            {
                UpdateContact();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        /// <summary>
        /// Проверка на заполнение поля для имени и фамилии
        /// </summary>
        private void ContactFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = ContactFullNameTextBox.Text;
                _fullNameError ="";
                ContactFullNameTextBox.BackColor = CurrentColor;
                
            }
            catch (ArgumentException exception)
            {
                _fullNameError = exception.Message;
                ContactFullNameTextBox.BackColor = ErrorColor;
            }
        }

        /// <summary>
        /// Проверка на заполнение поля для емайла
        /// </summary>
        private void ContactEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                _contact.Email = ContactEmailTextBox.Text;
                ContactEmailTextBox.BackColor = CurrentColor;
                _emailError = "";
            }
            catch (Exception exception)
            {
                _emailError = exception.Message;
                ContactEmailTextBox.BackColor = ErrorColor;
            }

        }

        /// <summary>
        /// Проверка на заполнение номера телефона
        /// </summary>
        private void ContactPhoneNumberMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _phoneNumberError = "";
                _contact.PhoneNumber = ContactPhoneNumberMaskedTextBox.Text;
                ContactPhoneNumberMaskedTextBox.BackColor = CurrentColor;
            }
            catch (Exception exception)
            {
                _phoneNumberError = exception.Message;
                ContactPhoneNumberMaskedTextBox.BackColor = ErrorColor;
            }
        }

        /// <summary>
        /// Проверка на правильность заполнения поля для ID VK
        /// </summary>
        private void ContactVKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _vkError = "";
                _contact.Vk = ContactVKTextBox.Text;
                ContactVKTextBox.BackColor = CurrentColor;
            }
            catch (Exception exception)
            {
                _vkError = exception.Message;
                ContactVKTextBox.BackColor = ErrorColor;
            }
        }

        /// <summary>
        /// Проверка на правильность введенных данных
        /// </summary>
        /// <returns></returns>
        private bool CheckFormErrors()
        {
            var errors = new List<string>
            {
                _fullNameError, _emailError, _phoneNumberError, _vkError, _dateOfBirthError
            };

            errors = errors.Where(t => t != "").ToList();
            
            if(errors.Count == 0)
            {
                return true;
            }

            if (errors.Any(t => t == null))
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;  
            }

            var fullMessage = string.Join("\n - ", errors);
            MessageBox.Show(fullMessage);
            return false;
        }

        /// <summary>
        /// Обновление данных в поляъ объекта из элементов
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = ContactFullNameTextBox.Text ;
            _contact.PhoneNumber = ContactPhoneNumberMaskedTextBox.Text;
            _contact.Email = ContactEmailTextBox.Text;
            _contact.Vk = ContactVKTextBox.Text;
            _contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
        }

        /// <summary>
        /// Проверка на правильный ввод даты рождения
        /// </summary>
        private void DateOfBirthdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _dateOfBirthError = "";
                _contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
                DateOfBirthDateTimePicker.BackColor = CurrentColor;
            }

            catch (Exception exception)
            {
                _dateOfBirthError = exception.Message;
                DateOfBirthDateTimePicker.BackColor = ErrorColor;
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
