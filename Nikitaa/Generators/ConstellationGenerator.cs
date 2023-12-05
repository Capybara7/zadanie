// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using ScreenSaverApp.Constellations;
using System;

namespace ScreenSaverApp.Generators
{
    public class ConstellationGenerator : AbstractGenerator<AbstractConstellation>
    {
        private static Random random = new Random();

        public override double Possibility => 0.1;

        public override AbstractConstellation CreateItem()
        {
            var constellations = new AbstractConstellation[]
            {
                new ConstellationBigBear(),
                new ConstellationCassiopea(),
                new ConstellationCepheus(),
                new ConstellationLittleBear(),
                new ConstellationSwan()
            };

            foreach (var item in constellations)
            {
                item.RectangleArea = RectangleMove;

                item.Start();
            }

            return constellations[random.Next(constellations.Length)];
        }

        public override void Update()
        {
            RandomlyAddItem();

            foreach (var item in Items)
            {
                foreach (var star in item.Stars)
                {
                    star.Pulsar();
                }
            }
        }
    }
}
