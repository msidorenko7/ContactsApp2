using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class ProjectSerializer
    {
        // <summary>
        /// Свойство пути к файлу
        /// </summary>
        public string Filename { get; set; }



        /// <summary>
        /// Сохранение данных в файл
        /// </summary>
        /// <param name="project"></param>
        public void SaveToFile(Project project)
        {
            Filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mikhail\\ContactsApp";
            JsonSerializer serializer = new JsonSerializer();
            if (Directory.Exists(Filename) == false)
            {
                Directory.CreateDirectory(Filename);
            }

            using (StreamWriter streamWriter = new StreamWriter(Filename + "\\data.txt"))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Загрузка в проект данные из файла
        /// </summary>
        /// <returns></returns>
        public Project LoadFromFile()
        {
            Filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            + "\\Mikhail\\ContactsApp";
            JsonSerializer serializer = new JsonSerializer();

            Project project = null;

            try
            {
                using (StreamReader sr = new StreamReader(Filename + "\\data.txt"))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                    project = serializer.Deserialize<Project>(reader);
                }

                return project ?? new Project();

            }
            catch
            {
                return new Project();
            }
        }
    }
}