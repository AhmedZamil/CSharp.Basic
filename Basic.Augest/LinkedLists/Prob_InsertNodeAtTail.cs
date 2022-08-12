using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.LinkedLists
{
    //public class Prob_InsertNodeAtTail
    //{
    //    public void Solution()
    //    {
  
    //        SinglyLinkedList llist = new SinglyLinkedList();

    //        int llistCount = Convert.ToInt32(Console.ReadLine());

    //        for (int i = 0; i < llistCount; i++)
    //        {
    //            int llistItem = Convert.ToInt32(Console.ReadLine());
    //            SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
    //            llist.head = llist_head;

    //        }



    //        PrintSinglyLinkedList(llist.head, "\n");
    //        Console.WriteLine();

    //    }

    //    public void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
    //    {
    //        while (node != null)
    //        {
    //            Console.WriteLine(node.data);

    //            node = node.next;

    //            if (node != null)
    //            {
    //                Console.Write(sep);
    //            }
    //        }
    //    }

    //    public SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode llist, int data)
    //    {

    //        SinglyLinkedListNode node = new SinglyLinkedListNode(data);

    //        if (llist == null)
    //        {
    //            llist = node;
    //        }
    //        else
    //        {
    //            node.next = llist;
    //            llist = node;

    //        }

    //        return llist;

    //        //if (head != null)
    //        //{

    //        //    node.next = head;
    //        //    head = node;
    //        //}
    //        //else
    //        //{
    //        //    head = node;

    //        //    //SinglyLinkedListNode current = head;
    //        //    //while (current.next !=null)
    //        //    //{
    //        //    //    current = current.next;
    //        //    //}
    //        //    //current.next = node;
    //        //}


    //        //return head;
    //    }

    //}


    //public class SinglyLinkedListNode
    //{
    //    public int data;
    //    public SinglyLinkedListNode next;

    //    public SinglyLinkedListNode(int nodeData)
    //    {
    //        this.data = nodeData;
    //        this.next = null;
    //    }
    //}

    //public class SinglyLinkedList
    //{
    //    public SinglyLinkedListNode head;
    //    public SinglyLinkedListNode tail;

    //    public SinglyLinkedList()
    //    {
    //        this.head = null;
    //        this.tail = null;
    //    }

    //}


}
