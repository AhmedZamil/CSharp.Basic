// See https://aka.ms/new-console-template for more information
using Basic.Abstraction;
using Basic.Collections.Generic;
using Basic.Collections.Non_Generic;
using Basic.Delegates;
using Basic.Events;
using Basic.Generics.Class;
using Basic.Generics.Field;
using Basic.Generics.Methods;
using Basic.Polymorphism;


#region GENERICS


//#1 . Generic Class with properties & Type Parameter , Instantiation 

DataStore<string> store = new DataStore<string>();

store.Data = "C# Basic";


DataStore<int> storeINT = new DataStore<int>();

storeINT.Data = 1000;

//Console.WriteLine(storeINT.Data);
Console.WriteLine();
Console.ReadLine();


KeyValue<string, int> pair = new KeyValue<string, int>();

pair.Key = "B&H";
pair.Value = 16;

//Console.WriteLine();
//Console.WriteLine("Name: "+ pair.Key);
//Console.WriteLine("Price: "+ pair.Value);

//Console.ReadLine();


Store<string> storeA = new Store<string>();
storeA.Data =  new string[]{ "B&H","Gold Leaf","Gold Flex", "NEVY"};


Console.WriteLine();
foreach (string item in storeA.Data)
{
    //Console.WriteLine("Name: " + item);
}


DataStorage<string> cities = new DataStorage<string>();

cities.AddOrUpdate(0,"Dhaka");
cities.AddOrUpdate(1, "Stolkhome");
cities.AddOrUpdate(2, "Lisbon");
cities.AddOrUpdate(3, "Tokeyo");
cities.AddOrUpdate(4, "Berlin");

//foreach (var city in cities.Data) {
//    Console.WriteLine(city);
//}

NonGeneric nongeneric = new NonGeneric();

//nongeneric.Print<string>("Gold Leaf");
//nongeneric.Print<int>(350);


//Array_List.Use_Array_List();
//Sorted_List.Use_SortedList();
//Dictonary.Use_Dictonary();
//Hash_Table.Use_HashTable();
//Stack.Use_Stack();
//Queue.Use_Queue();
//DelegateTest.Use_Delegate();

//Function.Use_Function();
//EventSubscribe.Consume_Event();

Polymorphism.Use();
Abstraction.Use();
Interface.Use();

Console.ReadLine();

#endregion







//I/O

Console.WriteLine(store.Data);
Console.WriteLine();
Console.ReadLine();
