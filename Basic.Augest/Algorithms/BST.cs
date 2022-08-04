using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Algorithms
{
    //public static class BST
    //{
    //    public static void Implementation()
    //    {
    //        Node root = null;
    //        int T = Int32.Parse(Console.ReadLine());
    //        while (T-- > 0)
    //        {
    //            int data = Int32.Parse(Console.ReadLine());
    //            root = insert(root, data);
    //        }
    //        int height = getHeight(root);
    //        Console.WriteLine(height);

    //    }
    //    static int getHeight(Node root)
    //    {
    //        //Write your code here
    //        if (root == null)
    //        {
    //            return -1;
    //        }

    //        return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
    //    }
    //    //static Node insert(Node root, int data)
    //    //{
    //    //    if (root == null)
    //    //    {
    //    //        return new Node(data);
    //    //    }
    //    //    else
    //    //    {
    //    //        Node cur;
    //    //        if (data <= root.data)
    //    //        {
    //    //            cur = insert(root.left, data);
    //    //            root.left = cur;
    //    //        }
    //    //        else
    //    //        {
    //    //            cur = insert(root.right, data);
    //    //            root.right = cur;
    //    //        }
    //    //        return root;
    //    //    }
    //    //}

    //    public static Node insert(Node root,int data)
    //    {
    //        if (root == null)
    //        {
    //            return new Node(data);
    //        }
    //        else
    //        {
    //            Node cur;
    //            if (data <= root.data)
    //            {
    //                cur = insert(root.left, data);
    //                root.left = cur;
    //            }
    //            else { 
    //                cur = insert(root.right, data);
    //                root.right = cur;
                
    //            }
            
    //        }

    //        return root;
    //    }
    //}

    //public class Node
    //{
    //    public int data;
    //    public Node left;
    //    public Node right;
    //    public Node(int d)
    //    {
    //        this.data = d;

    //    }
    
    //}
}
