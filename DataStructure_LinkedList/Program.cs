using System;

namespace DataStructure_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");

            //Creating Simple linked list
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Creating Linked list");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.Write("Linked List : ");
            list.Display();

            //Insert at beginning of linked list
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Inserting at first in Linked list");
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Add(70);
            linkedList1.InsertAtFirst(30);
            linkedList1.InsertAtFirst(56);
            Console.Write("Linked List : ");
            linkedList1.Display();

            //Insert at last in linked list
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Inserting at last in Linked list");
            LinkedList linkedList2 = new LinkedList();
            linkedList2.Add(56);
            linkedList2.InsertAtLast(30);
            linkedList2.InsertAtLast(70);
            Console.Write("Linked List : ");
            linkedList2.Display();

            //Insert at particular position in linked list
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Inserting at particular position in Linked list");
            LinkedList linkedList3 = new LinkedList();
            linkedList3.Add(56);
            linkedList3.Add(70);
            linkedList3.InsertAtParticularPosition(2, 30);
            Console.Write("Linked List : ");
            linkedList3.Display();

            //Delete at beginning of linked list
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Deleting at first in Linked list");
            LinkedList linkedlist4 = new LinkedList();
            linkedlist4.Add(56);
            linkedlist4.Add(30);
            linkedlist4.Add(70);
            Console.Write("Linked List : ");
            linkedlist4.Display();
            linkedlist4.DeleteFirstNode();
            Console.Write("Linked list after deleting first node : ");
            linkedlist4.Display();

            //Delete at end of linked list
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Deleting at last in Linked list");
            LinkedList linkedlist5 = new LinkedList();
            linkedlist5.Add(56);
            linkedlist5.Add(30);
            linkedlist5.Add(70);
            Console.Write("Linked List : ");
            linkedlist5.Display();
            linkedlist5.DeleteLastNode();
            Console.Write("Linked list after deleting last node :  ");
            linkedlist5.Display();

            //Search for a node in linked list
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Searching in Linked list");
            Console.Write("Linked List : ");
            list.Display();
            list.Search(56);

        }
    }
}
