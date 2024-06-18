namespace Assignment7._2._3_Are_2_Strings_Anagrams_of_Each_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "anagram";
            string word2 = "nagaram";

            if (IsAnagram(word1, word2))
            {
                Console.WriteLine($"{word1} and {word2} are anagrams");
            }
            else
            {
                Console.WriteLine($"{word1} and {word2} are not anagrams");
            }


        }

        static bool IsAnagram(string? w1, string? w2)
        {
            if (w1.Length != w2.Length)
            {
                return false;
            }
            else
            {
                w1 = w1.ToUpper();
                w2 = w2.ToUpper();

                char[] chars1 = w1.ToCharArray();
                char[] chars2 = w2.ToCharArray();

                SortArray(chars1);
                SortArray(chars2);

                string sortedWord1 = new string(chars1);
                string sortedWord2 = new string(chars2);

                return sortedWord1.Equals(sortedWord2);
            }
        }

        static void SortArray(char[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if ((arr[j] > arr[j + 1]))
                    {
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
