using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.LinkedLists
{
    public class Prob_InsertNodeAtHead
    {
        public void Solution()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;
            }



            PrintSinglyLinkedList(llist.head, "\n");
            Console.WriteLine();

        }

        public SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode node;

            if (head != null)
            {
                node = new SinglyLinkedListNode(data)
                {
                    next=head
                };
                head = node;
            }
            else
            {
                node = new SinglyLinkedListNode(data)
                {
                    next = null
                };
                head = node;
            }


            return head;
        }

        public void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                //textWriter.Write(node.data);
                Console.WriteLine(node.data);

                node = node.next;

                if (node != null)
                {
                    //textWriter.Write(sep);
                    Console.Write(sep);
                }
            }
        }
    }

    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

    }

}
