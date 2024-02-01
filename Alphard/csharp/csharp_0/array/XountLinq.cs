using System;
using System.Linq;
namespace Solution
{
  class Kata
    {
        public static void Main(string[] args) {
            int[] arr = {0,0,1,1};
            var hasil = binaryArrayToNumber(arr);
            Console.WriteLine(hasil);
        }
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          //Code here
        var binaryStr = BinaryArray.ToString().Split();
        string combinedString = string.Join("", binaryStr);
        int result = Convert.ToInt32(combinedString, 2);
        return result;
        }
    }
}

