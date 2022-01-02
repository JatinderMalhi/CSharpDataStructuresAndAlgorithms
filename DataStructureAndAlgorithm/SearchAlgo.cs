using System;
namespace DataStructureAndAlgorithm
{
    public class SearchAlgo
    {
        //Linear search algorithm or sequential search
        public int LinearSearch(int[] array, int element)
        {
            int i;
            for (i = 0; i < array.Length; i++) {
                if (array[i] == element)
                    return i;
            }
            return -1;
        }
        //Binary search using iteration
        public int BinarySearch(int[] array, int element)
        {
            int l = 0;
            int r = array.Length - 1;
            while (l <= r) {
                int m = (int)Math.Floor((l + r) / 2.0);
                if (element == array[m])
                    return m;
                else if (element < array[m])
                    r = m - 1;
                else if (element > array[m])
                    l = m + 1;

            }
            return -1;
        }
        //Binary search using recursion
        public int BinarySearch_Rec(int[] array, int element, int l, int r)
        {
            if (l > r)
                return -1;
            else {
                int m = (int)Math.Floor((l + r) / 2.0);
                if (element == array[m])
                    return m;
                else if (element < array[m])
                    return BinarySearch_Rec(array, element, l, m - 1);
                else if (element > array[m])
                    return BinarySearch_Rec(array, element, m + 1, r);
            }
            return -1;
        }
    }
}
