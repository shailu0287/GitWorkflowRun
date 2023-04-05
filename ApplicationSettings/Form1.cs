using ApplicationSettings.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ReadSettings()
        {
            Settings s = new Settings();
            label3.Text = Properties.Settings.Default.ApplicationName;
            label4.Text = Properties.Settings.Default.SettingFrom;
            label5.Text = Properties.Settings.Default.TestSetting;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadSettings();
        }
    }
}
