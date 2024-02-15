using System;

public class Kata
{
  public static string Add(string a, string b)
  {
    long numA = int.Parse(a);
    long numB = int.Parse(b);
    long result = numA + numB;
    
    return result.ToString(); // Fix this!
  }
}