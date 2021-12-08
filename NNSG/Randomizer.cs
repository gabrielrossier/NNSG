﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    public class Randomizer 
    {
        private static Random randNumber = new Random();

        public static bool Probability(float chances)
        {
            int number = randNumber.Next(0, 100);
            return number < chances;
        }

        public static int Range(int from, int to ) //To is exclusive
        {
            return randNumber.Next(from, to);
        }

    }
}