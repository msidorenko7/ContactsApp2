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
        /// <summary>
        /// Сохраняет данные проекта в файл.
        /// </summary>
        /// <param name="data">Данные проекта для сохранения.</param>
        /// <param name="fileload">Путь к файлу для сохранения.</param>
        public static void SaveToFile(Project data, string fileload)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(fileload))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// Загружает данные проекта из файла.
        /// </summary>
        /// <param name="fileload">Путь к файлу для загрузки.</param>
        /// <returns>Десериализованный объект проекта.</returns>
        public static Project LoadFromFile(string fileload)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(fileload))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<Project>(reader);
            }
        }
    }
}