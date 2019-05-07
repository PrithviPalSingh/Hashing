using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class LargestFibonacciSubsequence
    {
        public static void fnFiboSubsequence(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            int max = arr.Max();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            CreateFiboSeries(max, ref dict);
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                    sb.Append(arr[i] + " ");
            }

            Console.WriteLine(sb.ToString());
        }

        private static void CreateFiboSeries(int max, ref Dictionary<int, int> dict)
        {
            dict = new Dictionary<int, int>();
            int a = 0;
            int b = 1;
            int c = a + b;
            dict.Add(a, 1);
            dict.Add(b, 1);
            while (c <= max)
            {
                c = a + b;
                if (!dict.ContainsKey(c))
                    dict.Add(c, 1);
                a = b;
                b = c;
            }
        }
    }
}
