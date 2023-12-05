// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Drawing;
using ScreenSaverApp.AbstractBaseObjects;

namespace ScreenSaverApp.SpaceLightObjects
{
    public class LightMoveObject : AbstractMoveImageObject
    {
        public double AngleOnScreen { get; set; }

        protected int Radius => (int)RectangleMove.Width / 2;

        protected PointF Center => new PointF
        {
            X = RectangleMove.X + (RectangleMove.Width / 2 - Size.Width / 2),
            Y = RectangleMove.Y + RectangleMove.Height
        };

        public override bool IsEndMove => Location.Y >= Center.Y;

        public override void Start()
        {
            AngleOnScreen = 9.6;
        }

        public override void Move()
        {
            Location = new PointF
            {
                X = Center.X + Radius * (float)Math.Cos(AngleOnScreen),
                Y = Center.Y + Radius * (float)Math.Sin(AngleOnScreen)
            };
            AngleOnScreen = AngleOnScreen + Speed * 0.001;
        }
    }
}
