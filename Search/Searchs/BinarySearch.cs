using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Searchs
{
    public class BinarySearch
    {
        public static int BinarySearchFunc(string[] arr, string x)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Kiểm tra nếu x là giá trị ở giữa
                if (arr[mid].Equals(x))
                    return mid;

                // Nếu x lớn hơn giá trị ở giữa, loại bỏ nửa trái
                if (String.Compare(arr[mid], x) < 0)
                    left = mid + 1;

                // Nếu x nhỏ hơn giá trị ở giữa, loại bỏ nửa phải
                else
                    right = mid - 1;
            }

            // Trả về -1 nếu không tìm thấy x trong mảng
            return -1;

        }
    }
}
