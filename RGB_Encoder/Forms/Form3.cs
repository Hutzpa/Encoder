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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Buffer.form3 = this;
            DataSaver dataSaver = (DataSaver)Buffer.Upload(Buffer.pathDecode);
            Upload(dataSaver);
        }

        /// <summary>
        /// Открытие окна выбора картинки 
        /// </summary>
        private OpenFileDialog openFile = new OpenFileDialog();

        #region Элменты управления
        /// <summary>
        /// Выбор картинки для декодировки
        /// </summary> 
        private void button1_Click(object sender, EventArgs e)
        {
            openFile.Filter = "(*.jpg;*.png)|*.jpg;*.png;";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.Size = new Size(pictureBox1.Height, pictureBox1.Width);
                toolStripStatusLabel1.Text = openFile.FileName;
            }
        }

        /// <summary>
        /// Выход
        /// </summary>  
        private void button3_Click(object sender, EventArgs e)
        {
            if (Settings.SaveWhenQuit)
            {
                DataSaver dataSaver = new DataSaver(richTextBox1.Text, toolStripStatusLabel1.Text, pictureBox1.Image);
                Buffer.Save(dataSaver, Buffer.pathDecode);
            }
            Buffer.Exit();
        }

        /// <summary>
        /// Возвращение к первой форме
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Buffer.form1.Show();
        }

        /// <summary>
        /// Кодировка
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Выберите сначала картинку");
        }
#endregion

        /// <summary>
        /// Видимость надписи "Введите текст"
        /// </summary>
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        /// <summary>
        /// Занесение десериализованных данных
        /// </summary>
        private void Upload(DataSaver ds)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBox1.Text = ds.text;
            pictureBox1.Image = ds.img;
            toolStripStatusLabel1.Text = ds.path;
        }
    }

}

