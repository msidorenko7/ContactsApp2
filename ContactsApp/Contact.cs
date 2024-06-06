using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс контакта, хранящий основную информацию, а именно Фамилию, Имя, 
    /// объект  класса номера телефона, дату рождения, email и id ВКонтакте
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// ФИО контакта
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Email контакта
        /// </summary>
        private string _email;

        /// <summary>
        /// Телефон контакта
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Дата рождения контакта
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Ссылка на "Вконтакте" контакта
        /// </summary>
        private string _vk;

      

        /// <summary>
        /// Возвращает или задает ФИО контакта.
        /// </summary>
        public string FullName//4
        {
            get
            {
                return _fullName; //1
            }
            set
            {
                if (value.Length != 0 && value.Length <= 100)
                {
                    value = Regex.Replace(value, @"((^\w)|(\s|\p{P})\w)",
                        match => match.Value.ToUpper());

                }
                else if (value.Length > 100)//1
                {
                    throw new ArgumentException("Полное имя слишком большое " +
                        "(не более 100 символов, включая пробелы)!");
                }
                else//1
                {
                    throw new ArgumentException("Полное имя не указано!");
                }
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает или задает Email контакта
        /// </summary>
        public string Email//4
        {
            get
            {
                return _email;//1
            }
            set
            {
                if (value.Contains("@") && value.Length != 0 && value.Length <= 100) { }

                else if (value.Length > 100)//1
                {
                    throw new ArgumentException("Слишком большой размер эл. почты (максимум 100 символов, " +
                        "включая пробелы)! И должен содержать @!");
                }

                else//1
                {
                    throw new ArgumentException("Адрес электронной почты не указан! И должен содержать @.");
                }
                _email = value;//1
            }
        }

        /// <summary>
        /// Возвращает или задает Телефон контакта
        /// </summary>
        public string PhoneNumber//3
        {
            get
            {
                return _phoneNumber;//1
            }
            set
            {
                if (value.Length == 10)
                { }
                else//1
                {
                    throw new ArgumentException("Номер должен содержать 10 цифр " +
                        "\"без первых +7");
                }
                _phoneNumber = value;//1
            }
        }

        /// <summary>
        /// Возвращает или задает Дату рождения контакта
        /// </summary>
        public DateTime DateOfBirth//3
        {
            get
            {
                return _dateOfBirth;//1
            }
            set
            {
                if (value.Year >= 1900 && value.Date < DateTime.Now) { }
                else//1
                {
                    throw new ArgumentException("Указана неверная дата рождения! Это должно быть не ранее " +
                        " 1900 года и не позднее текущей даты.");
                }
                _dateOfBirth = value;//1
            }
        }

        /// <summary>
        /// Возвращает или задает Ссылку на "Вконтакте" контакта
        /// </summary>
        public string Vk//4
        {
            get
            {
                return _vk;//1
            }
            set
            {
                if (value.Length != 0 && value.Length <= 50) { }//1
                else if (value.Length > 50)//1
                {
                    throw new ArgumentException("Слишком большой идентификатор ВК! (максимум 50 символов)");
                }
                else //1
                {
                    throw new ArgumentException("Id вконтакте пуст!");
                }
                _vk = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact">./конструктор класса
        /// </summary>
        public Contact(string fullName, string email,
            string phoneNumber, string vk, DateTime dateOfBirth)
        {
            this.FullName = fullName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Vk = vk;
            this.DateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// Конструктор объекта с незаполненными полями по умолчанию
        /// </summary>
        public Contact()
        {
            _fullName = "";
            _phoneNumber = null;
            _dateOfBirth = DateTime.Now;
            _email = "";
            _vk = "";
        }

        /// <summary>
        /// Клонирует данный экземпляр <see cref="Contact"/>. Возвращает копию объекта 
        /// </summary>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
