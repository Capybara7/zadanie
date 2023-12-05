// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.AbstractBaseObjects;
using ScreenSaverApp.Extensions;
using System;
using System.Drawing;

namespace ScreenSaverApp.Constellations
{
    public class Star : AbstractMoveImageObject
    {
        protected static Random random = new Random();

        public bool IsMove { get; protected set; } = false;

        public override Image Image => Image.FromFile("Images/star.png");

        public override bool IsEndMove => Location.Y >= (RectangleMove.Y + RectangleMove.Height);

        public virtual int SpeedGrow { get; set; } = 1;

        public override void Start()
        {
            Size = new Size(10, 10);

            var rectangleLocationWidth = random.Next((int)(RectangleMove.Width - RectangleMove.X - 150));
            var rectangleLocationHeight = random.Next((int)(RectangleMove.Height - RectangleMove.Y - 150));
            
            Location = new PointF
            {
                X = RectangleMove.X + random.Next((int)RectangleMove.Width - rectangleLocationWidth),
                Y = RectangleMove.Y + random.Next((int)RectangleMove.Height - rectangleLocationHeight)
            };
        }

        public override void Move()
        {
            if (!IsMove)
                return;

            Location = new PointF
            {
                X = Location.X,
                Y = Location.Y + 1 * Speed
            };
        }

        public void Pulsar()
        {
            const double chanceToGrow = 0.9;
            if ((new Random()).RollDice(chanceToGrow))
            {
                if ((new Random()).RollDice(0.5))
                    if (Size.Width > 5)
                        Size = new Size(Size.Width - 1 * SpeedGrow, Size.Height - 1 * SpeedGrow);
                    else
                        { }
                else if (Size.Width < 15)
                    Size = new Size(Size.Width + 1 * SpeedGrow, Size.Height + 1 * SpeedGrow);
            }

            if (!IsMove)
            {
                const double changeToMove = 0.999;
                if ((new Random()).RollDice(changeToMove))
                {
                    IsMove = true;
                }
            }
        }
    }
}
