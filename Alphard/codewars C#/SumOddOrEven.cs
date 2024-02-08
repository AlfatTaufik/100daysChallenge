using System;
using System.Linq;

public class Kata
{
  public static string OddOrEven(int[] array)
  {
    int sum = array.DefaultIfEmpty(0).Sum();
    return sum % 2 == 0 ? "even" : "odd";
  }
}