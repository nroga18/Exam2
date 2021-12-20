using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    public class Task2
    {
        public static void RunTask2()
        {
            var input = 70;
            Console.Write($"Task_2: \ninput: {input}\noutput: ");
            
            int answer = MinSplit(Convert.ToInt32(input));
            Console.Write($"{answer}\n\n");
        }
        public static int MinSplit(int amount)
        {
            var result = new List<int>();
            int[] banknotes = { 1, 5, 10, 20, 50 };
            int n = banknotes.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                while (amount >= banknotes[i])
                {
                    amount -= banknotes[i];
                    result.Add(banknotes[i]);
                }
            }
            return result.Count;

        }
    }
}
