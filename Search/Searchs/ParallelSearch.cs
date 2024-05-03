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

            int[] arrayResult = new int[numberThreads];

            Parallel.For(0, numberThreads, i =>
            {
                int start = i * chunkSize;
                int end = i == (numberThreads - 1) ? arr.Length : start + chunkSize;
                arrayResult[i] = SearchFunc(arr, x, start, end);
            });
            int res = arrayResult.FirstOrDefault(x => x != -1);
            return res != null ? res : -1;
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
