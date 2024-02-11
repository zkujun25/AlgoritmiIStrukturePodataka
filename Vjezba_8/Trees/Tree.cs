using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class Tree
    {
        public enum TraversalType { PreOrder, InOrder, PostOrder };
        Node root;

        public Tree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            if (root == null) { root = new Node(value); }
            else { root.Insert(value); }
        }

        public bool Search(int value)
        {
            Node node = Search(root, value);
            if (node != null)
                return true;
            else
                return false;
        }
        private Node Search(Node current, int value)
        {
            if (current == null || current.Data == value)
                return current;

            if (value < current.Data)
                return Search(current.left, value);
            else
                return Search(current.right, value);
           
        }

        public void Delete(int value)
        {
            Delete(ref root, value);
        }
        private void Delete(ref Node current, int value)
        {
            if(current == null)
                return;

            if (value < current.Data)
                Delete(ref current.left, value);
            else if (value > current.Data)
                Delete(ref current.right, value);
            else
            {
                if (current.left == null)
                    current = current.right;
                else if (current.right == null)
                    current = current.left;
                else
                    current.Data = DeleteSuccessor(ref current.right);
            }
        }

        private int DeleteSuccessor(ref Node current)
        {
            if(current.left == null)
            {
                int temp = current.Data;
                current = current.right;
                return temp;
            }
            else
            {
                return DeleteSuccessor(ref current.left);
            }
        }

        public void Traverse(TraversalType traverse)
        {
            switch (traverse)
            {
                case TraversalType.PreOrder:
                    TraversePreorder(root);
                    break;
                case TraversalType.InOrder:
                    TraverseInorder(root);
                    break;
                case TraversalType.PostOrder:
                    TraversePostorder(root);
                    break;
                default:
                    Console.WriteLine("What a #@$@#@!");
                    break;
            }
        }

        private void TraversePreorder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                TraversePreorder(node.left);
                TraversePreorder(node.right);
            }
        }
        private void TraverseInorder(Node node)
        {
            if (node != null)
            {
                TraverseInorder(node.left);
                Console.Write(node.Data + " ");
                TraverseInorder(node.right);
            }
        }
        private void TraversePostorder(Node node)
        {
            if (node != null)
            {
                TraversePostorder(node.left);
                TraversePostorder(node.right);
                Console.Write(node.Data + " ");
            }
        }

    }
}