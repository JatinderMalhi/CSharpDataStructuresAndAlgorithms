using System;
namespace DataStructureAndAlgorithm
{
    public class SearchAlgo
    {
        //Linear search algorithm or sequential search
        public int LinearSearch(int[] array, int element)
        {
            int i = 0;
            for (i = 0; i < array.Length; i++) {
                if (array[i] == element)
                    return i;
            }
            return -1;
        }
    }
}
