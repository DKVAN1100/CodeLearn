using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Search.Sort
{
    public class QuickSort
    {
        public static void QuickSortFunc(string[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                Thread t1 = new Thread(() => { QuickSortFunc(arr, low, pivotIndex - 1); });
                Thread t2 = new Thread(() => { QuickSortFunc(arr, pivotIndex + 1, high); });

                t1.Start();
                t2.Start();

                t1.Join();
                t2.Join();
            }
        }

        public static int Partition(string[] arr, int low, int high)
        {
            int mid = (low + high) / 2;
            string pivot = arr[mid];

            int i = low;
            int j = high;

            while (true)
            {
                while (string.Compare(arr[i], pivot) < 0) i++;

                while (string.Compare(arr[j], pivot) > 0) j--;

                if (i >= j) return i + 1;

                Swap(ref arr[i], ref arr[j]);
                i++;
                j--;
            }
        }

        static void Swap(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }

        public static void PrintArray(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
