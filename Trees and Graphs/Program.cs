using System;
using System.Collections;

namespace Trees_and_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree bst = new Tree();
            bst.Insert(30);
            bst.Insert(35);
            bst.Insert(50);
            bst.Insert(15);
            bst.Insert(60);
            bst.Insert(40);
            bst.Insert(80);
            bst.Insert(75);
            bst.Insert(65);
            bst.Insert(90);
            bst.Insert(85);

            Console.WriteLine("In Order");
            bst.In_Order(bst.ReturnRoot());

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Pre Order");
            bst.Pre_Order(bst.ReturnRoot());

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Post Order");
            bst.Post_Order(bst.ReturnRoot());
        }
    }

    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;
    }

    public class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int x)
        {
            Node new_node = new Node();
            new_node.Value = x;

            if (root == null)
            {
                root = new_node;
            }
            else
            {
                Node current = root;
                Node parent;

                while(true)
                {
                    parent = current;
                    if(x < current.Value)
                    {
                        current = current.Left;
                        if(current == null)
                        {
                            parent.Left = new_node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if(current == null)
                        {
                            parent.Right = new_node;
                            return;
                        }
                    }
                }
            }
        }

        public void Pre_Order(Node root)
        {
            if(root != null)
            {
                Console.Write(root.Value + " ");
                Pre_Order(root.Left);
                Pre_Order(root.Right);
            }
        }

        public void In_Order(Node root)
        {
            if (root != null)
            {
                In_Order(root.Left);
                Console.Write(root.Value + " ");
                In_Order(root.Right);
            }
        }

        public void Post_Order(Node root)
        {
            if (root != null)
            {
                Post_Order(root.Left);
                Post_Order(root.Right);
                Console.Write(root.Value + " ");
            }
        }
    }
}
