// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.Constellations
{
    public class ConstellationBigBear : AbstractConstellation
    {
        public override Star[] Stars => new[]
        {
             new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+100 + RectangleLocation.Width / 10,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+100 + RectangleLocation.Width / 10+60,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10-50)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+100 + RectangleLocation.Width / 10+145,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10-50)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+100 + RectangleLocation.Width / 10+235,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10-50)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+100 + RectangleLocation.Width / 10+275,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 10+5)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X +100+ RectangleLocation.Width / 10+370,
                    RectangleLocation.Y +200+ RectangleLocation.Height / 10-25)
            }
            , new Star
            {
                Size = new Size(25, 25),
                Location = new PointF(
                    RectangleLocation.X+100 + RectangleLocation.Width / 10+355,
                    RectangleLocation.Y+200+ RectangleLocation.Height / 10-85)
            }
        };
    }
}
