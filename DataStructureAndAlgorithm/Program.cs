using System;

namespace DataStructureAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            DateTime dateTime = DateTime.Now;
            IterativeeRecursion iterative = new();
            iterative.Iterative(n);
            DateTime dateTime1 = DateTime.Now;
            Console.WriteLine("Iterative approach took time: " + (dateTime1.Millisecond - dateTime.Millisecond) + (" MIlliseconds"));

            DateTime dateTime2 = DateTime.Now;
            iterative.Recursion(n);
            DateTime dateTime3 = DateTime.Now;
            Console.WriteLine("Recursion approach took time: " + (dateTime3.Millisecond - dateTime2.Millisecond) + (" MIlliseconds"));
            Console.ReadKey();
        }
    }
}
