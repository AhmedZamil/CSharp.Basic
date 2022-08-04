
// C# program to print BFS traversal
// from a given source vertex.
// BFS(int s) traverses vertices
// reachable from s.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic.Problems
{
    class Graph
    {

        // No. of vertices    
        private int _V;

        LinkedList<int>[] _adj;

        public Graph(int V)
        {
            _adj = new LinkedList<int>[V];

            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _V = V;
        }

        public void AddEdge(int v, int w)
        {

            // Add w to v’s list.
            _adj[v].AddLast(w);
        }

        public int BreadthFirstSearch(int s, int l)
        {

            // Mark all the vertices
            // as not visited
            bool[] visited = new bool[_V];
            int[] level = new int[_V];

            for (int i = 0; i < _V; i++)
            {
                visited[i] = false;
                level[i] = 0;
            }

            // Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as
            // visited and enqueue it
            visited[s] = true;
            level[s] = 0;
            queue.AddLast(s);

            while (queue.Any())
            {

                // Dequeue a vertex from
                // queue and print it
                s = queue.First();

                // Console.Write( s + " " );
                queue.RemoveFirst();

                LinkedList<int> list = _adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        level[val] = level[s] + 1;
                        queue.AddLast(val);
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < _V; i++)
                if (level[i] == l)
                    count++;

            return count;
        }
    }
}
