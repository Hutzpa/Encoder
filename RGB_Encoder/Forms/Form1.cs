using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Encoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Buffer.form1 = this;
        }

        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        private SettingsForm settingsForm = new SettingsForm();

        /// <summary>
        /// Открытие формы для кодировки
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            Hide();
        }

        /// <summary>
        /// Открытие формы для декодировки
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            form3.Show();
            Hide();
        }

        /// <summary>
        /// Настройки
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            Hide();
        }

        /// <summary>
        /// Выход
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            Buffer.Exit();
        }

    }
}
