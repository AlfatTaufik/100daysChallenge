using System;
using System.Linq;

public class SplitString
{
  public static string[] Solution(string str)
  {
     return Enumerable.Range(0, (int)Math.Ceiling((double)str.Length / 2)).Select(x => x == str.Length / 2 ? str.Substring(x * 2) + "_" : str.Substring(x * 2, 2)).ToArray();
  }
}