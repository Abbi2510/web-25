using System;

namespace Assin_3__6_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "The Train leaves Every Morning at 5 AM.";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("Position of the word 'Train' in the said string: " + test(str1, "Train"));
            Console.WriteLine("Position of the word 'The' in the said string: " + test(str1, "The"));
            Console.WriteLine("Position of the word 'Morning' in the said string: " + test(str1, "Morning"));
        }
        public static int test(string text, string word)
        {
            return Array.IndexOf(text.Split(' '), word) + 1;
        }
    }
}
