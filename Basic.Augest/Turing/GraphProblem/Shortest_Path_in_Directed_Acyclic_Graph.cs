using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Basic.Augest.Turing.GraphProblem.ShortestPath;

namespace Basic.Augest.Turing.GraphProblem
{
    public class Shortest_Path_in_Directed_Acyclic_Graph
    {
        public void Main(String[] args)
        {
            // Create a graph given in the above diagram. Here vertex
            // numbers are 0, 1, 2, 3, 4, 5 with following mappings:
            // 0=r, 1=s, 2=t, 3=x, 4=y, 5=z
            ShortestPath t = new ShortestPath();
            CGraph g = new CGraph(6);
            g.addEdge(0, 1, 5);
            g.addEdge(0, 2, 3);
            g.addEdge(1, 3, 6);
            g.addEdge(1, 2, 2);
            g.addEdge(2, 4, 4);
            g.addEdge(2, 5, 2);
            g.addEdge(2, 3, 7);
            g.addEdge(3, 4, -1);
            g.addEdge(4, 5, -2);

            int s = 1;
            Console.WriteLine("Following are shortest distances " +
                                "from source " + s);
            g.shortestPath(s);
        }
    }

    public class ShortestPath
    {
        static readonly int INF = int.MaxValue;
        public class AdjListNode
        {
            public int v;
            public int weight;
            public AdjListNode(int _v, int _w) { v = _v; weight = _w; }
            public int getV() { return v; }
            public int getWeight() { return weight; }
        }

        // Class to represent graph as an adjacency list of
        // nodes of type AdjListNode
        public class CGraph
        {
            public int V;
            public List<AdjListNode>[] adj;
            public CGraph(int v)
            {
                V = v;
                adj = new List<AdjListNode>[V];
                for (int i = 0; i < v; ++i)
                    adj[i] = new List<AdjListNode>();
            }
            public void addEdge(int u, int v, int weight)
            {
                AdjListNode node = new AdjListNode(v, weight);
                adj[u].Add(node);// Add v to u's list
            }

            // A recursive function used by shortestPath.
            // See below link for details
            public void topologicalSortUtil(int v, Boolean[] visited,
                                            Stack<int> stack)
            {
                // Mark the current node as visited.
                visited[v] = true;

                // Recur for all the vertices adjacent to this vertex
                foreach (AdjListNode it in adj[v])
                {
                    AdjListNode node = it;
                    if (!visited[node.getV()])
                        topologicalSortUtil(node.getV(), visited, stack);
                }

                // Push current vertex to stack which stores result
                stack.Push(v);
            }

            // The function to find shortest paths from given vertex. It
            // uses recursive topologicalSortUtil() to get topological
            // sorting of given graph.
            public void shortestPath(int s)
            {
                Stack<int> stack = new Stack<int>();
                int[] dist = new int[V];

                // Mark all the vertices as not visited
                Boolean[] visited = new Boolean[V];
                for (int i = 0; i < V; i++)
                    visited[i] = false;

                // Call the recursive helper function to store Topological
                // Sort starting from all vertices one by one
                for (int i = 0; i < V; i++)
                    if (visited[i] == false)
                        topologicalSortUtil(i, visited, stack);

                // Initialize distances to all vertices as infinite and
                // distance to source as 0
                for (int i = 0; i < V; i++)
                    dist[i] = INF;
                dist[s] = 0;

                // Process vertices in topological order
                while (stack.Count != 0)
                {
                    // Get the next vertex from topological order
                    int u = (int)stack.Pop();

                    // Update distances of all adjacent vertices
                    if (dist[u] != INF)
                    {
                        foreach (AdjListNode it in adj[u])
                        {
                            AdjListNode i = it;
                            if (dist[i.getV()] > dist[u] + i.getWeight())
                                dist[i.getV()] = dist[u] + i.getWeight();
                        }
                    }
                }

                // Print the calculated shortest distances
                for (int i = 0; i < V; i++)
                {
                    if (dist[i] == INF)
                        Console.Write("INF ");
                    else
                        Console.Write(dist[i] + " ");
                }
            }
        }

        // Method to create a new graph instance through an object
        // of ShortestPath class.
        CGraph newGraph(int number)
        {
            return new CGraph(number);
        }

    }

}
