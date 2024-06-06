using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;


namespace ContactsAppUI
{
    internal static class Program
    {
        private const string FileLoad = @"C:\Users\Mikhail\Desktop\ContactApp.txt";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создание контакта
            Contact contact = new Contact("Михаил Сидоренко", "msidorenko600@gmai.com", "9234150847", "msidorenko7", DateTime.Now);

            // Создание проекта и добавление контакта
            Project project = new Project();
            project.Contacts.Add(contact);

            // Сохранение проекта в файл
            ProjectSerializer.SaveToFile(project, FileLoad);

            // Загрузка проекта из файла
            Project loadedProject = ProjectSerializer.LoadFromFile(FileLoad);

            // Отображение загруженных данных проекта (по желанию)
            foreach (var loadedContact in loadedProject.Contacts)
            {
                Console.WriteLine($"Загруженный контакт: {loadedContact.FullName}, {loadedContact.Email}, {loadedContact.PhoneNumber}, {loadedContact.Vk}, {loadedContact.DateOfBirth}");
            }

            Application.Run(new Form1());
        }
    }
}
