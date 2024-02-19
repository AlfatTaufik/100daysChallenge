using System;

public class Kata
{
  public static int CountBits(int n)
  {
    string binary = Convert.ToString(n, 2);
    int amount = 0;
    
    foreach(char num in binary) {
      int parseInt = int.Parse(num.ToString());
        if(parseInt == 1){
          amount += 1;
      }
    }
      return amount;
  }
}