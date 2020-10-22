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
        }
    }
}
