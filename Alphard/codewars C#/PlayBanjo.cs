using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    //Implement me
    var nama = name.ToLower();
    if(nama.StartsWith("r")) { 
      return $"{name} plays banjo";
    }
    else {
      return $"{name} does not play banjo";
    }
  }
}