// See https://aka.ms/new-console-template for more information
using CodingPractice;

Console.WriteLine("Hello, World!");

LinqPractice practice = new LinqPractice();
var list = practice.LinqSort();
Console.WriteLine("\nLinq Sort");
LinqPractice.PrintList(list);


var list2 = practice.BasicComparatorSort();
Console.WriteLine("\nBasic Comparator Sort");
LinqPractice.PrintList(list2);

var list3 = practice.SortByTwoElements();
Console.WriteLine("\nSort By Two Elements");
LinqPractice.PrintList(list3);



//TODO:
//Brush up on the following:
//1. Linq: Specifically comparisons.  Linq comparison and one where you write you own compare method.
//2. Delegates: Write a delegate using the "Func" keyword.  Also just figure out delegates in general
//3. Generics: Write a method that accepts a generic as one of the method params.  
//4. SQL Aggregates: Can't really do that here!  But that's something I should really work on in general