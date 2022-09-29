// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using Sorting;
int[] arr = HeapSort.Sort(new int[]{ 12, 11, 13, 5, 6, 7 });
Console.WriteLine(string.Join(",",arr));
