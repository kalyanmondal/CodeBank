using System;

//namespace StringReverseUsingStack
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            StackOfChars stackOfChars = new StackOfChars();

//            Operation o = new Operation();
//            string StringToReverse = "GeeksForGeeks";

//            for (int i = 0; i < StringToReverse.Length; i++)
//            {
//                o.Push(stackOfChars, StringToReverse[i]);
//            }
//            o.PopAll(stackOfChars.root);

//            Console.ReadKey();
//        }
//    }

//    internal class StackNode
//    {
//        internal char Data;
//        internal StackNode nextChar;

//        public StackNode(char x)
//        {
//            Data = x;
//            nextChar = null;
//        }
//    }

//    internal class StackOfChars
//    {
//        internal StackNode root;
//    }

//    internal class Operation
//    {
//        internal void Push(StackOfChars s, char v)
//        {
//            StackNode new_node = new StackNode(v);
//            if (s.root == null)
//            {
//                s.root = new_node;
//            }
//            else
//            {
//                StackNode temp = s.root;
//                s.root = new_node;
//                new_node.nextChar = temp;
//            }
//        }

//        internal void PopAll(StackNode s)
//        {
//            if (s == null)
//            {
//                Console.WriteLine("Stack is empty!");
//                return;
//            }

//            Console.Write(s.Data);
//            if (s.nextChar == null)
//            {
//                return;
//            }

//            PopAll(s.nextChar);
//        }
//    }
//}

namespace StringReverseUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfChars stackOfChars = new StackOfChars();
            StackOfChars stackOfChars2 = new StackOfChars();

            Operation o = new Operation();
            int[] StringToReverse = new[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < StringToReverse.Length; i++)
            {
                o.Push(stackOfChars, StringToReverse[i]);
            }
            o.PopAll(stackOfChars.root, stackOfChars2);

            Console.ReadKey();
        }
    }

    internal class StackNode
    {
        internal int Data;
        internal StackNode nextChar;

        public StackNode(int x)
        {
            Data = x;
            nextChar = null;
        }
    }

    internal class StackOfChars
    {
        internal StackNode root;
    }

    internal class Operation
    {
        internal void Push(StackOfChars s, int v)
        {
            StackNode new_node = new StackNode(v);
            if (s.root == null)
            {
                s.root = new_node;
            }
            else
            {
                StackNode temp = s.root;
                s.root = new_node;
                new_node.nextChar = temp;
            }
        }

        internal void PopAll(StackNode s, StackOfChars output)
        {
            Operation o = new Operation();

            if (s == null)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            o.Push(output, s.Data);
            if (s.nextChar == null)
            {
                return;
            }

            PopAll(s.nextChar, output);
        }
    }
}
