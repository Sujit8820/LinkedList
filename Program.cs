// See https://aka.ms/new-console-template for more information
using System;

namespace LinkedList
{
    class program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Linked List");

            Node start = null;

            Node node1 = new Node(56);

            start = node1;

            Node node2 = new Node(30);

            node2.next = node1;
            start = node2;

            Node node3 = new Node(70);

            node3.next = node2;
            start = node3;



        }
    }
}
