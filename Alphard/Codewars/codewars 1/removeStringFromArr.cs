using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      List<int> newInt = listOfItems.OfType<int>().ToList();
     return newInt;
   }
}
