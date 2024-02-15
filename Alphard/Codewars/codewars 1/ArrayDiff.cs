using System;
using System.Linq;
public class ArrayDiff
{
  public static void Main()
  {
    string[] buah = { "Apel", "Jeruk", "Mangga", "Anggur", "Pisang", "Jambu" };
    string[] buah2 = { "Apel", "Jeruk", "Nanas", "Pisang" };
    // Balikin balikin = new Balikin();
    // Console.WriteLine($"{balikin()}")
    string[] hasil = Balikin.Tuker(buah, buah2);
    // Console.WriteLine($"{hasil}");
    foreach (var satu in hasil)
    {
      Console.WriteLine(satu);
    }
  }
}
// string[] fruits = {""}

public class Balikin
{
  public static string[] Tuker(string[] a, string[] b)
  {
    return a.Where(a => !b.Contains(a)).ToArray();
  }
}