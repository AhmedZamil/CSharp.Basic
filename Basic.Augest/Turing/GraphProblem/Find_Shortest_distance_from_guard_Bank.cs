using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.Turing.GraphProblem
{

    //Given a matrix that is filled with ‘O’, ‘G’, and ‘W’ where ‘O’ represents open space, ‘G’ represents guards and ‘W’ represents walls in a Bank. Replace all of the O’s in the matrix with their shortest distance from a guard, without being able to go through any walls. Also, replace the guards with 0 and walls with -1 in output matrix.
    public class Find_Shortest_distance_from_guard_Bank
    {



    }

    public class Node
    {
        public int i, j, dist;
        public Node(int i, int j, int dist)
        {
            this.i = i;
            this.j = j;
            this.dist = dist;
        }
    }

    public class MinDistanceFromaGuardInBank
    {

        // Store dimensions of the matrix
        public int M = 5;
        public int N = 5;

        // These arrays are used to get row
        // and column numbers of 4 neighbors
        // of a given cell
        public int[] row = { -1, 0, 1, 0 };
        public int[] col = { 0, 1, 0, -1 };


        // Driver code
        public void Main()
        {
            char[,] matrix ={ { 'O', 'O', 'O', 'O', 'G' },
                     { 'O', 'W', 'W', 'O', 'O' },
                     { 'O', 'O', 'O', 'W', 'O' },
                     { 'G', 'W', 'W', 'W', 'O' },
                     { 'O', 'O', 'O', 'O', 'G' } };

            findDistance(matrix);
        }

        // Function to replace all of the O's
        // in the matrix with their shortest
        // distance from a guard
        public void findDistance(char[,] matrix)
        {
            int[,] output = new int[M, N];
            Queue<Node> q = new Queue<Node>();

            // Finding Guards location and
            // adding into queue
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    // Initialize each cell as -1
                    output[i, j] = -1;

                    if (matrix[i, j] == 'G')
                    {
                        q.Enqueue(new Node(i, j, 0));

                        // Guard has 0 distance
                        output[i, j] = 0;
                    }
                }
            }

            // Do till queue is empty
            while (q.Count != 0)
            {
                // Get the front cell in the queue
                // and update its adjacent cells
                Node curr = q.Peek();

                int x = curr.i;
                int y = curr.j;
                int dist = curr.dist;

                // Do for each adjacent cell
                for (int i = 0; i < 4; i++)
                {

                    // If adjacent cell is valid, has
                    // path and not visited yet,
                    // en-queue it.     
                    if (isValid(x + row[i], y + col[i]))
                    {
                        if (isSafe(x + row[i], y + col[i], matrix, output))
                        {
                            output[x + row[i], y + col[i]] = dist + 1;
                            q.Enqueue(new Node(x + row[i], y + col[i], dist + 1));
                        }
                    }
                }

                // Dequeue the front cell as
                // its distance is found
                q.Dequeue();

            }

            // Print output matrix
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(output[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Return true if row number and
        // column number is in range

        public bool isValid(int i, int j)
        {
            if ((i < 0 || i > M - 1) || (j < 0 || j > N - 1))
                return false;

            return true;
        }

        // Return true if current cell is
        // an open area and its distance
        // from guard is not calculated yet

        public bool isSafe(int i, int j, char[,] matrix, int[,] output)
        {
            if (matrix[i, j] != 'O' || output[i, j] != -1)
            {
                return false;
            }
            return true;
        }


    }

    }
