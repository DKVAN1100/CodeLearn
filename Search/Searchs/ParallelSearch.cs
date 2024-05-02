using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Searchs
{
    public class ParallelSearch
    {
        public static int ParallelSearchFunc(string[] arr, string x, int numThreads = 4)
        {
            int chunkSize = arr.Length / numThreads;

            // Tạo mảng kết quả để lưu kết quả từ mỗi luồng
            int[] results = new int[numThreads];

            // Tạo và khởi chạy các luồng
            Parallel.For(0, numThreads, i =>
            {
                int start = i * chunkSize;
                int end = (i == numThreads - 1) ? arr.Length : start + chunkSize;

                results[i] = SearchInChunk(arr, x, start, end);
            });

            int y = results.FirstOrDefault(x => x != -1);
            return y != null ? y : -1;

            //// Kiểm tra kết quả từ mỗi luồng
            //for (int i = 0; i < numThreads; i++)
            //{
            //    if (results[i] != -1)
            //        return results[i]; // Trả về chỉ số nếu tìm thấy
            //}

            //return -1; // Trả về -1 nếu không tìm thấy phần tử
        }

        private static int SearchInChunk(string[] arr, string x, int start, int end)
        {
            //for (int i = start; i < end; i++)
            //{
            //    if (arr[i].Equals(x))
            //    {
            //        return i; // Trả về chỉ số của phần tử nếu tìm thấy
            //    }
            //}
            while (start < end)
            {
                if (arr[start].Equals(x))
                {
                    return start; // Trả về chỉ số của phần tử nếu tìm thấy
                }
                start++;
            }
            return -1; // Trả về -1 nếu không tìm thấy phần tử trong phạm vi của luồng
        }
    }
}
