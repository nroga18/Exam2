using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    public class Task4
    {
        public static void RunTask4()
        {
            var exp = "(()())()()";
            Console.Write($"Task_4: \ninput: {exp}\noutput: ");
            Console.WriteLine($"{IsProperly(exp)}\n");
        }
        public static bool IsProperly(string sequence)
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
    }
}
