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
                n = n - 1;
            }
        }

        public void Recursion(int n)
        {
            if (n > 0) {
                int k = n * n;
                Console.WriteLine(k);
                Iterative(n - 1);
            }
        }
    }
}
