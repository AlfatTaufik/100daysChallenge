/* Very simple, given a number (integer / decimal / both depending on the language), find its opposite (additive inverse). */

using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
            // Happy Coding
          return number < 0 ? Math.Abs(number) : -number;
        }
    }