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
            SortedLinkedList sort = new SortedLinkedList();

            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(40);
            Node node4 = new Node(70);
           
            sort.Sort(node1);
            sort.Sort(node2);
            sort.Sort(node3);
            sort.Sort(node4);
            
            sort.Dispiay();
            Console.WriteLine("==============");
            

        }
    }
}
