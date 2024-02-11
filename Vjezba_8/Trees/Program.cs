using System;
using static Trees.Tree;

namespace Trees
{
    class Program
    {
        static void Main()
        {
            Tree tree = new Tree();
            int[] array = { 4, 2, 6, 7, 1, 3, 5, 8 };
            foreach (int i in array) tree.Insert(i);

            Console.Write("Inorder: ");
            tree.Traverse(TraversalType.InOrder);
            Console.WriteLine();

            Console.Write("Postorder: ");
            tree.Traverse(TraversalType.PostOrder);
            Console.WriteLine();

            Console.Write("Preorder: ");
            tree.Traverse(TraversalType.PreOrder);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Searching for 4...");
            int value = 4;
            if (tree.Search(value))
                Console.WriteLine("Value {0:d} is found in the tree.", value );
            else
                Console.WriteLine("Value {0:d} is not found in the tree.", value);
           
            Console.WriteLine();
            Console.WriteLine("Deleting 4...");
            tree.Delete(4);

            Console.Write("Look at a tree InOrder now: ");
            tree.Traverse(TraversalType.InOrder);
            Console.WriteLine();
        }

    }
}