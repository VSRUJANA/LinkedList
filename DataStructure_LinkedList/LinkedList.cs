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

    }
}
