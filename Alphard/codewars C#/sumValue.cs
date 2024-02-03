using System;

public static class Kata 
{
    public static int summation(int num)
    {
      //Code here
      int result = num;
      for(int i = 1; i < num; i++) {
        result += i;
      }
      return result;
    }
}