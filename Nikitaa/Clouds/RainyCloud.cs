// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Collections.Generic;
using System.Drawing;

namespace ScreenSaverApp.Clouds
{
    public class RainyCloud : CommonCloud
    {
       

        private Image _image = null;
        public override Image Image
        {
            get
            {
                if (_image != null)
                    return _image;
                var pathsForImages = new[]
                {
                    "Images/rainy_cloud1.png",
                    "Images/rainy_cloud2.png",
                };
                return _image = Image.FromFile(pathsForImages[random.Next(pathsForImages.Length)]);
            }
        }

        protected virtual Brush BrushForDrop => new SolidBrush(Color.Blue);

        protected Size DropSize => new Size(4, 4);
        
        protected List<PointF> Drops = new List<PointF>();

        protected void RandomlyAddDrop()
        {
            const int maxDrops = 250;

            if (Drops.Count >= maxDrops)
                return;

            const double changeToAddConstellation = 0.4;
            if (random.NextDouble() >= changeToAddConstellation)
            {
                var drop = new PointF(random.Next(Size.Width), 0);
                Drops.Add(drop);
            }
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
        public override void Move()
        {
            base.Move();

            RandomlyAddDrop();

            for (var i = 0; i < Drops.Count; i++)
            {
                Drops[i] = new PointF(Drops[i].X, Drops[i].Y + Speed);
            }

            Drops.RemoveAll(x => x.Y >= (RectangleMove.Y + RectangleMove.Height));
        }

        public override void DrawImage(Graphics graphics)
        {
            foreach (var drop in Drops)
            {
                graphics.FillEllipse(BrushForDrop, 
                    Location.X + drop.X,
                    Location.Y + Size.Height + drop.Y, 
                    DropSize.Width, 
                    DropSize.Height);
            }

            base.DrawImage(graphics);
        }
    }
}
