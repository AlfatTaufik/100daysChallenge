using System;
using System.Linq;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    // Code on you crazy diamond!
    return str.ToLower().Distinct().Count()==str.Length;
  }
}