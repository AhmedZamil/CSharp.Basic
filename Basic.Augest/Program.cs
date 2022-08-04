// See https://aka.ms/new-console-template for more information


using Basic.Augest.Algorithms;
using Basic.Augest.Collections;
using Basic.Augest.Generices;
using Basic.Augest.HackerRank;
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

Tree BST = new Tree();
BST.Insert(3);
BST.Insert(5);
BST.Insert(4);
BST.Insert(7);
BST.Insert(2);
BST.Insert(1);



Node root = BST.ReturnRoot();
//int T = Int32.Parse(Console.ReadLine());
//while (T-- > 0)
//{
//    int data = Int32.Parse(Console.ReadLine());
//    root = insert(root, data);
//}
BST.levelOrder(root);


//Console.WriteLine("Inorder Traversal : ");
//BST.InorderTraverse(BST.ReturnRoot());
//Console.WriteLine(" ");
Console.WriteLine();


Console.ReadLine();