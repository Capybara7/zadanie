// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.Constellations
{
    public class ConstellationSwan : AbstractConstellation
    {
        public override Star[] Stars => new[]
        {
            new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+50 + RectangleLocation.Width / 20,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20)
            }
            , new Star
            {
                Size = new Size(25, 25),
                Location = new PointF(
                    RectangleLocation.X+50 + RectangleLocation.Width / 20+130,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20-80)
            }
            , new Star
            {
                Size = new Size(25, 25),
                Location = new PointF(
                    RectangleLocation.X +50+ RectangleLocation.Width / 20+255,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20-150)
            }
            , new Star
            {
                Size = new Size(25, 25),
                Location = new PointF(
                    RectangleLocation.X+50 + RectangleLocation.Width / 20+155,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20-240)
            }
            , new Star
            {
                Size = new Size(25, 25),
                Location = new PointF(
                    RectangleLocation.X+50+ RectangleLocation.Width / 20+370,
                    RectangleLocation.Y+400+ RectangleLocation.Height / 20-230)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+50 + RectangleLocation.Width / 20+370,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20-80)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+50 + RectangleLocation.Width / 20+470,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X +50+ RectangleLocation.Width / 20+470,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20-305)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+50 + RectangleLocation.Width / 20+510,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20-335)
            }
            , new Star
            {
                Size = new Size(20, 20),
                Location = new PointF(
                    RectangleLocation.X+50+ RectangleLocation.Width / 20+555,
                    RectangleLocation.Y+400 + RectangleLocation.Height / 20-365)
            }
        };
    }
}
