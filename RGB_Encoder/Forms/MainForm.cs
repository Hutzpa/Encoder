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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DataSaver dataEncode = (DataSaver)Loader.Upload(Loader.pathEncode);
            UpdateEncode(dataEncode);
            DataSaver dataDecode = (DataSaver)Loader.Upload(Loader.pathDecode);
            UpdateDecode(dataDecode);
        }
        /// <summary>
        /// Обхект формы настроек
        /// </summary>
        private SettingsForm settingsForm = new SettingsForm();
        /// <summary>
        /// Обхект дилогового окна 
        /// </summary>
        private OpenFileDialog openFileEncode = new OpenFileDialog();

        /// <summary>
        /// Нажание на кнопку "Загрузить картинку" для декодировки
        /// </summary> 
        private void buttonUploadEncode_Click(object sender, EventArgs e)
        {
            openFileEncode.Filter = "(*.jpg;*.png)|*.jpg;*.png;";

            if (openFileEncode.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEncode.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxEncode.Image = Image.FromFile(openFileEncode.FileName);
                pictureBoxEncode.Size = new Size(pictureBoxEncode.Height, pictureBoxEncode.Width);
                label3.Text = openFileEncode.FileName;
            }
        }

        /// <summary>
        /// Нажание на кнопку "КодироватЬ"
        /// </summary> 
        private void buttonEncode_Click(object sender, EventArgs e)
        {
            if (pictureBoxEncode.Image != null)
            {
                try
                {
                    Encode();
                }
                catch(ArgumentException ae)
                {
                    MessageBox.Show("NO RUSSIAN");
                    Clipboard.SetText(richTextBoxEncode.Text);
                    richTextBoxEncode.Text = null;
                    MessageBox.Show("Текст скопирован в буфер обмена, к кодировке пригоден только латинский алфавит");

                }
            }
            else
                MessageBox.Show("Select image first");
        }

        /// <summary>
        /// Обхект дилогового окна 
        /// </summary>
        private OpenFileDialog openFileDecode = new OpenFileDialog();

        /// <summary>
        /// Нажание на кнопку "Загрузить картинку" для декодировки
        /// </summary> 
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDecode.Filter = "(*.jpg;*.png)|*.jpg;*.png;";

            if (openFileDecode.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDecode.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxDecode.Image = Image.FromFile(openFileDecode.FileName);
                pictureBoxDecode.Size = new Size(pictureBoxDecode.Height, pictureBoxDecode.Width);
                label4.Text = openFileDecode.FileName;
            }
        }

        /// <summary>
        /// Нажание на кнопку "ДекодироватЬ"
        /// </summary> 
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBoxDecode.Image != null)
                Decode();
            else
                MessageBox.Show("Выберите сначала картинку");
        }

        /// <summary>
        /// Кнопка вызова формы настроек 
        /// </summary> 
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
        }

        /// <summary>
        /// Кнопка "Выход"
        /// </summary>  
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsForm.SaveWhenQuit)
            {
                DataSaver dataSaverEncode = new DataSaver(richTextBoxEncode.Text, label3.Text, pictureBoxEncode.Image);
                Loader.Save(dataSaverEncode, Loader.pathEncode);
                DataSaver dataSaverDecode = new DataSaver(richTextBoxDecode.Text, label4.Text, pictureBoxDecode.Image);
                Loader.Save(dataSaverDecode, Loader.pathDecode);
            }
           Close();
        }

        /// <summary>
        /// Метод обновления данных полей отвечающих за кодировку
        /// </summary>  
        private void UpdateEncode(DataSaver dataSaver)
        {
            pictureBoxEncode.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBoxEncode.Text = dataSaver.text;
            label3.Text = dataSaver.path;
            pictureBoxEncode.Image = dataSaver.img;
        }

        /// <summary>
        /// Метод обновления данных полей отвечающих за декодировку
        /// </summary>  
        private void UpdateDecode(DataSaver dataSaver)
        {
            pictureBoxDecode.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBoxDecode.Text = dataSaver.text;
            label4.Text = dataSaver.path;
            pictureBoxDecode.Image = dataSaver.img;
        }

        /// <summary>
        /// Метод кодировки сообщения 
        /// </summary>  
        private void Encode()
        {
            Bitmap img = new Bitmap(pictureBoxEncode.Image);

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color pixel = img.GetPixel(j, i);
                    if (i < 1 && j < richTextBoxEncode.TextLength)
                    {
                        char letter = Convert.ToChar(richTextBoxEncode.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }

                }
            }
            Color color = img.GetPixel(img.Width - 1, img.Height - 1);
            img.SetPixel(img.Width - 1, img.Height - 1, Color.FromArgb(color.R, color.G, richTextBoxEncode.TextLength));
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.jpg;*.png)|*.jpg;*.png;";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                img.Save(saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Метод декодировки сообщения
        /// </summary>  
        private void Decode()
        {
            Bitmap img = new Bitmap(pictureBoxDecode.Image);
            string mesg = "";
            Color lastPixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int mesLenght = lastPixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < mesLenght)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                        mesg += letter;
                    }

                }
            }

            richTextBoxDecode.Text = mesg;
        }

        /// <summary>
        /// Кнопка "Очистить"
        /// </summary>     
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxDecode.Text = "";
            richTextBoxEncode.Text = "";
            pictureBoxDecode.Image = null;
            pictureBoxEncode.Image = null;
            label3.Text = "";
            label4.Text = "";
        }
    }
}
