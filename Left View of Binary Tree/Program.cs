using System;
using System.Collections.Generic;

namespace Left_View_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            root r = new root(1);
            r.left = new root(2);
            r.right = new root(3);
            r.right.right = new root(4);

            List<int> result = new List<int>();

            Operation o = new Operation();
            o.getLeftView(r, 1, result);

        }
    }

    internal class Operation
    {
        int maxLevel = 0;
        internal void getLeftView(root root, int v, List<int> result)
        {
            if (root == null)
            {
                return;
            }

            if (maxLevel < v)
            {
                result.Add(root.data);
                maxLevel = v;
            }

            getLeftView(root.left, v + 1, result);
            getLeftView(root.right, v + 1, result);
        }
    }

    internal class root
    {
        internal int data;
        internal root left;
        internal root right;

        public root(int val)
        {
            data = val;
            left = null;
            right = null;
        }
    }
}
