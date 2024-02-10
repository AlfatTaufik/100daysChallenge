using System;

public class Kata
{
  public static string Rot13(string input)
  {
       char[] result = input.ToCharArray();

    for (int i = 0; i < result.Length; i++)
    {
        if (char.IsLetter(result[i]))
        {
            char baseChar = char.IsUpper(result[i]) ? 'A' : 'a';
            result[i] = (char)((result[i] - baseChar + 13) % 26 + baseChar);
        }
    }

    return new string(result);
  }
}