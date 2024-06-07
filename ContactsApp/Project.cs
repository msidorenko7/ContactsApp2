using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Project
    {
        /// <summary>
        /// Возвращает или задает список всех контактов
        /// </summary>
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// Сортирует список контактов по фамилиям
        /// </summary>
        /// <returns>Отсортированный список контактов</returns>
        public List<Contact> SortContactsByFullName()//2
        {
            if (Contacts.Count != 0)//1
            {
                return Contacts.OrderBy(contact => contact.FullName).ToList();
            }
            else//1
            {
                return Contacts;
            }
        }

        /// <summary>
        /// Сортирует список контактов по фамилиям с заданной подстрокой
        /// </summary>
        /// <param name="substring">Подстрока, по которой ищется элемент</param>
        /// <returns>Отсортированный список контактов с подстрокой</returns>
        public List<Contact> FindByFullName(string substring)//2
        {
            var foundContacts = new List<Contact>();

            for (int i = 0; i < Contacts.Count; i++)
            {
                if (Contacts[i].FullName.ToLower().Contains(substring.ToLower()))
                {
                    foundContacts.Add(Contacts[i]);
                }
            }
            return foundContacts;
        }

        /// <summary>
        /// Добавление в список нового контакта и автоматическая сортировка
        /// </summary>
        public void AddContact(Contact NewContact)
        {
            Contacts.Add(NewContact);
        }

        /// <summary>
        /// Удаляет объект <see cref="Contact">
        /// </summary>
        public void DeleteContact(int DeletedContact)
        {
            Contacts.RemoveAt(DeletedContact);
            SortContactsByFullName();
        }

        /// <summary>
        /// Создает пустой экземпляр <see cref="Project"/>
        /// </summary>
        public Project()
        {
            Contacts = new List<Contact>();
        }
    }
}