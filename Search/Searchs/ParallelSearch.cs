using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Searchs
{
    public class ParallelSearch
    {
        public static int ParallelSearchFunc(string[] arr, string x, int numberThreads = 4)
        {
            int chunkSize = arr.Length / numberThreads;

            int[] arrRes = new int[numberThreads];

            Parallel.For(0, numberThreads, i =>
            {
                int start = i * chunkSize;
                int end = i == numberThreads - 1 ? arr.Length : start + chunkSize;
                arrRes[i] = SearchFunc(arr, x, start, end);
            });

            int? res = arrRes.FirstOrDefault(x => x != -1);

            return res.HasValue ? res.Value : -1;

        }

        public static int SearchFunc(string[] arr, string x, int start, int end)
        {
            while (start < end)
            {
                if (arr[start] == x) return start;
                start++;
            }
            return -1;
        }

    }

}
