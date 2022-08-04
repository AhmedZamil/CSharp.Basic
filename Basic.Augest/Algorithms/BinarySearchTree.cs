using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Basic.Augest.Algorithms.Node;

namespace Basic.Augest.Algorithms
{
    //public class BinarySearchTree
    //{
    //    public void Implement()
    //    {
    //        Tree BST = new Tree();
    //        BST.Insert(30);
    //        BST.Insert(35);
    //        BST.Insert(57);
    //        BST.Insert(15);
    //        BST.Insert(63);
    //        BST.Insert(49);
    //        BST.Insert(89);
    //        BST.Insert(77);
    //        BST.Insert(67);
    //        BST.Insert(98);
    //        BST.Insert(91);
    //        Console.WriteLine("Inorder Traversal : ");
    //        BST.Inorder(BST.ReturnRoot());
    //        Console.WriteLine(" ");
    //        Console.WriteLine();
    //        Console.WriteLine("Preorder Traversal : ");
    //        BST.Preorder(BST.ReturnRoot());
    //        Console.WriteLine(" ");
    //        Console.WriteLine();
    //        Console.WriteLine("Postorder Traversal : ");
    //        BST.Postorder(BST.ReturnRoot());
    //        Console.WriteLine(" ");
    //        Console.ReadLine();
    //    }
    //}

    //public class Node
    //{
    //    public int item;
    //    public Node left;
    //    public Node right;
    //    public bool traversed;
    //    public void display()
    //    {
    //        Console.Write("[");
    //        Console.Write(item);
    //        Console.Write(traversed);
    //        Console.Write("]");
    //    }
    //}

    //public class Tree
    //{
    //    public Node root;
    //    public Tree()
    //    {
    //        root = null;
    //    }
    //    public Node ReturnRoot()
    //    {
    //        return root;
    //    }
    //    public void Insert(int id)
    //    {
    //        Node newNode = new Node();
    //        newNode.item = id;
    //        if (root == null)
    //            root = newNode;
    //        else
    //        {
    //            Node current = root;
    //            Node parent;
    //            while (true)
    //            {
    //                parent = current;
    //                if (id < current.item)
    //                {
    //                    current = current.left;
    //                    if (current == null)
    //                    {
    //                        parent.left = newNode;
    //                        newNode.display();
    //                        return;
    //                    }
    //                }
    //                else
    //                {
    //                    current = current.right;
    //                    if (current == null)
    //                    {
    //                        parent.right = newNode;
    //                        newNode.display();
    //                        return;
    //                    }
    //                }
    //            }
    //        }
    //    }

    //    public void Preorder(Node Root)
    //    {
    //        if (Root != null)
    //        {
    //            Console.Write(Root.item + " ");
    //            root.traversed = true;
    //            Preorder(Root.left);
    //            Preorder(Root.right);
    //        }
    //    }
    //    public void Inorder(Node Root)
    //    {
    //        if (Root != null)
    //        {
    //            Inorder(Root.left);
    //            root.traversed = true;
    //            Console.Write(Root.item + " ");
    //            Inorder(Root.right);
    //        }
    //    }
    //    public void Postorder(Node Root)
    //    {
    //        if (Root != null)
    //        {
    //            Postorder(Root.left);
    //            Postorder(Root.right);
    //            root.traversed = true;
    //            Console.Write(Root.item + " ");
    //        }
    //    }

    //}



    public class Tree
    {

        Node root = null;
        public Tree()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return root;

        }

        public void Insert(int d)
        {
            Node newNode = new Node();
            newNode.data = d;

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (d < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }

                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }

                    }

                }

            }

        }

        public void InorderTraverse(Node root)
        {
            if (root != null)
            {
                InorderTraverse(root.left);
                Console.WriteLine(root.data + " ");
                InorderTraverse(root.right);

            }

        }

        public void levelOrder(Node root)
        {
            //Write your code here
            Queue Q = new Queue();
            Q.Enqueue(root);

            while (Q.Count > 0)
            {
                Node curNode = (Node)Q.Peek();
                if (curNode.left != null)
                {
                    Q.Enqueue(curNode.left);
                }
                if (curNode.right != null)
                {
                    Q.Enqueue(curNode.right);
                }
                Console.Write(curNode.data + " ");
                Q.Dequeue();
            }
        }


        public Node Find(int value)
        {
            return this.Find(value, this.root);
        }

        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (parent.data == value) return parent;
                if (value < parent.data) Find(value, parent.left);
                if (value > parent.data) Find(value, parent.right);
            }

            return null;
        }

        public int GetTreeHeight()
        {
            return this.GetTreeHeight(this.root);
        }

        private int GetTreeHeight(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeHeight(parent.left), GetTreeHeight(parent.right)) + 1;
        }
        private int MinValue(Node node)
        {
            int minv = node.data;

            while (node.left != null)
            {
                minv = node.left.data;
                node = node.left;
            }

            return minv;
        }

    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

}

