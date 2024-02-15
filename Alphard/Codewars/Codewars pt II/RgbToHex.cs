using System;

public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    r = Math.Max(0, Math.Min(255, r));
    g = Math.Max(0, Math.Min(255, g));
    b = Math.Max(0, Math.Min(255, b));
    
    return $"{r:X2}{g:X2}{b:X2}";
   // return null;
  }
}