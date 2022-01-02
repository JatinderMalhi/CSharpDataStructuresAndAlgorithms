using System;

namespace DataStructureAndAlgorithm
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            foreach (var item in array) {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            int n = 9;
            SearchAlgo searchAlgo = new();
            Sorting sorting = new();
            /*DateTime dateTime = DateTime.Now;
             IterativeeRecursion iterative = new();
            IterativeeRecursion iterative = new();
            iterative.Iterative(n);
            DateTime dateTime1 = DateTime.Now;
            Console.WriteLine("Iterative approach took time: " + (dateTime1.Millisecond - dateTime.Millisecond) + (" MIlliseconds"));

            DateTime dateTime2 = DateTime.Now;
            iterative.Recursion(n);
            DateTime dateTime3 = DateTime.Now;
            Console.WriteLine("Recursion approach took time: " + (dateTime3.Millisecond - dateTime2.Millisecond) + (" MIlliseconds"));
            
            Console.WriteLine("Sum: " +   iterative.Sum(n));
            Console.WriteLine("Factorial: " + iterative.Factorial(n));*/
            int[] arrayLinear = new int[n];
            Random randnum = new();
            for (int i = 0; i < arrayLinear.Length; i++) {
                arrayLinear[i] = randnum.Next(0, 100);
            }
            //Console.WriteLine("Element present at index: " + searchAlgo.LinearSearch(arrayLinear, randnum.Next(0, 20)));
            //Array.Sort(arrayLinear);

            //Console.WriteLine("Element present at index: " + searchAlgo.BinarySearch(arrayLinear, randnum.Next(0, 20)));
            //Console.WriteLine("Element present at index: " + searchAlgo.BinarySearch_Rec(arrayLinear, randnum.Next(0, 20), 0, arrayLinear.Length - 1));
            Program.PrintArray(arrayLinear);
            Console.WriteLine("\n");
            //sorting.SelectionSort(arrayLinear);
            //sorting.InsertionSort(arrayLinear);
            //sorting.BubbleSort(arrayLinear);
            //sorting.ShellSort(arrayLinear);
            sorting.Quicksort(arrayLinear, 0, arrayLinear.Length - 1);
            Program.PrintArray(arrayLinear);
            Console.ReadKey();
        }
    }
}
