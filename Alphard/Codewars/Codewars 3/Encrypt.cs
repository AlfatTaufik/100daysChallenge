using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    word.ToLower();
    
    Dictionary<char, int> charCount = new Dictionary<char, int>();
      foreach(char c in word) {
        if(charCount.ContainsKey(c)){
          charCount[c]++;
        }
        else{
          charCount[c] = 1;
        }
      }
    return new string(word.Select(c => charCount[c] > 1 ? ')' : '(' ).ToArray());
  }
}