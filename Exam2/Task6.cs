using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    public class MyStruct
    {
        int[] arr;   
        Dictionary<int, int> hash;

        public MyStruct()
        {
            arr = new int[0];
            hash = new Dictionary<int, int>();
        }

        public void Add(int x)
        {
            if (hash.ContainsKey(x))
                return;
            int s = arr.Length;
            Array.Resize(ref arr, arr.Length + 1);
            arr[s] = x;
            hash[x] = s;
        }
        public void Remove(int x)
        {
            
            if (!hash.ContainsKey(x))
                return;
            var index = hash[x];
            hash.Remove(x);
            int size = arr.Length;
            int last = arr[size - 1];
            (arr[index], arr[size - 1]) = (arr[size - 1], arr[index]);
            Array.Resize(ref arr, arr.Length-1);
            hash[last] = index;
        }

    
        public int Search(int x)
        {
            return hash[x];
        }
    }
}
