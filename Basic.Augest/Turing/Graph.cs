using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing
{
    public class GraphProblems
    {

        public void Main()
        {
            int V =Int32.Parse(Console.ReadLine());

            Graph g = new Graph(V);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.WriteLine("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g.BFS(2);
            Console.WriteLine();
            Console.WriteLine("Following is Depth First " +
              "Traversal(starting from " +
              "vertex 2)\n");

            g.DFS(2);

        }

        public class Graph
        {

            // No. of vertices    
            private int _V;

            //Adjacency Lists
            LinkedList<int>[] _adj;
            public Graph()
            {

            }

            public Graph(int V)
            {
                _adj = new LinkedList<int>[V + 1];
                for (int i = 0; i < _adj.Length; i++)
                {
                    _adj[i] = new LinkedList<int>();
                }
                _V = V;
            }

            // Function to add an edge into the graph
            public void AddEdge(int v, int w)
            {
                _adj[v].AddLast(w);

            }

            // Prints BFS traversal from a given source s

            

            public void BFS(int s)
            {

                // Mark all the vertices as not
                // visited(By default set as false)
                bool[] visited = new bool[_V];
                for (int i = 0; i < _V; i++)
                    visited[i] = false;

                // Create a queue for BFS
                LinkedList<int> queue = new LinkedList<int>();

                // Mark the current node as
                // visited and enqueue it
                visited[s] = true;
                queue.AddLast(s);

                while (queue.Any())
                {

                    // Dequeue a vertex from queue
                    // and print it
                    s = queue.First();
                    Console.Write(s + " ");
                    queue.RemoveFirst();

                    // Get all adjacent vertices of the
                    // dequeued vertex s. If a adjacent
                    // has not been visited, then mark it
                    // visited and enqueue it
                    LinkedList<int> list = _adj[s];

                    foreach (var val in list)
                    {
                        if (!visited[val])
                        {
                            visited[val] = true;
                            queue.AddLast(val);
                        }
                    }
                }
            }

            // A function used by DFS
            void DFSUtil(int v, bool[] visited)
            {
                // Mark the current node as visited
                // and print it
                visited[v] = true;
                Console.Write(v + " ");

                // Recur for all the vertices
                // adjacent to this vertex
                LinkedList<int> vList = _adj[v];
                foreach (var n in vList)
                {
                    if (!visited[n])
                        DFSUtil(n, visited);
                }
            }

            // The function to do DFS traversal.
            // It uses recursive DFSUtil()
            public void DFS(int v)
            {
                // Mark all the vertices as not visited
                // (set as false by default in c#)
                bool[] visited = new bool[_V];

                // Call the recursive helper function
                // to print DFS traversal
                DFSUtil(v, visited);
            }

            //public int distance(int u, int v)
            //{
            //    return adjacencyMatrix[u - 1][v - 1];
            //}
            //public void BFS(int s)
            //{

            //    // Mark all the vertices as not
            //    // visited(By default set as false)
            //    bool[] visited = new bool[_V+1];
            //    int[] visitedCount = new int[_V + 1];
            //    for (int i = 1; i <= _V; i++)
            //        visited[i] = false;

            //    // Create a queue for BFS
            //    LinkedList<int> queue = new LinkedList<int>();

            //    // Mark the current node as
            //    // visited and enqueue it
            //    visited[s] = true;
            //    queue.AddLast(s);

            //    while (queue.Any())
            //    {

            //        // Dequeue a vertex from queue
            //        // and print it
            //        s = queue.First();
            //        //Console.Write(s + " ");
            //        queue.RemoveFirst();

            //        // Get all adjacent vertices of the
            //        // dequeued vertex s. If a adjacent
            //        // has not been visited, then mark it
            //        // visited and enqueue it
            //        LinkedList<int> list = _adj[s];

            //        foreach (var val in list)
            //        {
            //            if (!visited[val])
            //            {
            //                visited[val] = true;
            //                queue.AddLast(val);
            //            }
            //            else
            //            {
            //                visitedCount[val] += 6;
            //            }

            //        }
            //    }

            //    for (int i=1;i<visited.Length;i++)
            //    {
            //        if (i != s )
            //        {
            //            if (visited[i])
            //                Console.Write("6" + " ");
            //            else
            //                Console.Write("-1"+" ");
            //        }

            //    }
            //}

            // Driver code
        }


    }

}
