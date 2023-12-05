// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;

namespace ScreenSaverApp.Extensions
{
    public static class RandomExtensions
    {
        private static Random _random = new Random();

        public static bool RollDice(this Random random, double chance)
        {
            return _random.NextDouble() >= chance;
        }
    }
}
