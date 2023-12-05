// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.Backgrounds;
using ScreenSaverApp.Clouds;
using ScreenSaverApp.Constellations;
using ScreenSaverApp.SpaceLightObjects;
using ScreenSaverApp.Themes;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ScreenSaverApp
{
    public class ScreenSaver
    {
       
        private int _hours;
        
        private readonly AbstractTheme[] themes = new AbstractTheme[]
        {
            new DayTheme(),
            new NightTheme()
        };
        private int indexCurrentTheme = 0;
        public AbstractTheme CurrentTheme => themes[indexCurrentTheme];

        private readonly List<AbstractConstellation> constellations = new List<AbstractConstellation>();

        public Color CurrentBackgroundColor => CurrentTheme.Background.CurrentColor;
             
        public bool IsDay => CurrentTheme.LightObject is Sun;

        public bool IsNight => CurrentTheme.LightObject is Moon;
               
        public ScreenSaver(int hours)
        {
            indexCurrentTheme = hours >= 0 && hours < 12
                ? 1
                : 0;
            _hours = hours;
        }
        private static Random random = new Random();
        public int Speed { get; set; } = 15;
        public int MaxClouds { get; set; } = 10;

        public bool IsWorking = false;
        public void Resize(Size newSize)
        {
            foreach (var theme in themes)
            {
                theme.Resize(newSize);
            }
        }

        public void Start()
        {
            foreach (var theme in themes)
            {
                theme.CountClouds = MaxClouds;
                theme.LightObject.Speed = Speed;
                theme.Background.Speed = Speed;
            }

            CurrentTheme.Start();

            CurrentTheme.LightObject.AngleOnScreen = 9.6 + 0.001 * 240 * (_hours % 12);

            IsWorking = true;

        }

        public void Draw(Graphics graphics)
        {
            CurrentTheme.Draw(graphics);
        }

        public void Update()
        { 
            CurrentTheme.Update();

            if (CurrentTheme.LightObject.IsEndMove)
            {
                var cloudGenerator = CurrentTheme.CommonCloudGenerator;

                indexCurrentTheme = (indexCurrentTheme + 1) % themes.Length;
                CurrentTheme.CommonCloudGenerator = cloudGenerator;
                CurrentTheme.Start();
            }
        }
    }
}
