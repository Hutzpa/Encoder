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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переключатель состояния сохранять\не сохранять
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings.SaveWhenQuit == false)
                Settings.SaveWhenQuit = true;
            else
                Settings.SaveWhenQuit = false;
        }

        /// <summary>
        /// Переход на главную форму
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Buffer.form1.Show();
            Hide();
        }
    }
}
