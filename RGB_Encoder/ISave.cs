﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Encoder
{
   /// <summary>
   /// Интерфейс для класса-хранителя данных формы
   /// </summary>
   public interface ISave
    {
        string text { set; get; }
        string path { set; get; }
        Image img { set; get; }
    }
}
