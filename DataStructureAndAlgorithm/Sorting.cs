using System;
using System.Net.Http.Headers;

namespace DataStructureAndAlgorithm
{
    public class Sorting
    {
        private bool flag;

        //Selection Sorting
        public void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) {
                int position = i;
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[j] < array[position])
                        position = j;
                    int temp = array[i];
                    array[i] = array[position];
                    array[position] = temp;
                }
            }
        }
        //Insertion Sorting
        public void InsertionSort(int[] array)
        {
            int i, j, temp;
            for (i = 1; i < array.Length; i++) {
                temp = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > temp) {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;

            }

        }
        //Bubble sort
        public void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++) {
                flag = false;

                for (int j = 0; j < array.Length - 1 - i; j++) {
                    if (array[j] > array[j + 1]) {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        flag = true;
                    }
                }
                if (flag == false)
                    break;

            }
        }
        //Shell Sort
        public void ShellSort(int[] array)
        {
            int i, j, gap, temp;
            gap = (int)Math.Floor(array.Length / 2.0);
            while (gap > 0) {
                i = gap;
                while (i < array.Length) {
                    temp = array[i];
                    j = i - gap;
                    while (j >= 0 && array[j] > temp) {
                        array[j + gap] = array[j];
                        j -= gap;
                    }
                    array[j + gap] = temp;
                    i += 1;
                }
                gap /= 2;

            }
        }
        //swap

        public void Swapping(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        //quick sort
        public int Partition(int[] array, int lb, int ub)
        {
            int pivot = array[lb];

            while (true) {
                while (array[lb] < pivot) {
                    lb++;
                }

                while (array[ub] > pivot) {
                    ub--;
                }
                if (lb < ub) {
                    if (array[lb] == array[ub])
                        return ub;
                    Swapping(array, lb, ub);
                } else
                    return ub;
            }



        }

        public void Quicksort(int[] array, int lb, int ub)
        {
            if (lb < ub) {
                int pivot = Partition(array, lb, ub);
                if (pivot > 1)
                    Quicksort(array, lb, pivot - 1);
                if (pivot + 1 < ub)
                    Quicksort(array, pivot + 1, ub);

            }


        }


    }
}
