using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    public class Task5
    {
        public static void RunTask5()
        {
            var input = 5;
            Console.WriteLine($"Task_5: \ninput: {input}\noutput: {CountVariants(5)}\n");
        }
        static int Fib(int n)
        {
            if (n <= 1)
                return n;
            return Fib(n - 1) + Fib(n - 2);
        }


        public static int CountVariants(int stearsCount)
        {
            return Fib(stearsCount + 1);
        }
    }
}
