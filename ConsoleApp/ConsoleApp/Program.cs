// See https://aka.ms/new-console-template for more information
//Modificatiom 1


using System.Collections.Specialized;


Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to console app");
var x =23;
var arr = new int[] { 10, 17, 25, 30, 40, 55, 60, 70 };
double average2 = Queryable.Average(arr.AsQueryable());
Console.WriteLine("Average = "+average2);
//Task 4
var arr2 = Enumerable.Range(0, 10).ToArray();
var max = arr2.Max();
Console.WriteLine($"Maximum value of array is: {max}");
  