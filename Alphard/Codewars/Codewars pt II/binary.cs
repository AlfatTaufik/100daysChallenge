using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
   // your code ...
    int sum = a + b;
    string result = Convert.ToString(sum, 2);
    return result;
  }
}