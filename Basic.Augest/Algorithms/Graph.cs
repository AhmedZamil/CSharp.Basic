using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Algorithms
{
    // This class represents a directed
    // graph using adjacency list
    // representation
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
            _adj = new LinkedList<int>[V+1];
            for (int i = 1; i < _adj.Length; i++)
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
            int startIndex = 1;

            // Mark all the vertices as not
            // visited(By default set as false)
            bool[] visited = new bool[_V + 1];
            int[] shortestDistances = new int[_V + 1];
            for (int i = 1; i <= _V; i++)
                visited[i] = false;

            for (int i = 1; i <= _V; i++)
                shortestDistances[i] = -1;

            visited[startIndex] = false;
            //shortestDistances[startIndex] = 0;


            // Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();
            queue.AddLast(s);

            // Mark the current node as
            // visited and enqueue it
            visited[s] = true;
            //for (int i=1;i<_V;i++)
            //{
            //     if(i!= s)queue.AddLast(i);
            //}


            while (queue.Any())
            {

                // Dequeue a vertex from queue
                // and print it
                int currentNode = queue.First();
                //Console.Write(s + " ");
                queue.RemoveFirst();

                // Get all adjacent vertices of the
                // dequeued vertex s. If a adjacent
                // has not been visited, then mark it
                // visited and enqueue it
                LinkedList<int> list = new LinkedList<int>();

                list = _adj[currentNode];
                foreach (var val in list)
                {
                    int adjNode = val;
                    int adjIndex = adjNode;

                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                        //if (list != null)
                        //{
                        //    var dist = list.Find(currentNode);
                        //    shortestDistances[adjIndex] = shortestDistances[currentNode - 1] + Int32.Parse(dist);
                        //}

                        shortestDistances[adjIndex] = shortestDistances[currentNode]<0? 0+6: shortestDistances[currentNode] + 6;

                    }


                }
            }

            int[] distances = new int[_V];
            for (int i = 1; i <= _V; i++)
            {
                if (i != s)
                {
                    Console.Write(shortestDistances[i] + " ");
                    //distances[i] = shortestDistances[i];
                }
            }

            //for (int i = 1; i < visited.Length; i++)
            //{
            //    if (i != s)
            //    {
            //        if (visited[i])
            //            Console.Write("6" + " ");
            //        else
            //            Console.Write("-1" + " ");
            //    }

            //}
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
        public void Implement()
        {
            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g.BFS(2);
        }
    }

    // This code is contributed by anv89
}
