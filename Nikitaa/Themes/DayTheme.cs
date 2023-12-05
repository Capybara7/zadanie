// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.Backgrounds;
using ScreenSaverApp.Generators;
using ScreenSaverApp.SpaceLightObjects;
using System.Drawing;
using System.Linq;

namespace ScreenSaverApp.Themes
{
    public class DayTheme : AbstractTheme
    {
        protected override void DrawBefore(Graphics graphics)
        {
        }

        protected override void DrawAfter(Graphics graphics)
        {
            CommonCloudGenerator.Draw(graphics);
            RainyCloudGenerator.Draw(graphics);
        }

        public override LightMoveObject LightObject { get; } = new Sun();

        public override AbstractBackground Background { get; } = new DayBackground();

       // public RainyCloudGenerator RainyCloudGenerator { get; } = new RainyCloudGenerator();

        public override void Start()
        {
            base.Start();

            //RainyCloudGenerator.Items.Clear();
            //RainyCloudGenerator.Speed = LightObject.Speed;
            //RainyCloudGenerator.MaxItems = CommonCloudGenerator.MaxItems - CommonCloudGenerator.MaxItems / 2;
            //RainyCloudGenerator.RectangleMove = LightObject.RectangleMove;
        }

        public override void Update()
        {
            base.Update();

            CommonCloudGenerator.Update();
            RainyCloudGenerator.Update();

            CommonCloudGenerator.Move();
            RainyCloudGenerator.Move();
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
        }
    }
}
