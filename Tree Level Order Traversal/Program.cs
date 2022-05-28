using System;
using System.Collections;

namespace Tree_Level_Order_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(9);
            node.left = new Node(8);
            node.left.left = new Node(7);
            node.left.right = new Node(6);
            node.right = new Node(10);

            Operation o = new Operation();
            o.PrintLevelOrder(node);
        }
    }

    internal class Operation
    {
        internal void PrintLevelOrder(Node node)
        {
            Queue q = new Queue();
            Node temp = node;

            while(temp != null)
            {
                Console.Write(temp.data + "--->");
                q.Enqueue(temp.left);
                q.Enqueue(temp.right);
                temp = (Node)q.Dequeue();
            }
        }
    }

    internal class Node
    {
        internal int data;
        internal Node left;
        internal Node right;

        public Node(int val)
        {
            this.data = val;
            this.left = null;
            this.right = null;
        }
    }
}
