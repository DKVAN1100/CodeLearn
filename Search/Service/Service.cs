using Search.Searchs;
using Search.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Service
{
    public class Service : IService
    {
        public async Task RunBinarySearch()
        {
            string[] arr = { "apple", "banana", "cherry", "orange", "strawberry" };

            Console.Write("Enter the string to search: ");
            string x = Console.ReadLine();

            int result = BinarySearch.BinarySearchFunc(arr, x);
            if (result == -1)
                Console.WriteLine("String not found");
            else
                Console.WriteLine("String found at position " + result);
        }

        public async Task RunBinaryTree()
        {
            BinaryTree tree = new BinaryTree();

            /* Let's create a tree with nodes
                          50
                         /  \
                        30   70
                       / \   / \
                     20  40 60 80 */
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

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

    }
}
