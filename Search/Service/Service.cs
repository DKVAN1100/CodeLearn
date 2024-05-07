using Search.Searchs;
using Search.Sort;
using Search.Tree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Service
{
    public class Service : IService
    {
        static string[] arr = { "w","x","apple", "banana", "cherry", "orange", "strawberry", "f", "e", "h", "l", "g", "j", "q", "p", "m", "b", "a", "d", "s", "v", "n", "t" };

        public async Task RunBinarySearch()
        {

            Console.Write("Enter the string to search: ");
            string x = Console.ReadLine();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            QuickSort.QuickSortFunc(arr, 0, arr.Length - 1);


            //  BubbleSort.BubbleSortFunc(arr);

            QuickSort.PrintArray(arr);
            stopwatch.Stop();
            Console.WriteLine("Thời gian chạy của BubbleSortFunc: " + stopwatch.ElapsedMilliseconds + " ms");

            int result = BinarySearch.BinarySearchFunc(arr, x);
            if (result == -1)
                Console.WriteLine("String not found");
            else
                Console.WriteLine("String found at position " + result);
        }

        public async Task RunBinaryTree()
        {
            BinaryTree tree = new BinaryTree();

            Console.WriteLine("Enter the values to insert into the binary tree (enter -1 to stop):");

            int value;
            do
            {
                Console.Write("Enter a value (-1 to stop): ");
                value = int.Parse(Console.ReadLine());

                if (value != -1)
                    tree.Insert(value);

            } while (value != -1);

            // Print inorder traversal of the BST
            Console.WriteLine("Inorder traversal of the binary tree is ");
            tree.Inorder();

            // Prompt user to enter the key to search
            Console.Write("\nEnter the key to search: ");
            int keyToSearch = int.Parse(Console.ReadLine());

            if (tree.Search(keyToSearch))
                Console.WriteLine($"\nKey {keyToSearch} found in the binary tree.");
            else
                Console.WriteLine($"\nKey {keyToSearch} not found in the binary tree.");
        }

        public async Task RunParallelSearch()
        {
            Console.Write("Enter the string to search: ");
            string x = Console.ReadLine();

            int result = ParallelSearch.ParallelSearchFunc(arr, x);
            if (result == -1)
                Console.WriteLine("String not found");
            else
                Console.WriteLine("String found at position " + result);
        }
    }
}
