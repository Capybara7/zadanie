// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.AbstractBaseObjects;
using System;
using System.Drawing;

namespace ScreenSaverApp.Constellations
{
    public abstract class AbstractConstellation : AbstractImageObject
    {
        

        public override Image Image => Image.FromFile("Images/star.png");

        public abstract Star[] Stars { get; }

        public virtual RectangleF RectangleArea { get; set; }

        public virtual RectangleF RectangleLocation { get; set; }

        public virtual int SpeedGrow { get; set; } = 1;

        public override void DrawImage(Graphics graphics)
        {
            foreach (var star in Stars)
            {
                star.DrawImage(graphics);
            }
        }

        //public override void Resize(Size newSize)
        //{
        //}
        protected static Random random = new Random();
        public override void Start()
        {
            var rectangleLocationWidth = 150 + random.Next((int)(RectangleArea.Width - RectangleArea.X - 150));
            var rectangleLocationHeight = 150 + random.Next((int)(RectangleArea.Height - RectangleArea.Y - 150));
            RectangleLocation = new RectangleF
            {
                X = RectangleArea.X + random.Next((int)RectangleArea.Width - rectangleLocationWidth),
                Y = RectangleArea.Y + random.Next((int)RectangleArea.Height - rectangleLocationHeight),
                Width = rectangleLocationWidth,
                Height = rectangleLocationHeight,
            };
        }
    }
}
