using System;
using System.Collections.Generic;
using System.Linq;

class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        List<string> result = new List<string>();
        Permute(s.ToCharArray(), 0, s.Length - 1, result);
        return result.Distinct().ToList(); // Remove duplicates using Distinct
    }

    private static void Permute(char[] array, int left, int right, List<string> result)
    {
        if (left == right)
        {
            result.Add(new string(array));
        }
        else
        {
            for (int i = left; i <= right; i++)
            {
                Swap(ref array[left], ref array[i]);
                Permute(array, left + 1, right, result);
                Swap(ref array[left], ref array[i]); // Backtrack
            }
        }
    }

    private static void Swap(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }
}
