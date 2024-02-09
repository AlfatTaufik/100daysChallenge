public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        int nonZeroIndex = 0;

        // Move non-zero elements to the front
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[nonZeroIndex] = arr[i];
                nonZeroIndex++;
            }
        }

        // Fill the remaining positions with zeros
        for (int i = nonZeroIndex; i < arr.Length; i++)
        {
            arr[i] = 0;
        }

        return arr;
    }
}
