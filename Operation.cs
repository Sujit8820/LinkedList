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
        public void Dispiay()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head != null)
            { 
                Node p = head;
                while(p != null)
                {
                    Console.WriteLine(p.data);
                    p = p.next;
                }
            }
        }
    }
}
