using System.IO;

namespace FileTasks
{
    class Program
    {
        public static int TextLength(string path)
        {
            var content = File.ReadAllText(path);
            string[] content_arr = content.Trim().Split(' ');
            return content_arr.Length;
        }

        public static string LongestWord(string path)
        {
            var content = File.ReadAllText(path);
            string[] content_arr = content.Trim().Split(' ');
            int max = 0;
            string longest_word = "";
            for (int i = 0; i < content_arr.Length; i++)
            {
                char[] word = content_arr[i].ToCharArray();
                if (word.Length > max)
                {
                    max = content_arr[i].Length;
                    longest_word = content_arr[i];
                }
            }

            return longest_word;
        }
        static void Main(string[] args)
        {
            string path = @"C:\work\files\number_of_words.txt";

            // Task 1
            int string_length = TextLength(path);

            Console.WriteLine("Count of words: " + string_length);

            // Task 2
            string longest_word = LongestWord(path);

            Console.WriteLine("Longest Word: " + longest_word);
        }
    }
}
