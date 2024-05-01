using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Tree
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Function to insert a new node
        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        /* A recursive function to insert a new key in BST */
        private Node InsertRec(Node root, int data)
        {
            /* If the tree is empty, return a new node */
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            /* Otherwise, recur down the tree */
            if (data < root.Data)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRec(root.Right, data);

            /* return the (unchanged) node pointer */
            return root;
        }

        // Function to do inorder traversal of binary tree
        private void InorderRec(Node root)
        {
            if (root != null)
            {
                InorderRec(root.Left);
                Console.Write(root.Data + " ");
                InorderRec(root.Right);
            }
        }

        public void Inorder()
        {
            InorderRec(Root);
        }

        // Function to search a given key in a given BST
        public bool Search(int key)
        {
            return SearchRec(Root, key);
        }

        // Recursive function to search for a key in the binary tree
        private bool SearchRec(Node root, int key)
        {
            // Base Cases: root is null or key is present at root
            if (root == null || root.Data == key)
                return root != null;

            // Key is greater than root's key
            if (root.Data < key)
                return SearchRec(root.Right, key);

            // Key is smaller than root's key
            return SearchRec(root.Left, key);
        }

    }

}
