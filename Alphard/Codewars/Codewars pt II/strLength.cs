using System;
using System.Linq;

public class Kata
{
  public static string[] AddLength(string str)
  {
    // TODO
    return str.Split(" ").Select(x => $"{x} {x.Length}").ToArray();
  }
}