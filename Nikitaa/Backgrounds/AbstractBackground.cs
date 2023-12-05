// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Drawing;

namespace ScreenSaverApp.Backgrounds
{
    public abstract class AbstractBackground
    {
        protected Color FadeToColor()
        {
            var r = (int)(To.R * Percent + From.R * (1f - Percent));
            var g = (int)(To.G * Percent + From.G * (1f - Percent));
            var b = (int)(To.B * Percent + From.B * (1f - Percent));
            return Color.FromArgb(r, g, b);
        }
      
        public void Start()
        {
            Percent = 0;
        }

        public void Update()
        {
            try
            {
                CurrentColor = FadeToColor();
            }
            catch
            { }

            Percent += 0.0003f * Speed;
        } 
        public abstract Color From { get; }

        public abstract Color To { get; }

        public double Percent { get; protected set; }

        public Color CurrentColor { get; protected set; }

        public int Speed { get; set; }
    }
}
