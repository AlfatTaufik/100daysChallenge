using System;
using System.Linq;

public class Persist 
{
	public static int Persistence(long n) 
	{
		// your code
    int count = 0;
    
    while(n >= 9){
      count++;
      n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x,y) => x * y);
    }
     return count;
	}
}