// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.Clouds;
using System.Drawing;

namespace ScreenSaverApp.Generators
{
    public class RainyCloudGenerator : AbstractGeneratorMove<RainyCloud>
    {
        public override double Possibility => 0.99;

        public override RainyCloud CreateItem()
        {
            return new RainyCloud
            {
                RectangleMove = new RectangleF
                       (0, 0, RectangleMove.Width, RectangleMove.Height),
                Speed = Speed
            };
        }
    }
}
