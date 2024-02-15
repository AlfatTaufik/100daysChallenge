// Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of 
// �
// 3
// n 
// 3
//  , the cube above will have volume of 
// (
// �
// −
// 1
// )
// 3
// (n−1) 
// 3
//   and so on until the top which will have a volume of 
// 1
// 3
// 1 
// 3
//  .

// You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?



using System;

class Program
{
    static void Main()
    {
        // Contoh penggunaan
        Console.WriteLine(findNb(1071225));         // Output: 45
        Console.WriteLine(findNb(91716553919377)); // Output: -1
    }

    static long findNb(long m)
    {
        long n = 0;
        long volume = 0;

        // Menghitung jumlah kubus hingga total volume m tercapai
        while (volume < m)
        {
            n++;
            volume += (long)Math.Pow(n, 3);
        }

        // Memeriksa apakah total volume m tercapai
        return volume == m ? n : -1;
    }
}
