using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Algorithms
{
    public static class LinkedList
    {
        public static void Implementation()
        {
            //Node head = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //	int data = Int32.Parse(Console.ReadLine());
            //	head = insert(head, data);
            //}
            //display(head);

            Node_LinkList head = null;

            int T = Int32.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                int data = Int32.Parse((Console.ReadLine()));
                head = insert(head, data);
            }
            display(head);

        }

        //public static Node insert(Node head, int data)
        //{
        //	//Complete this method
        //	Node node = new Node(data);
        //	if (head == null)
        //	{
        //		head = node;
        //	}
        //	else
        //	{
        //		if (head.next == null)
        //		{
        //			head.next = node;
        //		}
        //		else
        //		{
        //			Node current = head;
        //			while (current.next != null)
        //			{
        //				current = current.next;
        //			}
        //			current.next = node;
        //		}
        //	}
        //	return head;
        //}

        public static Node_LinkList insert(Node_LinkList head, int data)
        {
            Node_LinkList node = new Node_LinkList(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                if (head.next == null)
                {
                    head.next = node;
                }
                else
                {
                    Node_LinkList current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }

            }

            return head;
        }

        //public static void display(Node head)
        //{
        //	Node start = head;
        //	while (start != null)
        //	{
        //		Console.Write(start.data + " ");
        //		start = start.next;
        //	}
        //}

        public static void display(Node_LinkList head)
        {
            Node_LinkList start = head;
            while (start != null)
            {
                Console.WriteLine(start.data + " ");
                start = start.next;
            }

        }
    }



    public class Node_LinkList
    {
        public int data;
        public Node_LinkList next;

        public Node_LinkList(int d)
        {
            data = d;
            next = null;
        }

    }

}

