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
        }
    }
}
