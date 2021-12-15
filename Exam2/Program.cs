using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam2
{
    class Program
    {

        static void Main(string[] args)
        {

        }

        static int fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n - 2);
        }


        public static int countVariants(int stearsCount)
        {
            return fib(stearsCount + 1);
        }
        public static bool isProperly(string sequence)
        {
            bool result = true;
            int n = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(')
                {
                    n++;
                }
                else
                {
                    n--;
                }
                if (n < 0)
                {
                    result = false;
                    break;
                }
            }
            if (n != 0)
            {
                result = false;
            }
            return result;
        }

        public static bool isPalindrome(String text)
        {
            return text.SequenceEqual(text.Reverse());
        }
        public static int minSplit(int amount)
        {
            var result = new List<int>();
            int[] Banknotes = { 1, 5, 10, 20, 50 };
            int n = Banknotes.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                while (amount >= Banknotes[i])
                {
                    amount -= Banknotes[i];
                    result.Add(Banknotes[i]);
                }
            }
            return result.Count;

        }

        public static int notContains(int[] array)
        {
            int length = array.Length;
            var set = new HashSet<int>();
            foreach (int a in array)
            {
                if (a > 0)
                {
                    set.Add(a);
                }
            }
            for (int i = 1; i <= length + 1; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

