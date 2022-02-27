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

            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            Node node4 = new Node(40);
            operation.AddingFromEnd(node1);
            operation.AddingFromEnd(node2);
            operation.AddingFromEnd(node3);
            operation.Dispiay();
            Console.WriteLine("==============");
            operation.InsertAfter(node4, 35);
            operation.Dispiay();


        }
    }
}
