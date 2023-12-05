// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.Constellations
{
    public class ConstellationLittleBear : AbstractConstellation
    {
        public override Star[] Stars => new[]
        {
            new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 10,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 10-48,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10-13)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 10+9,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10-62)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 10-38,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10-71)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 10+35,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10-125)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X +200+ RectangleLocation.Width / 10+90,
                    RectangleLocation.Y +200+ RectangleLocation.Height / 10-153)
            }
            , new Star
            {
                Size = new Size(25, 25),
                Location = new PointF(
                    RectangleLocation.X+200 + RectangleLocation.Width / 10+150,
                    RectangleLocation.Y +200+ RectangleLocation.Height / 10-174)
            }
        };
    }
}
