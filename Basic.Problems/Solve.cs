using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Problems
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;


        // Add your code here
        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public int computeDifference()
        {
            int maxElement = elements[0];
            int minElement = elements[0];

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < minElement)
                {
                    minElement = elements[i];

                }
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }
            maximumDifference = Math.Abs(maxElement - minElement);
            return maximumDifference;
        }
    }





    public static class Solve
    {

        public static int minimum_index(int[] seq)
        {
            if (seq.Length == 0)
            {
                throw new ArgumentException("Cannot get the minimum value index from an empty sequence");
            }
            int min_idx = 0;
            for (int i = 1; i < seq.Length; ++i)
            {
                if (seq[i] < seq[min_idx])
                {
                    min_idx = i;
                }
            }
            return min_idx;
        }

        static class TestDataEmptyArray
        {
            public static int[] get_array()
            {
                // complete this function
                return new int[] { };
            }
        }

        static class TestDataUniqueValues
        {
            public static int[] get_array()
            {
                // complete this function
                return new int[] {
                1,
                2,
                3,
                4,
                5
            };
            }

            public static int get_expected_result()
            {
                // complete this function
                return minimum_index(get_array());
            }
        }

        static class TestDataExactlyTwoDifferentMinimums
        {
            public static int[] get_array()
            {
                // complete this function
                return new int[] {
                1,
                2,
                3,
                4,
                3,
                2,
                1
            };
            }

            public static int get_expected_result()
            {
                // complete this function
                return minimum_index(get_array());
            }
        }

        // Below is given
        public static void TestWithEmptyArray()
        {
            try
            {
                int[] seq = TestDataEmptyArray.get_array();
                int result = minimum_index(seq);
            }
            catch (ArgumentException e)
            {
                return;
            }
            //throw new AssertionError("Exception wasn't thrown as expected");
            Assert.Fail("Exception wasn't thrown as expected");
        }

        public static void TestWithUniqueValues()
        {
            int[] seq = TestDataUniqueValues.get_array();
            if (seq.Length < 2)
            {
                //throw new AssertionError("less than 2 elements in the array");
                Assert.Fail("less than 2 elements in the array");
            }

            int[] tmp = new int[seq.Length];
            for (int i = 0; i < seq.Length; ++i)
            {
                tmp[i] = int.Parse(seq[i].ToString());
            }
            if (!((new HashSet<int>(tmp.ToList())).Count() == seq.Length))
            {
                //throw new AssertionError("not all values are unique");
                Assert.Fail("not all values are unique");
            }

            int expected_result = TestDataUniqueValues.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                Assert.Fail("result is different than the expected result");
                //throw new AssertionError("result is different than the expected result");
            }
        }

        public static void TestWithExactlyTwoDifferentMinimums()
        {
            int[] seq = TestDataExactlyTwoDifferentMinimums.get_array();
            if (seq.Length < 2)
            {
                //throw new AssertionError("less than 2 elements in the array");
                Assert.Fail("less than 2 elements in the array");
            }
            
            int[] tmp = (int[])seq.Clone();
            Array.Sort(tmp);
            if (!(tmp[0] == tmp[1] && (tmp.Length == 2 || tmp[1] < tmp[2])))
            {
                Assert.Fail("there are not exactly two minimums in the array");
                //throw new AssertionError("there are not exactly two minimums in the array");
            }

            int expected_result = TestDataExactlyTwoDifferentMinimums.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                Assert.Fail("result is different than the expected result");
                //throw new AssertionError("result is different than the expected result");
            }
        }







        public static int Factorial(int n)
        {
            if (n <= 1)
                return 1;

            return n * Factorial(n-1);
        }

        public static void plusMinus(List<int> arr)
        {
            List<int> pos = arr.FindAll(x => x>0);
            List<int> neg = arr.FindAll(x => x < 0);
            List<int> zer = arr.FindAll(x => x == 0);
            Console.WriteLine((Convert.ToDouble(pos.Count)/ Convert.ToDouble(arr.Count)).ToString("N6"));
            Console.WriteLine((Convert.ToDouble(neg.Count) / Convert.ToDouble(arr.Count)).ToString("N6"));
            Console.WriteLine((Convert.ToDouble(zer.Count) / Convert.ToDouble(arr.Count)).ToString("N6"));

        }

        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {                
                for (int k = 1; k < n - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                if(i<n-1)Console.WriteLine();
            }

        }

        public static void miniMaxSum(List<int> arr)
        {
            long minVal = 0;
            long maxVal = 0;
            arr.Sort();
            int count = 0;
            foreach (int val in arr) {
                if (count < 4) {
                    minVal += val;
                }
                count++;
            }

            Console.Write(minVal);
            Console.Write(" ");
            count = 0;

            foreach (int val in arr)
            {
                if (count > 0)
                {
                    maxVal += val; 
                }
                count++;
            }

            Console.Write(maxVal);

        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            long maxVal= candles.Max();
            List<int> maxArr = candles.FindAll(v => v == maxVal);
            return maxArr.Count;
        }

        public static string timeConversion(string s)
        {
            DateTime dt = DateTime.Parse(s);
            return dt.ToString("HH:mm:ss");
        }


        public static long findPermutations(int n, List<long>  c)
        {

            // The 2-dimension buffer will contain answers to this question:
            // "how much permutations is there for an amount of `i` cents, and `j`
            // remaining coins?" eg. `buffer[10][2]` will tell us how many permutations
            // there are when giving back 10 cents using only the first two coin types
            // [ 1, 2 ].
            long[][] buffer = new long[n + 1][];
            for (var i = 0; i <= n; ++i)
                buffer[i] = new long[c.Count + 1];

            // For all the cases where we need to give back 0 cents, there's exactly
            // 1 permutation: the empty set. Note that buffer[0][0] won't ever be
            // needed.
            for (var j = 1; j <= c.Count; ++j)
                buffer[0][j] = 1;

            // We process each case: 1 cent, 2 cent, etc. up to `n` cents, included.
            for (int i = 1; i <= n; ++i)
            {

                // No more coins? No permutation is possible to attain `i` cents.
                buffer[i][0] = 0;

                // Now we consider the cases when we have J coin types available.
                for (int j = 1; j <= c.Count; ++j)
                {

                    // First, we take into account all the known permutations possible
                    // _without_ using the J-th coin (actually computed at the previous
                    // loop step).
                    var value = buffer[i][j - 1];

                    // Then, we add all the permutations possible by consuming the J-th
                    // coin itself, if we can.
                    if (c[j - 1] <= i)
                        value += buffer[i - c[j - 1]][j];

                    // We now know the answer for this specific case.
                    buffer[i][j] = value;
                }
            }

            // Return the bottom-right answer, the one we were looking for in the
            // first place.
            return buffer[n][c.Count];
        }

        public static long getWays(int n, List<long> c)
        {
            long[] numCoins = new long[n + 1];
            numCoins[0] = 1;
            for (int i = 0; i < c.Count; i++)
            {
                foreach (long val in c)
                {
                    long j = val;
                    while (j < numCoins.Length)
                    {
                        numCoins[j] += numCoins[j - val];
                        j++;
                    }

                }
                //for (int j = coins[i]; j < numCoins.length; j++)
                //{
                //    numCoins[j] += numCoins[j - coins[i]];
                //}
            }
            return numCoins[n];
        }


        public static long getWays(long n, List<long> c)
        {
            int m = c.Count;
            //if (numCoins === undefined) { numCoins = coins.Count; }
            if (n == 0) { return 1; }
            if (n < 0) { return 0; }
            if (m <= 0 && n > 0) { return 0; }
            return getWay(n, m - 1, c) + getWay( n - c[m - 1], m, c);
        }

        public static long getWay(long n, int m, List<long> c)
        {
            //if (numCoins === undefined) { numCoins = coins.Count; }
            if (n == 0) { return 1; }
            if (n < 0) { return 0; }
            if (m <= 0 && n > 0) { return 0; }
            return getWay(n, m - 1, c) + getWay(n - c[m - 1], m, c);
        }


        public static string isBalanced(string s)
        {
            var openings = new[] { '[', '{', '(' };

            var stack = new Stack<char>();

            foreach (var c in s.ToCharArray())
            {
                if (openings.Contains(c))
                    stack.Push(c);

                else if (c == ']')
                    if (!TryPeek(stack, out var c1) || c1 != '[')
                        return "NO";
                    else
                        stack.Pop();

                else if (c == ')')
                    if (!TryPeek(stack, out var c2) || c2 != '(')
                        return "NO";
                    else
                        stack.Pop();

                else if (c == '}')
                    if (!TryPeek(stack, out var c3) || c3 != '{')
                        return "NO";
                    else
                        stack.Pop();
            }

            return stack.Count == 0 ? "YES" : "NO";
        }

        public static bool TryPeek(Stack<char> stack, out char value)
        {
            value = default(char);

            if (stack.Count == 0) return false;

            value = stack.Peek();
            return true;
        }

        public static int migratoryBirds(List<int> arr)
        {
            arr.Sort();

            List<int> birds1 = new List<int>();
            List<int> birds2 = new List<int>();
            List<int> birds3 = new List<int>();
            List<int> birds4 = new List<int>();
            List<int> birds5 = new List<int>();

            birds1 = arr.FindAll(bird=> bird==1);
            birds2 = arr.FindAll(bird => bird == 2) ;
            birds3 = arr.FindAll(bird => bird == 3);
            birds4 = arr.FindAll(bird => bird == 4);
            birds5 = arr.FindAll(bird => bird == 5);


            SortedList<int,int> birds = new SortedList<int, int>();


            birds.Add(1, birds1.Count);
            birds.Add( 2, birds2.Count);
            birds.Add( 3, birds3.Count);
            birds.Add(4, birds4.Count);
            birds.Add( 5, birds5.Count);
            //birds.Add( birds5.Count,5);

            //KeyValuePair<int,int> maxVal = birds.Max<KeyValuePair<int,int>>(b => b.Value == birds.Values.Max());
            //int maxKey = birds.Values.Max().GetKey();
            int maxKey = birds.Keys.Max();
            int maxVal = birds.Values.Max();

            int index = birds.IndexOfValue(birds.Values.Max());


            return index+1;
        }

        public static int jumpingOnClouds(List<int> c)
        {
            int jumpCount = 0;
            int maxJump = 2;
            bool nojump = false;

            int i = 0;

            while (i< c.Count && !nojump) {
                nojump = true;
                for (int j = maxJump; j>0; j--)
                {
                    if ( i+j < c.Count && c[i+j] == 0)
                    {
                        jumpCount++;
                        i = i + j;
                        nojump = false;
                        break;
                    }
                    
                }
               
            
            }

            return jumpCount;
        }


    }
}
