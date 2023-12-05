// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.Constellations
{
    public class ConstellationCassiopea : AbstractConstellation
    {
        public override Star[] Stars => new[]
        {
            new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X + RectangleLocation.Width / 20,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 20)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X + RectangleLocation.Width / 20+95,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 20+90)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X + RectangleLocation.Width / 20+210,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 20+50)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X + RectangleLocation.Width / 20+310,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 20+115)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X + RectangleLocation.Width / 20+415,
                    RectangleLocation.Y+200 + RectangleLocation.Height / 20+60)
            }
        };
    }
}
