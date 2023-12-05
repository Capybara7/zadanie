// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Windows.Forms;

namespace ScreenSaverApp
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var form = new FormMain((int)numericUpDown1.Value, trackBar1.Value, trackBar2.Value);
            form.ShowDialog();
            Close();
        }
    }
}
