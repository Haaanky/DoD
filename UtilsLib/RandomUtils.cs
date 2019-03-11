using System;
using System.Collections.Generic;
using System.Text;

namespace UtilsLib
{
    public static class RandomUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int RandomGenerator(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }
        /// <summary>
        /// Generates a new random number between 0 and 100. 
        /// </summary>
        /// <param name="percentageValue">Value to check for</param>
        /// <returns></returns>
        public static bool CheckPercentage(int percentageValue)
        {
            Random random = new Random();

            if (random.Next(0, 100) < percentageValue)
                return true;
            else return false;
        }
    }
}