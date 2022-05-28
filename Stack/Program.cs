using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal class StackNode
    {
        internal int data;
        internal StackNode next;

        public StackNode(int x)
        {
            data = x;
        }
    }

    internal class StackUsingLinkedList
    {
        internal StackNode root;
    }

    internal class Implementatipn
    {
        internal bool IsEmpty(StackUsingLinkedList s)
        {
            if (s.root == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void Push(StackUsingLinkedList s, int new_data)
        {
            StackNode new_node = new StackNode(new_data);

            if (s.root == null)
            {
                s.root = new_node;
            }
            else 
            {
                StackNode temp = s.root;
                s.root = new_node;
                new_node.next = temp;
            }

            Console.WriteLine(new_data + " has been pushed to stack");
        }

        internal int Pop(StackUsingLinkedList s)
        {
            int popped = int.MaxValue;
            if (s.root == null)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                popped = s.root.data;
                s.root = s.root.next;
            }

            return popped;
        }
    }
}
