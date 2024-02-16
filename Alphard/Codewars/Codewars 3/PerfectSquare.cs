using System;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        long squareRoot = (long)Math.Sqrt(num);

        if (squareRoot * squareRoot == num)
        {
            // num is a perfect square
            long nextNum = (squareRoot + 1) * (squareRoot + 1);
            return nextNum;
        }
        else
        {
            // num is not a perfect square
            return -1;
        }
    }
}
