// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSaverApp.Constellations
{
    public class ConstellationCepheus : AbstractConstellation
    {
        public override Star[] Stars => new[]
        {
            new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 20,
                    RectangleLocation.Y + RectangleLocation.Height / 20)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 20+105,
                    RectangleLocation.Y + RectangleLocation.Height / 20+120)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 20-50,
                    RectangleLocation.Y + RectangleLocation.Height / 20+160)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 20+25,
                    RectangleLocation.Y + RectangleLocation.Height /20+305)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 20+25,
                    RectangleLocation.Y+ RectangleLocation.Height / 20+325)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X +200+ RectangleLocation.Width / 20+140,
                    RectangleLocation.Y+ RectangleLocation.Height / 20+265)
            }
            , new Star
            {
                Size = new Size(25, 25),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 20+225,
                    RectangleLocation.Y+ RectangleLocation.Height / 20+260)
            }
        };
    }
}
