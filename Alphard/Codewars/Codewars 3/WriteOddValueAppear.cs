using System;
using System.Linq;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) {
    int result = 0;
    foreach(int num in seq){
      result ^= num;
    }
    return result;
    }
    }
}