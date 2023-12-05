// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.Backgrounds;
using ScreenSaverApp.Clouds;
using ScreenSaverApp.Constellations;
using ScreenSaverApp.Generators;
using ScreenSaverApp.SpaceLightObjects;
using System.Drawing;
using System.Linq;

namespace ScreenSaverApp.Themes
{
    public class NightTheme : AbstractTheme
    {
        protected override void DrawBefore(Graphics graphics)
        {
        }

        protected override void DrawAfter(Graphics graphics)
        {
            StarGenerator.Draw(graphics);
            ConstellationGenerator.Draw(graphics);
            CommonCloudGenerator.Draw(graphics);
            RainyCloudGenerator.Draw(graphics);
        }

        public override LightMoveObject LightObject { get; } = new Moon();

        public override AbstractBackground Background { get; } = new NightBackground();

        public StarGenerator StarGenerator { get; } = new StarGenerator();

        //public RainyCloudGenerator RainyCloudGenerator { get; } = new RainyCloudGenerator();

        public ConstellationGenerator ConstellationGenerator { get; } = new ConstellationGenerator();

        public override void Start()
        {
            base.Start();

            StarGenerator.Items.Clear();
            StarGenerator.Speed = LightObject.Speed;
            StarGenerator.MaxItems = 50;
            StarGenerator.RectangleMove = LightObject.RectangleMove;

            //RainyCloudGenerator.Items.Clear();
            //RainyCloudGenerator.Speed = LightObject.Speed;
            //RainyCloudGenerator.MaxItems = CommonCloudGenerator.MaxItems - CommonCloudGenerator.MaxItems / 2;
            //RainyCloudGenerator.RectangleMove = LightObject.RectangleMove;

            ConstellationGenerator.Items.Clear();
            ConstellationGenerator.MaxItems = 1;
            ConstellationGenerator.RectangleMove = LightObject.RectangleMove;
        }

        public override void Update()
        {
            base.Update();

            CommonCloudGenerator.Update();
            RainyCloudGenerator.Update();
            StarGenerator.Update();
            ConstellationGenerator.Update();

            CommonCloudGenerator.Move();
            RainyCloudGenerator.Move();
            StarGenerator.Move();
        }


        public override void Resize(Size newSize)
        {
            base.Resize(newSize);

            foreach (var cloud in CommonCloudGenerator.Items)
            {
                cloud.Resize(newSize);
            }
            foreach (var cloud in RainyCloudGenerator.Items)
            {
                cloud.Resize(newSize);
            }
            foreach (var star in StarGenerator.Items)
            {
                star.Resize(newSize);
            }
        }
    }
}
