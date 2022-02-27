using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SortedLinkedList
    {
        Node head = null;

        public void Sort(Node data)
        {
            if (head == null)
            {
                head = data;
            }
            else
            {
                Node temp = data;
                int compare = temp.data.CompareTo(head.data);
                switch (compare)
                {
                    case 0:
                        temp.next = head;
                        head = temp;
                        break;
                    case -1:
                        temp.next = head;
                        head = temp;
                        break;
                    default:
                        {
                            Node p =head;
                            while(p.next.data < temp.data)
                            {
                                p = p.next;
                                if(p.next == null)
                                {
                                    break;
                                    p.next = temp;
                                }
                            }
                            temp.next = p.next;
                            p.next = temp;
                            break;
                        }
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
