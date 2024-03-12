// See https://aka.ms/new-console-template for more information
//Modificatiom 1


using System.Collections.Specialized;
using Microsoft.VisualBasic.CompilerServices;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to console app");
var x =23;
var arr = new int[] { 10, 17, 25, 30, 40, 55, 60, 70 };
double avg = Queryable.Average(arr.AsQueryable());
Console.WriteLine("Average = "+avg);
