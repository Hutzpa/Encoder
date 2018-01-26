using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Encoder
{
    [Serializable]
    public class DataSaver : ISave
    {
        public string text { get; set; }
        public string path { get; set; }
        public Image img { get; set; }

       public DataSaver(string text, string path,Image img)
        {
            this.text = text;
            this.path = path;
            this.img = img;
        }
    }
}
