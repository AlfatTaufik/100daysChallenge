sing System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static int Solve(string s)
  {
    if (s == null)
    {
      throw new ArgumentNullException();
    }
    return Regex.Split(s, @"[a-z]+")
                .Where(str => !String.IsNullOrEmpty(str))
                .Select(Int32.Parse)
                .Max();
  }
}