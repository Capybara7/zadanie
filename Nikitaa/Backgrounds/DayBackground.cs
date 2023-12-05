// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.Backgrounds
{
    public class DayBackground : AbstractBackground
    {
        public override Color From => Color.FromArgb(135, 206, 235);

        public override Color To => Color.FromArgb(54, 41, 58);
    }
}
