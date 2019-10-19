using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class QuickSort : ISortBehavior
    {
        public void Sort(int[] array)
        {
            QuickSortAlgoritm(array, 0, array.Length - 1);
        }

        private void QuickSortAlgoritm(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSortAlgoritm(array, low, pi - 1);
                QuickSortAlgoritm(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);

            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
