using System;
using System.Linq;
public static class Kata 
{
  public static bool XO (string input)
  {
    string lowerCase = input.ToLower();
    
    int countX = lowerCase.Count(x => x == 'x');
    int countO = lowerCase.Count(y => y == 'o');
    
    return countX == countO;
  }
}