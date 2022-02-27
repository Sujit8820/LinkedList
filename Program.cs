// See https://aka.ms/new-console-template for more information
using System;

namespace LinkedList
{
    class program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Linked List");
            Operation operation = new Operation();

            Node nod1 = new Node(70);
            Node nod2 = new Node(30);
            Node nod3 = new Node(56);
            operation.AddingFromFront(nod1);
            operation.AddingFromFront(nod2);
            operation.AddingFromFront(nod3);
            operation.Dispiay();





        }
    }
}
