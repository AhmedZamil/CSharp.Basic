using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class TreeProb
    {
        public void Main()
        {
            Tree tree = new Tree();
            tree.InsertBST(3);
            tree.InsertBST(9);
            tree.InsertBST(20);
            tree.InsertBST(null);
            tree.InsertBST(null);
            tree.InsertBST(15);
            tree.InsertBST(7);

            Console.WriteLine("Tree Height : " + tree.GetHeight());

            Node node = tree.GetDepestNode();
        }


    }
    public class Tree 
    {
        Node? root = null;
        public Tree()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return this.root;
        }

        public void InsertTree(int? value)
        {
            Node node = new Node();
            node.data = value;

            if (root == null)
            {
                root = node;
                return;
            }
            else
            {
                Queue<Node> q = new Queue<Node>();
                q.Enqueue(root);

                while (q.Count > 0)
                {
                    Node current = (Node)q.Dequeue();

                    if (current.left == null)
                    {
                        current.left = node;
                        return;
                    }
                    else if (current.right == null)
                    {
                        current.right = node;
                        return;
                    }
                    else
                    {
                        q.Enqueue(current.left);
                        q.Enqueue(current.right);
                    
                    }
                
                }
            
            }
        
        }

        public void InsertBST(int? value)
        {
            Node node = new Node();
            node.data = value;

            if (root == null)
            {
                root = node;
                return;
            }
            else
            {
                Node current = root;
                Node parent = null;

                while (true)
                {
                    parent = current;
                    if (value < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = node;
                            return;
                        }
                    
                    }
                
                }
            
            }
        }

        public Node GetDepestNode()
        { 
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(this.root);

            Node current = null;

            while (q.Count>0)
            {
                current = (Node)q.Dequeue();
                if (current.left != null) q.Enqueue(current.left);
                else if (current.right != null) q.Enqueue(current.right);
            }

            return current;
        }

        public int GetHeight()
        {
            return this.GetHeight(this.root);      
        }

        public int GetHeight(Node parent)
        {
            return parent == null ? 0 : Math.Max(this.GetHeight(parent.left),this.GetHeight(parent.right))+1;
        }

       
         
    
    }

    public class Node {
        public int? data;
        public Node left;
        public Node right;
        public bool traversed;
    
    }
}
