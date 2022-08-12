using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.GraphProblem
{
    public class Detecting_Cycle_In_A_Graph
    {
        // Driver Code
        public void Main(String[] args)
        {
            // Create a graph given in the above diagram
            CyclicGraph g1 = new CyclicGraph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(2, 1);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);
            if (g1.isCyclic())
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine(
                    "Graph doesn't contains cycle");

            CyclicGraph g2 = new CyclicGraph(3);
            g2.addEdge(0, 1);
            g2.addEdge(1, 2);
            if (g2.isCyclic())
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine(
                    "Graph doesn't contains cycle");
        }
    }

    public class CyclicGraph {

        private int V; // No. of vertices

        // Adjacency List Representation
        private List<int>[] adj;

        // Constructor
       public CyclicGraph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // Function to add an edge into the graph
        public void addEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);
        }

        // A recursive function that uses visited[]
        // and parent to detect cycle in subgraph
        // reachable from vertex v.
        public Boolean isCyclicUtil(int v, Boolean[] visited,
                             int parent)
        {
            // Mark the current node as visited
            visited[v] = true;

            // Recur for all the vertices
            // adjacent to this vertex
            foreach (int i in adj[v])
            {
                // If an adjacent is not visited,
                // then recur for that adjacent
                if (!visited[i])
                {
                    if (isCyclicUtil(i, visited, v))
                        return true;
                }

                // If an adjacent is visited and
                // not parent of current vertex,
                // then there is a cycle.
                else if (i != parent)
                    return true;
            }
            return false;
        }

        // Returns true if the graph contains
        // a cycle, else false.
        public Boolean isCyclic()
        {
            // Mark all the vertices as not visited
            // and not part of recursion stack
            Boolean[] visited = new Boolean[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            // Call the recursive helper function
            // to detect cycle in different DFS trees
            for (int u = 0; u < V; u++)

                // Don't recur for u if already visited
                if (!visited[u])
                    if (isCyclicUtil(u, visited, -1))
                        return true;

            return false;
        }
    }
}
