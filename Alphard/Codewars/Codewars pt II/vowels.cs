using System;
using System.Linq;

public static class Kata
{
    public static string Disemvowel(string str)
    {
      char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        
      string result = new string(str.Where(c => !vowels.Contains(c)).ToArray());
      return result;
    }
}