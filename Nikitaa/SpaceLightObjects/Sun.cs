// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.SpaceLightObjects
{
    public class Sun : LightMoveObject
    {
        public override Image Image => Image.FromFile("Images/sun.png");

        public override Size Size => new Size(75, 75);
    }
}
