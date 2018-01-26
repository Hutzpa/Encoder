using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace RGB_Encoder
{
    public class Buffer
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
        /// Ссылка для управления формой 1
        /// </summary>
        public static Form1 form1;

        /// <summary>
        /// Ссылка для управления формой 2
        /// </summary>
        public static Form2 form2;

        /// <summary>
        /// Ссылка для управления формой 3
        /// </summary>
        public static Form3 form3;

        /// <summary>
        /// Обычный выход
        /// </summary>
        public static void Exit()
        {
            if (form1 != null)
                form1.Close();
            if (form2 != null)
                form2.Close();
            if (form3 != null)
                form3.Close();
        }

        public static void Save(DataSaver dataSaver,string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, dataSaver);
            }
        }

        public static ISave Upload(string path)
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
