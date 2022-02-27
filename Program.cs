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

            Node nod1 = new Node(56);
            Node nod2 = new Node(30);
            Node nod3 = new Node(70);
            operation.AddingFromEnd(nod1);
            operation.AddingFromEnd(nod2);
            operation.AddingFromEnd(nod3);
            operation.Dispiay();
            Console.WriteLine("==============");
            operation.DeleteFirstElement();
            operation.Dispiay();
            


        }
    }
}
