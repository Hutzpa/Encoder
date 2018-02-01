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
            openFileEncode = new OpenFileDialog();
            openFileEncode.Filter = "(*.jpg;*.png)|*.jpg;*.png;";
            openFileDecode = new OpenFileDialog();
            openFileDecode.Filter = "(*.jpg;*.png)|*.jpg;*.png;";
            coder = new Coder(pictureBoxDecode, richTextBoxDecode, pictureBoxEncode, richTextBoxEncode);
        }
        private Coder coder;
        /// <summary>
        /// Обхект формы настроек
        /// </summary>
        private SettingsForm settingsForm;
        /// <summary>
        /// Обхект дилогового окна 
        /// </summary>
        private OpenFileDialog openFileEncode;
  
        /// <summary>
        /// Нажание на кнопку "Загрузить картинку" для декодировки
        /// </summary> 
        private void buttonUploadEncode_Click(object sender, EventArgs e)
        {
            if (openFileEncode.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEncode.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxEncode.Image = Image.FromFile(openFileEncode.FileName);
                pictureBoxEncode.Size = new Size(pictureBoxEncode.Height, pictureBoxEncode.Width);
                labelPathEncode.Text = openFileEncode.FileName;
            }
        }

        /// <summary>
        /// Нажание на кнопку "КодироватЬ"
        /// </summary> 
        private void buttonEncode_Click(object sender, EventArgs e)
        {
            coder.EncodeVithCheck(coder.Encode);
        }

        /// <summary>
        /// Обхект дилогового окна 
        /// </summary>
        private OpenFileDialog openFileDecode;

        /// <summary>
        /// Нажание на кнопку "Загрузить картинку" для декодировки
        /// </summary> 
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDecode.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDecode.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxDecode.Image = Image.FromFile(openFileDecode.FileName);
                pictureBoxDecode.Size = new Size(pictureBoxDecode.Height, pictureBoxDecode.Width);
                labelPathDecode.Text = openFileDecode.FileName;
            }
        }

        /// <summary>
        /// Нажание на кнопку "ДекодироватЬ"
        /// </summary> 
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBoxDecode.Image != null)
                coder.Decode();
            else
                MessageBox.Show("Выберите сначала картинку");
        }

        /// <summary>
        /// Кнопка вызова формы настроек 
        /// </summary> 
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm = SettingsForm.GetSettingsForm();
            settingsForm.Show();
        }

        /// <summary>
        /// Кнопка "Выход"
        /// </summary>  
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SettingsForm.SaveWhenQuit)
            {
                DataSaver dataSaverEncode = new DataSaver(richTextBoxEncode.Text, labelPathEncode.Text, pictureBoxEncode.Image);
                Loader.Save(dataSaverEncode, Loader.pathEncode);
                DataSaver dataSaverDecode = new DataSaver(richTextBoxDecode.Text, labelPathDecode.Text, pictureBoxDecode.Image);
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
            labelPathEncode.Text = dataSaver.path;
            pictureBoxEncode.Image = dataSaver.img;
        }

        /// <summary>
        /// Метод обновления данных полей отвечающих за декодировку
        /// </summary>  
        private void UpdateDecode(DataSaver dataSaver)
        {
            pictureBoxDecode.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBoxDecode.Text = dataSaver.text;
            labelPathDecode.Text = dataSaver.path;
            pictureBoxDecode.Image = dataSaver.img;
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
            labelPathEncode.Text = "";
            labelPathDecode.Text = "";
        }

       
    }
}
