using System;

namespace Solution
{
    public class Kata
    {
        public static char FindMissingLetter(char[] letters)
        {
            char missingLetter = '\0';

            for (int i = 0; i < letters.Length - 1; i++)
            {
                // Periksa apakah huruf berikutnya tidak berurutan
                if (letters[i + 1] != (char)(letters[i] + 1))
                {
                    // Temukan huruf yang hilang
                    missingLetter = (char)(letters[i] + 1);
                    break;
                }
            }

            return missingLetter;
        }
    }
}
