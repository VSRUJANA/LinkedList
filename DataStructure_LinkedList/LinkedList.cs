using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_LinkedList
{
    class LinkedList
    {
        internal Node head;

        //Create a simple Linked list
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(data + " is inserted into the list");
        }

        //Display the Linked list
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "   ");
                temp = temp.next;
            }
        }

        //Insert at the beginning of Linked list
        internal void InsertAtFirst(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = head;
            }
            head = node;
            Console.WriteLine("{0} is inserted at the first position", data);
        }

        //Insert at the end of Linked list
        internal void InsertAtLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted at the last position", data);
        }

        //Count number of elements in LinkedList
        int Count(Node head)
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        //Insert at particular position in Linked list
        internal void InsertAtParticularPosition(int position, int data)
        {
            int count = Count(head);
            int pos = position;
            Node temp = this.head;
            if (position < 1 || position > count)
            {
                Console.WriteLine("Invalid Position. Node insertion unsuccessful");
                return;
            }
            if (position == 1)
            {
                InsertAtFirst(data);
                return;
            }
            while (position-- != 0)
            {
                if (position == 1)
                {
                    Node node = new Node(data);
                    node.next = head.next;
                    head.next = node;
                    break;
                }
                head = head.next;
            }

            Console.WriteLine("{0} is inserted at position {1}", data, pos);
        }

        //Delete at the beginning of Linked list
        public void DeleteFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Console.WriteLine("\n"+head.data + " is removed from the list");
            head = head.next;
        }

        //Delete at the end of Linked list
        public void DeleteLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is  empty");
            }
            else
            {
                Node temp = head;
                Node prev = null;
                while (temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                }
                Console.WriteLine("\n"+temp.data + " is removed from the list");
                prev.next = null;
            }
        }

    }
}
