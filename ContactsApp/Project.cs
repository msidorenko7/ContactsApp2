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
        /// Создает пустой экземпляр <see cref="Project"/>
        /// </summary>
        public Project()
        {
            Contacts = new List<Contact>();
        }
    }
}
