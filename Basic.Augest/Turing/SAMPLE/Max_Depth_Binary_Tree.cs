using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.SAMPLE
{
    public class Max_Depth_Binary_Tree
    {
        public void Main()
        {
            var input = Console.ReadLine();
            TreeNode root = null;
            try
            {
                root = deserialize(input);
            }
            catch (FormatException){  }

            Max_Depth_Binary_Tree_Solution Solution = new Max_Depth_Binary_Tree_Solution();
            var output = Solution.MaxDepth(root);
            Console.WriteLine(output);  
        }

        public TreeNode deserialize(string data)
        {
            if (data == null || data.Length == 0)
            {
                return null;
            }

            var parts = data.Split(",");
            var queue = new Queue<TreeNode>();

            var rootNode = parts[0];
            var root = new TreeNode(0);

            if (!rootNode.Equals("null"))
            {
                root = new TreeNode(int.Parse(rootNode));
            }
            else
            {
                return null;
            }

            queue.Enqueue(root);

            int i = 1;

            while (i < parts.Length)
            { 
                var node = queue.Dequeue();

                if (string.Equals(parts[i], "null", StringComparison.InvariantCultureIgnoreCase))
                {
                    node.Left = null;
                }
                else
                { 
                    var left = new TreeNode(int.Parse(parts[i]));
                    node.Left = left;
                    queue.Enqueue(left);
                }

                if (i + 1 == parts.Length) break;

                if (string.Equals(parts[i+1],"null",StringComparison.InvariantCultureIgnoreCase))
                {
                    node.Right = null;
                }
                else
                {
                    TreeNode right = new TreeNode(int.Parse(parts[i+1]));
                    node.Right = right;
                    queue.Enqueue(right);
                
                }
                i += 2;           
            }

            return root;
        }



    }

    public class Max_Depth_Binary_Tree_Solution
    {
        public int MaxDepth(TreeNode root)
        {
            // write you code here



            return root== null? 0: Math.Max(MaxDepth(root.Left),MaxDepth(root.Right)) + 1;

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

            while (q.Count > 0)
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
            return parent == null ? 0 : Math.Max(this.GetHeight(parent.left), this.GetHeight(parent.right)) + 1;
        }




    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int Value)
        {
            this.Value = Value;
        }

    }
}
