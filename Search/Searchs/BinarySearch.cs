using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Search.Searchs
{
    public class BinarySearch
    {
       public static int BinarySearchFunc(string[] arr, string x)
        {
            int left = 0; int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == x) return mid;

                if (string.Compare(arr[mid], x) < 0) left = mid + 1;
                else right = mid -1;
            }

            return -1;
        }
    }
}
