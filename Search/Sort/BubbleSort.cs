using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Sort
{
    public class BubbleSort
    {
        public static void BubbleSortFunc(string[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
              
            }
        }
        static void Swap(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
    }
}
