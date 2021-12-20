using System;
using System.Linq;

namespace Task.N1
{
    class Program
    {
        public static void RunTask1(string[] args)
        {
            Console.Write("Enter Text: ");
            var input = Console.ReadLine();
            if (IsPalindrome(input))
            {
                Console.WriteLine("Your text is a Palindrome");
            }
            else
            {
                Console.WriteLine("Your text is not a Palindrome");
            }
        }
        public static bool IsPalindrome(string text)
        {
            return text.SequenceEqual(text.Reverse());
        }
    }
}
