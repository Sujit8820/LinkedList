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
                while(p.next.next != null)
                {
                    p=p.next;
                }
                p.next = null;

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
                Node p = head;
                while (p != null)
                {
                    Console.WriteLine(p.data);
                    p = p.next;
                }
            }
        }
    }
}
