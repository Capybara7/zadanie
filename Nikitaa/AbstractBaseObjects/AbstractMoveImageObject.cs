// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.AbstractBaseObjects
{
    public abstract class AbstractMoveImageObject : AbstractImageObject
    {
        public virtual int Speed { get; set; } = 1;

        public virtual RectangleF RectangleMove { get; set; }

        public abstract bool IsEndMove { get; }

        public abstract void Move();

        public void Resize(Size newSize)
        {
            RectangleMove = new RectangleF(
                RectangleMove.X, RectangleMove.Y, newSize.Width, newSize.Height);
        }
    }
}
