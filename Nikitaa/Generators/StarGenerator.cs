// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.Constellations;
using System.Drawing;

namespace ScreenSaverApp.Generators
{
    public class StarGenerator : AbstractGeneratorMove<Star>
    {
        public override double Possibility => 0.55 + 0.1 * (1.0 / Speed);

        public override Star CreateItem()
        {
            return new Star
            {
                RectangleMove = new RectangleF
                       (0, 0, RectangleMove.Width, RectangleMove.Height),
                Speed = Speed
            };
        }

        public override void Update()
        {
            base.Update();
            
            foreach (var star in Items)
            {
                star.Pulsar();
            }
        }
    }
}
