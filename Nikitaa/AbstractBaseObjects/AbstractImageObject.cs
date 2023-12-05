// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.AbstractBaseObjects
{
    public abstract class AbstractImageObject
    {
        public virtual PointF Location { get; set; }

        public virtual Size Size { get; set; }

        public virtual Image Image { get; }

        public virtual void DrawImage(Graphics graphics)
        {
            graphics.DrawImage(Image, new RectangleF(Location.X, Location.Y, Size.Width, Size.Height));
        }

        public abstract void Start();

       // public abstract void Resize(Size newSize);
    }
}
