using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RGB_Encoder
{
   public class Coder
    {
        private PictureBox pictureBoxDecode;
        private RichTextBox richTextBoxDecode;
        private PictureBox pictureBoxEncode;
        private RichTextBox richTextBoxEncode;

        public Coder(PictureBox pictureBoxDecode, RichTextBox richTextBoxDecode, PictureBox pictureBoxEncode, RichTextBox richTextBoxEncode)
        {
            this.pictureBoxDecode = pictureBoxDecode;
            this.pictureBoxEncode = pictureBoxEncode;
            this.richTextBoxEncode = richTextBoxEncode;
            this.richTextBoxDecode = richTextBoxDecode;
        }
        /// <summary>
        /// Метод декодировки сообщения
        /// </summary>  
        public void Decode( )
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
        /// Метод кодировки сообщения 
        /// </summary>  
        public void Encode()
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

        public delegate void EncodeCheck();

        public void EncodeVithCheck(EncodeCheck encodeCheck)
        {
            if (pictureBoxEncode.Image != null)
            {
                try
                {
                    encodeCheck();
                }
                catch (ArgumentException ae)
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
    }
}
