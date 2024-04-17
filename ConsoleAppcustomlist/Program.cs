using ConsoleAppcustomlist;
using System;
using System.Collections.Generic;



public class Program
{
    static void Main(string[] args)
    {
        CustomList<int> myList = new CustomList<int>();

        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);

 

        Console.WriteLine("Count: " + myList.Count());

        Console.WriteLine("Items:");
        myList.Print();

        Console.WriteLine("Remove  3 cunu: " + myList.Remove(3));

        Console.WriteLine("Count: " + myList.Count());

        Console.WriteLine("Items:");
        myList.Print();

       
    }
}
