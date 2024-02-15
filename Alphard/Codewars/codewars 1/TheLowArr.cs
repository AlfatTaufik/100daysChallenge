using System;
using System.Linq;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		Array.Sort(numbers);
    return numbers[0] + numbers[1];
	}
}