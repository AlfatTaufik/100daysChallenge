using System;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    str.ToLower();
    
    for(int i = 0; i < 26; i++){
      char letter = Convert.ToChar(i + 97);
        if(str.Contains(letter)){
          return true;
        }
    }
    return false;
  }
}