// See https://aka.ms/new-console-template for more information


using Basic.Augest.Algorithms;
using Basic.Augest.Arrays;
using Basic.Augest.Collections;
using Basic.Augest.Generices;
using Basic.Augest.HackerRank;
using Basic.Augest.LinkedLists;
using Basic.Augest.Stack;
using Basic.Augest.Tree;
using Basic.Augest.Turing;
using Basic.Augest.Turing.Arrays;
using Basic.Augest.Turing.GraphProblem;
using Basic.Augest.Turing.Recursion;
using Basic.Augest.Turing.SAMPLE;
using System.Numerics;
using static Basic.Augest.Algorithms.Tree;

//UseGenerices.Implement();
//ArrayListUse.Use();
//SortedListUse.Use();
//HashTableUse.Use();
//ListUse.BasicUse();


//Day11_2D.solution();
//Day7_Array.solution();
//Day8_Dictonary_Maps.Solution();
//Day12_Inheritance.Solution();

//LinkedList.Implementation();
//BST.Implementation();

//BinarySearchTree bst = new BinarySearchTree();
//bst.Implement();

//Tree BST = new Tree();
//BST.Insert(3);
//BST.Insert(5);
//BST.Insert(4);
//BST.Insert(7);
//BST.Insert(2);
//BST.Insert(1);



//Node root = BST.ReturnRoot();
//int T = Int32.Parse(Console.ReadLine());
//while (T-- > 0)
//{
//    int data = Int32.Parse(Console.ReadLine());
//    root = insert(root, data);
//}
//BST.levelOrder(root);


//Console.WriteLine("Inorder Traversal : ");
//BST.InorderTraverse(BST.ReturnRoot());
//Console.WriteLine(" ");
//Console.WriteLine();


//Problem_Apples_Oranges.Implement();

//int x1=0, v1=2, x2=5, v2=3;



//var firstSet = new BigInteger[10000+10000];
//var secondSet = new BigInteger[10000 + 10000];
//for (int i=0;i<10000;i++)
//{
//    x1 = x1 + v1;
//    firstSet[i] = x1;
//}
//for (int i = 0; i < 10000; i++)
//{
//    x2 = x2 + v2;
//    secondSet[i] = x2;
//}

//bool meet = false;
//for (int i=0; i< firstSet.Length-1;i++)
//{
//    if ((firstSet[i] >0 && secondSet[i] >0) && ( firstSet[i] == secondSet[i]))
//    { 
//     meet = true;
//        break;
//    }
//}

//if (meet)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}

//Graph graph = new Graph();

//int q = Convert.ToInt32(Console.ReadLine());

//for (int j=0;j<q;j++)
//{
//    string[] nm = Console.ReadLine().TrimEnd().Split(' ');

//    int n = Convert.ToInt32(nm[0]);

//    Graph g = new Graph(n);

//    int m = Convert.ToInt32(nm[1]);

//    //int[] u=new int[m];
//    for (int i = 0; i < m; i++)
//    {
//        string[] uv = Console.ReadLine().TrimEnd().Split(' ');
//        int u = Convert.ToInt32(uv[0]);
//        int v = Convert.ToInt32(uv[1]);
//        g.AddEdge(u, v);
//        g.AddEdge(v, u);
//        //u[i]=Convert.ToInt32(Console.ReadLine());
//    }

//    int s = Convert.ToInt32(Console.ReadLine());
//    g.BFS(s);
//    Console.WriteLine();

//}



//Graph g = new Graph(4);

//g.AddEdge(0, 1);
//g.AddEdge(0, 2);
//g.AddEdge(1, 2);
//g.AddEdge(2, 0);
//g.AddEdge(2, 3);
//g.AddEdge(3, 3);

//Console.Write("Following is Breadth First " +
//              "Traversal(starting from " +
//              "vertex 2)\n");
//g.BFS(2);



//graph.Implement();

//Prob_2DArray_DS solution = new Prob_2DArray_DS();

//solution.Solution();
//Prob_LeftRotation prob = new Prob_LeftRotation();
//prob.Solution();

//Prob_ArrayDS.Solution();

//Prob_PrintLinkedList problem = new Prob_PrintLinkedList();
//problem.Solution();

//Prob_InsertNodeAtTail prob = new Prob_InsertNodeAtTail();
//prob.Solution();




//char[] space = new char[] { ' ' };

//Practice_1 solution = new Practice_1();
//string[] ops = { "5","-2","4","C","D","9","+","+" };
// -2 -5 -6 -7  + D C 8 8 9 8 + D
//string[] ops = { "-2", "-5", "-6", "-7", "D", "C","8","8", "9","+", "D" };

//int result = solution.CalPoints(ops);

//Console.WriteLine(result);

//char[] exp = { '{', '(', ')', '[', ']' };

//// Function call
//if (solution.areBracketsBalanced(Console.ReadLine()))
//Console.WriteLine("Balanced ");
//else
//Console.WriteLine("Not Balanced ");

//Prob_InsertNodeAtHead prob = new Prob_InsertNodeAtHead();
//prob.Solution();


//Prob_Tree treeProblem = new Prob_Tree();

//treeProblem.Solution();


//Prob_Balanced_Brackets solution = new Prob_Balanced_Brackets();
//solution.Main();

//Pro_MaxNumber solution = new Pro_MaxNumber();
//solution.Main();

//Maximum_Occuerrence_Of_Letter prob = new Maximum_Occuerrence_Of_Letter();

//prob.Main();

//BinaryTree_Heighest_Depth prob = new BinaryTree_Heighest_Depth();
//prob.Main();

//Special_two_digit_number prob = new Special_two_digit_number();

//prob.Main();


//SpecialInteger prob = new SpecialInteger();

//prob.Main();

//GraphProblem graph = new GraphProblem();
//graph.Main();

//Minimum_Cost_To_Connect_Cities prob = new Minimum_Cost_To_Connect_Cities();
//prob.Main();


//SortedArray_Search_Insert_Delete prob = new SortedArray_Search_Insert_Delete();
//prob.Main();


//Shortest_Path_Implementation prob = new Shortest_Path_Implementation();
//prob.Main();

//Find_The_Judge prob = new Find_The_Judge();
//prob.Main();


//Winning_Card prob = new Winning_Card();

//prob.Main();

//ReverseOnlyLetters prob = new ReverseOnlyLetters();

//prob.Main();

//Max_Depth_Binary_Tree prob = new Max_Depth_Binary_Tree();

//prob.Main();

NumSeries prob = new NumSeries();

prob.Main();



Console .ReadLine();