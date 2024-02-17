public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            // Menghitung jumlah elemen di sebelah kiri indeks
            for (int j = 0; j < i; j++)
            {
                leftSum += arr[j];
            }

            // Menghitung jumlah elemen di sebelah kanan indeks
            for (int k = i + 1; k < arr.Length; k++)
            {
                rightSum += arr[k];
            }

            // Memeriksa apakah jumlah di sebelah kiri sama dengan jumlah di sebelah kanan
            if (leftSum == rightSum)
            {
                return i;
            }
        }

        // Jika tidak ada indeks yang memenuhi kriteria
        return -1;
    }
}
