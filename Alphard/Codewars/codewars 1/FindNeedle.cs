using System;

public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        // Code goes here!
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] != null && haystack[i].ToString() == "needle")
            {
                return $"found the needle at position {i}";
            }
        }
        return "Not found needle";
    }
}
