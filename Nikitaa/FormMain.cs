// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Windows.Forms;

namespace ScreenSaverApp
{
    public partial class FormMain : Form
    {
        private ScreenSaver screenSaver;

        public FormMain(int hours, int speed, int cloudCount)
        {
            InitializeComponent();

            screenSaver = new ScreenSaver(hours)
            {
                Speed = speed,
                MaxClouds = cloudCount
            };
        }

      
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain_SizeChanged(null, null);

            tmrMove.Start();
            screenSaver.Start();
        }
        private void FormMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pctMain_Paint(object sender, PaintEventArgs e)
        {
            if (screenSaver.IsWorking)
                screenSaver.Draw(e.Graphics);
        }
     

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            screenSaver.Update();

            pctMain.BackColor = screenSaver.CurrentBackgroundColor;

            pctMain.Refresh();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            screenSaver.Resize(Size);
        }
    }
}
