using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Encoder
{
   public static class Loader
    {
        /// <summary>
        /// Путь для сохранения данных с формы 2
        /// </summary>
        public static string pathEncode = "Enc.data";

        /// <summary>
        /// Путь для сохранения данных с формы 3
        /// </summary>
        public static string pathDecode = "Dec.data";

        /// <summary>
        /// Сохранение
        /// </summary>
        public static void Save<Type>(Type dataSaver, string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, dataSaver);
            }
        }
        /// <summary>
        /// Загрузка сохранения
        /// </summary>
        public static DataSaver Upload(string path)
        {
            DataSaver dataSaver;
            if (File.Exists(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    dataSaver = (DataSaver)bf.Deserialize(fs);
                }
                return dataSaver;
            }
            else return new DataSaver(null, null, null);
        }
    }
}
