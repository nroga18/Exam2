using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam2
{
    public static class Task1
    {
        public static void RunTask1()
        {
            var text = "tenet";
            Console.Write($"Task_1: \ninput: {text}\noutput: ");
            if (IsPalindrome(text))
            {
                Console.WriteLine("Your text is a Palindrome\n");
            }
            else
            {
                Console.WriteLine("Your text is not a Palindrome\n");
            }
        }
        public static bool IsPalindrome(string text)
        {
            return text.SequenceEqual(text.Reverse());
        }
    }
   
}
