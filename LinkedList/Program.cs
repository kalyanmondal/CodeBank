using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList s = new SingleLinkedList();

            Implementation i = new Implementation();

            i.InsertFront(s, 5);
            i.InsertFront(s, 4);
            i.InsertFront(s, 3);
            i.InsertFront(s, 2);
            int x = i.GenerateNumber(s.head);
            //i.ReverseLinkedList(s);

            
        }
    }

    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class DNode
    {
        internal int data;
        internal DNode prev;
        internal DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }

    internal class SingleLinkedList
    {
        internal Node head;
    }

    internal class DoubleLinkedList
    {
        internal DNode head;
    }

    internal class Implementation
    {
        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }

        internal void InsertFront(DoubleLinkedList doubleLinkedList, int new_data)
        {
            DNode new_node = new DNode(new_data);
            new_node.next = doubleLinkedList.head;
            new_node.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = new_node;
            }
            doubleLinkedList.head = new_node;
        }

        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);

            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            
            Node last_node = GetLastNodeRecursive(singlyList.head);
            last_node.next = new_node;
        }

        internal void InsertLast(DoubleLinkedList doubleLinkedList, int new_data)
        {
            DNode new_node = new DNode(new_data);

            if (doubleLinkedList.head == null)
            {
                new_node.prev = null;
                doubleLinkedList.head = new_node;
                return;
            }

            DNode last_node = GetLastNodeRecursive(doubleLinkedList.head);
            last_node.next = new_node;
            new_node.prev = last_node;
        }

        internal Node GetLastNodeRecursive(Node node)
        {
            if (node.next == null)
            {
                return node;
            }

            return GetLastNodeRecursive(node.next);
        }

        private DNode GetLastNodeRecursive(DNode node)
        {
            if(node.next ==null)
            {
                return null;
            }

            return GetLastNodeRecursive(node.next);
        }

        internal int Count(SingleLinkedList singlyList)
        {
            return getCountRecursive(singlyList.head);                        
        }

        internal int getCountRecursive(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            
            return 1 + getCountRecursive(node.next);
        }

        internal bool Search(SingleLinkedList s, int x)
        {
            return SearchRecursive(s.head, x);
        }

        internal bool SearchRecursive(Node current, int x)
        {
            if (current == null)
            {
                return false;
            }

            if(current.data == x)
            {
                return true;
            }

            return SearchRecursive(current.next, x);
        }

        internal void ReverseLinkedList(SingleLinkedList s)
        {
            ReverseRecursive(s.head);
        }

        internal Node ReverseRecursive(Node head)
        {
            if (head == null)
            {
                return head;
            }

            if (head.next == null)
            {
                return head;
            }

            Node newHeadNode = ReverseRecursive(head.next);

            head.next.next = head;
            head.next = null;

            return newHeadNode;
        }

        internal void Delete(SingleLinkedList s, int x)
        {
            Node current = s.head;
            Node prev = null;

            while (current != null && current.data == x)
            {
                s.head = current.next;
                return;
            }

            while(current != null && current.data != x)
            {
                prev = current;
                current = current.next;
            }

            if(current == null)
            {
                return;
            }

            prev.next = current.next;
        }

        public int GenerateNumber(Node head)
        {
            int f = 0;
            while(head.next != null)
            {
                f = f * 10 + head.data;
                head = head.next;
            }
            f = f * 10 + head.data;
            return f;

        }
    }
}
