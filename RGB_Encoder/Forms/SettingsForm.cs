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
        private SettingsForm()
        {
            InitializeComponent();
        }
        private static SettingsForm settingsForm;

        public static SettingsForm GetSettingsForm()
        {
            if(settingsForm==null)
            {
                settingsForm = new SettingsForm();
            }
            return settingsForm;
        }
        /// <summary>
        /// Сохранять ли данные перед выходом
        /// </summary>
        public static bool SaveWhenQuit = true;

        /// <summary>
        /// Переключатель состояния сохранять\не сохранять
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveWhenQuit == false)
                SaveWhenQuit = true;
            else
                SaveWhenQuit = false;

            MessageBox.Show(SaveWhenQuit.ToString());
        }

        /// <summary>
        /// Переход на главную форму
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }
    }
}
