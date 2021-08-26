using System;
using System.Linq;
namespace Assin_3__9_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C# Exercises";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("\nReverse all the words of the said string which have even length.:\n" + test(str1));
            str1 = "C# is used to develop web apps , desktop apps , mobile apps , games and much more.";
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("\nReverse all the words of the said string which have even length.:\n" + test(str1));
        }
        public static string test(string text)
        {
            return string.Join(" ", text.Split(' ').Select(str => str.Length % 2 != 0 ? str : new String(str.Reverse().ToArray())));
        }
    }
}
