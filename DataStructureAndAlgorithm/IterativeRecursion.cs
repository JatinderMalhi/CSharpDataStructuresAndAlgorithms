using System;
namespace DataStructureAndAlgorithm
{
    public class IterativeeRecursion
    {
        public void Iterative(int n)
        {
            while (n > 0) {
                int k = n * n;
                Console.WriteLine(k);
                n--;
            }
        }
        public void Recursion(int n)
        {
            if (n > 0) {
                int k = n * n;
                Console.WriteLine(k);
                Recursion(n - 1);
            }
        }
        //Sum of natural numbers
        public int Sum(int n)
        {
            if (n == 0)
                return 0;
            return Sum(n - 1) + n;
        }
        //Factorial calculation
        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return Factorial(n - 1) * n;
        }

    }
}
