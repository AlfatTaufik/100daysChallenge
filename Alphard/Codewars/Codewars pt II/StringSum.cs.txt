using System;
using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      BigInteger aInt;
      BigInteger bInt;
      
      BigInteger.TryParse(a, out aInt);
      BigInteger.TryParse(b, out bInt);
      
      return (aInt + bInt).ToString();
    }
}