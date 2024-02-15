using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    var pattern = @"^(?:\d{4}|\d{6})$";
    bool count = Regex.IsMatch(pin, pattern);
    if(count && !pin.Contains(Environment.NewLine))
      {
      return true;
      }
      else{
      return false;
      }
  }
}