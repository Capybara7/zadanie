// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.AbstractBaseObjects;
using ScreenSaverApp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ScreenSaverApp.Generators
{
    public abstract class AbstractGenerator<T> where T : AbstractImageObject
    {
        protected void RandomlyAddItem()
        {
            if (Items.Count >= MaxItems)
                return;

            if ((new Random()).RollDice(Possibility))
            {
                var item = CreateItem();
                item.Start();
                Items.Add(item);
            }
        }

        public abstract T CreateItem();

        public abstract double Possibility { get; }

        public int MaxItems { get; set; }

        public List<T> Items { get; } = new List<T>();

        public RectangleF RectangleMove { get; set; }
        public void Draw(Graphics graphics)
        {
            foreach (var item in Items)
            {
                item.DrawImage(graphics);
            }
        }

        public abstract void Update();
    }
}
