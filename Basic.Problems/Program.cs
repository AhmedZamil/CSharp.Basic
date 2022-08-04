// See https://aka.ms/new-console-template for more information
using Basic.Problems;
using Basic.Problems.Code;
using System.Numerics;

Console.WriteLine("Hello, World!");

//string str = string.Empty;
//str = Console.ReadLine();
////BigInteger.Parse(myBigIntegerNumber)
//BigInteger n = BigInteger.Parse(str);

//List<long> nums = new List<long> { 1000000001, 1000000002, 1000000003 ,1000000004, 1000000005 };

////var sum = bigInts.Aggregate(BigInteger.Add);

////BigInteger number = BigInteger.Add(Int64.MaxValue, Int32.MaxValue);
//long number = nums.Aggregate(
//Console.WriteLine(number);


//int arCount = Convert.ToInt32(Console.ReadLine().Trim());

//List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

//long result = 0;
//foreach (long num in ar)
//{

//    result += num;
//}

//Console.WriteLine(result);


//int n = Convert.ToInt32(Console.ReadLine().Trim());

//List<List<int>> arr = new List<List<int>>();

//for (int i = 0; i < n; i++)
//{
//    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//}

//var sumPrimaryDiagonal = 0;
//var sumSecondaryDiagonal = 0;

//int m = 0;
//int k = n - 1;

//Console.WriteLine(Math.Abs(arr
//  .Select((line, index) => line[index] - line[line.Count - 1 - index])
//  .Sum()));
//Math.Abs(arr
//  .Select((line, index) => line[index] - line[line.Count - 1 - index])
//  .Sum());

//foreach (List<int> row in arr)
//{
//    if (m < n) {
//        foreach (int col in row)
//        {
//            if (k == 0) continue;
//            Console.WriteLine(" i :{0} j:{1}", m, k);
//            Console.WriteLine("{0}", col);
//            k--;
//        }
//    }

//    m++;
//}

//for (int i = 0, j = n - 1; i < n; i++, j--)
//{
//    //var a_temp = ReadLine().Split(' ');
//    //var newRow = Array.ConvertAll(a_temp, int.Parse);
//    //sumPrimaryDiagonal += arr[i];
//    //sumSecondaryDiagonal += arr[j];
//}


//for (int i = 0, j = n - 1; i < n; i++, j--)
//{
//    var a_temp = ReadLine().Split(' ');
//    var newRow = Array.ConvertAll(a_temp, int.Parse);
//    sumPrimaryDiagonal += newRow[i];
//    sumSecondaryDiagonal += newRow[j];
//}

//Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal)


//int n = Convert.ToInt32(Console.ReadLine().Trim());

//List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//Solve.plusMinus(arr);
//Result.plusMinus(arr);



//int n = Convert.ToInt32(Console.ReadLine().Trim());
//Solve.staircase(n);



//List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
//Solve.miniMaxSum(arr);

/* You are in charge of the cake for a child's birthday. 
 * You have decided the cake will have one candle for each year of their total age. 
 * They will only be able to blow out the tallest of the candles. 
 * Count how many candles are tallest.*/


//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

//List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

//int result = Solve.birthdayCakeCandles(candles);

//textWriter.WriteLine(result);

//textWriter.Flush();
//textWriter.Close();



//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//string s = Console.ReadLine();

//string result = Solve.timeConversion(s);

//Console.WriteLine(result);

//textWriter.WriteLine(result);

//textWriter.Flush();
//textWriter.Close();


//Graph g = new Graph(6);

// g.AddEdge(0, 1);
// g.AddEdge(0, 2);
// g.AddEdge(1, 3);
// g.AddEdge(2, 4);
// g.AddEdge(2, 5);

// int level = 2;

// Console.WriteLine(g.BreadthFirstSearch(0, level));


//string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//int n = Convert.ToInt32(firstMultipleInput[0]);

//int m = Convert.ToInt32(firstMultipleInput[1]);

//List<long> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt64(cTemp)).ToList();

//// Print the number of ways of making change for 'n' units using coins having the values given by 'c'

//long ways = Solve.findPermutations(n, c);
//Console.WriteLine(ways);




//int t = Convert.ToInt32(Console.ReadLine());

//for (int tItr = 0; tItr < t; tItr++)
//{
//    string s = Console.ReadLine();

//    string result = Solve.isBalanced(s);

//    Console.WriteLine(result);
//}



#region Team Interface

//if (!typeof(Subteam).IsSubclassOf(typeof(Team)))
//{
//    throw new Exception("Sub team should inherit from Team class");
//}

//String str = Console.ReadLine();

//String[] strArr = str.Split();

//string initialName = strArr[0];
//int count = Convert.ToInt32(strArr[1]);

//Subteam teamObj = new Subteam(initialName,count);

//Console.WriteLine("Team " + teamObj.teamName + " Created");

//str = Console.ReadLine();
//count = Convert.ToInt32(str);
//Console.WriteLine("Current number of players in team"+teamObj.teamName+" is "+ teamObj.noOfPlayers);
//teamObj.AddPlayer(count);
//Console.WriteLine("New number of players in team"+teamObj.teamName+" is "+ teamObj.noOfPlayers);

//Console.WriteLine("Current number of players in team" + teamObj.teamName + " is " + teamObj.noOfPlayers);

//str = Console.ReadLine();
//count = Convert.ToInt32(str);
//teamObj.RemovePlayer(count);
//Console.WriteLine("New number of players in team" + teamObj.teamName + " is " + teamObj.noOfPlayers);

//str = Console.ReadLine();

//string oldName = teamObj.teamName;
//teamObj.ChangeTeamName(str);
//Console.WriteLine("Team name of team "+ oldName + " changed to "+teamObj.teamName);




#endregion


#region Employee Management

//int countOfEmployees = int.Parse(Console.ReadLine());

//var employees = new List<Employee>();

//for (int i = 0; i < countOfEmployees; i++)
//{
//    string str = Console.ReadLine();
//    string[] strArr = str.Split(' ');
//    employees.Add(new Employee
//    {
//        FirstName = strArr[0],
//        LastName = strArr[1],
//        Company = strArr[2],
//        Age = int.Parse(strArr[3])
//    });
//}

//EmployeeManagement manager = new EmployeeManagement();

//foreach (var emp in manager.AverageAgeForEachCompany(employees))
//{
//    Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
//}

//foreach (var emp in manager.CountOfEmployeesForEachCompany(employees))
//{
//    Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
//}

//foreach (var emp in manager.OldestAgeForEachCompany(employees))
//{
//    Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
//}

#endregion

#region

//Node head = null;
//int T = Int32.Parse(Console.ReadLine());
//while (T-- > 0)
//{
//    int data = Int32.Parse(Console.ReadLine());
//    head = LinkedList.insert(head, data);
//}
//LinkedList.display(head);


//int n = Convert.ToInt32(Console.ReadLine().Trim());

//string[] inputArr = Console.ReadLine().TrimEnd().Split(' ');

//int[] a = Array.ConvertAll(inputArr, Int32.Parse);

////List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//// Write your code here

//        int numberOfSwaps = 0;
//for (int i = 0; i < n; i++)
//        {
//            /* Track number of elements swapped during 
//            a single array traversal*/


//            for (int j = 0; j < n - 1; j++)
//            {
//                /* Swap adjacent elements if 
//                they are in decreasing order*/
//                if (a[j] > a[j + 1])
//                {
//                   Array.Reverse(a,j,2);
//                    numberOfSwaps++;

//                }
//            }

//            /* If no elements were swapped during a traversal, 
//            array is sorted*/
//            if (numberOfSwaps == 0)
//            {
//                break;
//            }
//        }


//Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
//Console.WriteLine("First Element: " + a.FirstOrDefault());
//Console.WriteLine("Last Element:" + a.LastOrDefault());

#endregion

#region

//Node root = null;
//int T = Int32.Parse(Console.ReadLine());
//while (T-- > 0)
//{
//	int data = Int32.Parse(Console.ReadLine());
//	root = BinarySearchTree.insert(root, data);
//}
//int height = BinarySearchTree.getHeight(root);
//Console.WriteLine(height);
#endregion


#region

//Node root = null;
//int T = Int32.Parse(Console.ReadLine());
//while (T-- > 0)
//{
//    int data = Int32.Parse(Console.ReadLine());
//    root = BFS.insert(root, data);
//}
//BFS.levelOrder(root);

//int n = int.Parse(Console.ReadLine().Trim());
//int result = Solve.Factorial(n);
//Console.WriteLine(result);

Solve.TestWithEmptyArray();
Solve.TestWithUniqueValues();
Solve.TestWithExactlyTwoDifferentMinimums();
Console.WriteLine("OK");

#endregion



