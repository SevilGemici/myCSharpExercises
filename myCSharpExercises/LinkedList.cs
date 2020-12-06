using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks
{
    class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        void PairWiseSwap()
        {
            Node temp = head;
            while(temp!=null && temp.next != null)
            {
                int k = temp.data;
                temp.data = temp.next.data;
                temp.next.data = k;
                temp = temp.next.next;
            }
        }
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Run()
        {
            LinkedList llist = new LinkedList();
            llist.push(5);
            llist.push(4);
            llist.push(3);
            llist.push(2);
            llist.push(1);

            Console.WriteLine("LinkedList before calling PairWiseSwap()");
            llist.printList();
            llist.PairWiseSwap();
            Console.WriteLine("LinkedList after calling PairWiseSwap()");
            llist.printList();
        }
    }
}
