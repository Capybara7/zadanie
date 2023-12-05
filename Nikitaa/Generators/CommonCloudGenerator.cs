// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.Clouds;
using System.Drawing;

namespace ScreenSaverApp.Generators
{
    public class CommonCloudGenerator : AbstractGeneratorMove<CommonCloud>
    {
        public override double Possibility => 0.95 + 0.1 * (1.0 / (Speed+2));

        public override CommonCloud CreateItem()
        {
            return new CommonCloud
            {
                RectangleMove = new RectangleF
                       (0, 0, RectangleMove.Width, RectangleMove.Height),
                Speed = Speed
            };
        }
    }
}
