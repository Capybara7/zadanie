// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Drawing;
using ScreenSaverApp.AbstractBaseObjects;

namespace ScreenSaverApp.Clouds
{
    public class CommonCloud : AbstractMoveImageObject
    {
        protected static Random random = new Random();

        public override bool IsEndMove => Location.X >= (RectangleMove.X + RectangleMove.Width);

        private Size? _size = null;
        public override Size Size
        {
            get
            {
                if (_size != null)
                    return _size.Value;
                _size = new Size(random.Next(100, 250), random.Next(75, 150));
                return _size.Value;
            }
        }

        private Image _image = null;
        public override Image Image
        {
            get
            {
                if (_image != null)
                    return _image;
                var pathsForImages = new[]
                {
                    "Images/cloud1.png",
                    "Images/cloud2.png",
                    "Images/cloud3.png",
                };
                return _image = Image.FromFile(pathsForImages[random.Next(pathsForImages.Length)]);
            }
        }

        public override void Move()
        {
            Location = new PointF
            {
                X = Location.X + Speed,
                Y = Location.Y
            };
        }

        public override void Start()
        {
            var randY = random.Next((int)(RectangleMove.Height - RectangleMove.Y - Size.Height));

            Location = new PointF
            {
                X = RectangleMove.X,
                Y = randY
            };
        }
    }
}
