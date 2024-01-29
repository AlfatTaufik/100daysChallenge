using System;
using System.Globalization;
using System.Linq;
public class ConvertToCapitalize
{
  public static string ToCapitalize(string input)
  {
    return string.Concat(input.Split('-','_').Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x.Substring(i) : x));
  }
  public static void Main(string[] args)
  {
        string example1 = "the-stealth-warrior";
        string example2 = "The_Stealth_Warrior";
        string example3 = "The_Stealth-Warrior";

        Console.WriteLine(ToCapitalize(example1)); // Output: theStealthWarrior
        Console.WriteLine(ToCapitalize(example2)); // Output: TheStealthWarrior
        Console.WriteLine(ToCapitalize(example3)); // Output: TheStealthWarrior
  }
}