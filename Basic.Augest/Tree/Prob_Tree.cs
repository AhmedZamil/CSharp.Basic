using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Tree
{
    public class Prob_Tree
    {

        public void Solution()
        {
            Tree BST = new Tree();
            BST.InsertTree(5);
            BST.InsertTree(4);
            BST.InsertTree(6);
            BST.InsertTree(3);
            BST.InsertTree(9);
            BST.InsertTree(7);

            BST.InsertTree(8);
            //BST.Insert(89);
            //BST.Insert(77);
            //BST.Insert(67);
            //BST.Insert(98);
            //BST.Insert(91);
            Console.WriteLine("Inorder Traversal : ");
            BST.Inorder(BST.ReturnRoot());
            BST.deleteNodeOfBinaryTree(4);
            Console.WriteLine("After deletion");
            BST.Inorder(BST.ReturnRoot());



        }
    }


    public class Tree
    {

        Node? root;

        public Tree()
        {
            root = null;
        }


        public void InsertBST(int d)
        {
            Node node = new Node();
            node.data = d;
            node.traversed = false;

            if (root == null)
            {
                root = node;
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

        public void InsertTree(int value)
        {
            Node node = new Node();
            node.data = value;
            if (root == null)
            {
                root = node;
                Console.WriteLine("Successfully inserted new node at Root !");
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node presentNode = (Node)queue.Dequeue();
                if (presentNode.left == null)
                {
                    presentNode.left = node;
                    Console.WriteLine("Successfully inserted new node !");
                    break;
                }
                else if (presentNode.right == null)
                {
                    presentNode.right = node;
                    Console.WriteLine("Successfully inserted new node !");
                    break;
                }
                else
                {
                    queue.Enqueue(presentNode.left);
                    queue.Enqueue(presentNode.right);
                }//end of else-if  
            }//end of loop  
        }//end of method 
        public Node ReturnRoot()
        {
            return root;
        }

        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);

                Console.WriteLine(root.data + " ");
                root.traversed = true;

                Inorder(root.right);
            }

        }

        public void preorder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data + " ");
                root.traversed = true;
                preorder(root.left);
                preorder(root.right);

            }

        }
        public void postorder(Node root)
        {
            if (root != null)
            {

                postorder(root.left);
                postorder(root.right);
                Console.WriteLine(root.data + " ");
                root.traversed = true;

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
                curNode.traversed = true;
                Console.Write("[");
                Console.Write(curNode.data + "," + curNode.traversed + " ");
                Console.Write("]");
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

        public void DeleteDeepestNode()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            Node previousNode, presentNode = null;
            while (queue.Count>0)
            {
                previousNode = presentNode;
                presentNode = queue.Dequeue();
                if (presentNode.left == null)
                {
                    previousNode.right = null;
                    return;
                }
                else if ((presentNode.right == null))
                {
                    presentNode.left = null;
                    return;
                }
                queue.Enqueue(presentNode.left);
                queue.Enqueue(presentNode.right);
            }//end of while loop  
        }//end of method  
         // get last node of last level of binary tree  
        public Node getDeepestNode()
        {
            // make an empty queue. Queue is Interface and LinkedList is class  
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            Node presentNode = null;
            while (queue.Count >0)
            {
                presentNode =(Node) queue.Dequeue();
                if (presentNode.left != null)
                    queue.Enqueue(presentNode.left);
                if (presentNode.right != null)
                    queue.Enqueue(presentNode.right);
            }
            return presentNode;
        }//end of method  


        public void deleteNodeOfBinaryTree(int value)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count >0)
            {
                Node presentNode = (Node)queue.Dequeue();
                // if node is found then copy deepest node here and delete deepest node.  
                if (presentNode.data == value)
                {
                    presentNode.data = getDeepestNode().data;
                    DeleteDeepestNode();
                    Console.WriteLine("Deleted the node !!");
                    return;
                }
                else
                {
                    if (presentNode.left != null)
                        queue.Enqueue(presentNode.left);
                    if (presentNode.right != null)
                        queue.Enqueue(presentNode.right);
                }
            }//end of while loop  
            Console.WriteLine("Did not find the node!!");
        }
    }


    public class Node
    {

        public int data;
        public Node left;
        public Node right;
        public bool traversed;

    }
}
