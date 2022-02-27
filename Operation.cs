using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Operation
    {
        Node head = null;

        public void AddingFromFront(Node data)
        {
            if (head == null)
            {
                head = data;
            }
            else
            {
                Node temp = data;
                temp.next = head;
                head = temp;
            }
        }
        public void AddingFromEnd(Node data)
        {
            if (head == null)
            {
                head = data;
            }
            else
            {
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                Node temp = data;
                p.next = temp;
            }
        }

        public void InsertBetween(Node data)
        {
            if (head == null)
            {
                return;
            }
            else
            {
                Node p = head;
                while (p.next.next != null)
                {
                    p = p.next;
                }
                Node temp = data;
                temp.next = p.next;
                p.next = temp;

            }
        }

        public void DeleteFirstElement()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                Node p = head;
                head = p.next;
            }
        }

        public void DeleteLastElement()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                Node p = head;
                while (p.next.next != null)
                {
                    p = p.next;
                }
                p.next = null;

            }
        }
        public void SearchNode(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node p = head;
                int count = 1;
                while (p != null)
                {
                    if (p.data == data)
                    {
                        break;
                    }

                    count++;
                    p = p.next;
                }
                if (p == null)
                {
                    Console.WriteLine($"{data} is not present in list");
                }
                else
                {
                    Console.WriteLine($"{data} is present at position {count}");
                }

            }
        }

        public void InsertAfter(Node data, int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node p = head;
                int count = 1;
                while (p != null)
                {
                    if (p.data == key)
                    {
                        break;
                    }

                    count++;
                    p = p.next;
                }
                if (p == null)
                {
                    Console.WriteLine($"{key} is not present in list\n");
                }
                else
                {
                    Node temp = data;
                    temp.next = p.next;
                    p.next = temp;
                }
            }
        }

        public void DeleteElement(int data)
        {

            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node p = head;
                int count = 1;
                while (p != null)
                {
                    if (p.next.data == data)
                    {
                        break;
                    }

                    count++;
                    p = p.next;
                }
                if (p == null)
                {
                    Console.WriteLine($"{data} is not present in list");
                }
                else
                {
                    p.next = p.next.next;

                }
            }
        }

        public void Dispiay()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head != null)
            {
                int count = 0;
                Node p = head;
                while (p != null)
                {
                    Console.WriteLine(p.data);
                    count++;
                    p = p.next;
                }
                Console.WriteLine($"\nSize of list is {count}");
            }
        }
    }
}
