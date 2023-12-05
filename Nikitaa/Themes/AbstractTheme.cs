// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.Backgrounds;
using ScreenSaverApp.Generators;
using ScreenSaverApp.SpaceLightObjects;
using System.Drawing;

namespace ScreenSaverApp.Themes
{
    public abstract class AbstractTheme
    {
        protected abstract void DrawBefore(Graphics graphics);

        protected abstract void DrawAfter(Graphics graphics);

        public abstract LightMoveObject LightObject { get; }

        public abstract AbstractBackground Background { get; }

        public CommonCloudGenerator CommonCloudGenerator { get; set; } = new CommonCloudGenerator();

        public RainyCloudGenerator  RainyCloudGenerator { get; set; } = new RainyCloudGenerator();
        public int CountClouds { get; set; }

        public virtual void Start()
        {
            CommonCloudGenerator.Speed = LightObject.Speed;
            CommonCloudGenerator.MaxItems = CountClouds;
            CommonCloudGenerator.RectangleMove = LightObject.RectangleMove;
            RainyCloudGenerator.Speed = LightObject.Speed;
            RainyCloudGenerator.MaxItems = CommonCloudGenerator.MaxItems - CommonCloudGenerator.MaxItems / 2;
            RainyCloudGenerator.RectangleMove = LightObject.RectangleMove;

            LightObject.Start();
            Background.Start();
        }

        public virtual void Update()
        {
            Background.Update();
            LightObject.Move();
        }

        public virtual void Draw(Graphics graphics)
        {
            DrawBefore(graphics);
            LightObject.DrawImage(graphics);
            DrawAfter(graphics);
        }

        public virtual void Resize(Size newSize)
        {
            LightObject.Resize(newSize);
        }
    }
}
