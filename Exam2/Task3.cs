using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    public class Task3
    {
        public static void RunTask3()
        {
            int[] sample = new int[] { -3, 4, 1, -7, 2, 5, 6 };
            Console.Write($"Task_3: \ninput: ");
            Console.WriteLine(string.Join(", ", sample));
            int ans = NotContains(sample);
            Console.WriteLine($"output: {ans}\n");
        }
        public static int NotContains(int[] array)
        {
            int length = array.Length;
            var set = new HashSet<int>();
            foreach (int item in array)
            {
                if (item > 0)
                {
                    set.Add(item);
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
