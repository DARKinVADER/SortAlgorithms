using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class MergeSort : ISortBehavior
    {
        public void Sort(int[] array)
        {
            MergeSortAlgorithm(array, 0, array.Length - 1);
        }

        private void MergeSortAlgorithm(int[] array, int first, int last)
        {
            if (first < last)
            {
                int middle = (first + last) / 2;

                MergeSortAlgorithm(array, first, middle);
                MergeSortAlgorithm(array, middle + 1, last);
                Merge(array, first, middle, last);
            }
        }

        private void Merge(int[] array, int first, int middle, int last)
        {
            int leftLength = middle - first + 1;
            int rightLength = last - middle;

            int[] left = new int[leftLength];
            int[] right = new int[rightLength];

            for (int i = 0; i < leftLength; i++)
            {
                left[i] = array[first + i];
            }

            for (int i = 0; i < rightLength; i++)
            {
                right[i] = array[middle + i + 1];
            }

            int leftIndex = 0, rightIndex = 0;
            int k = first;

            while (leftIndex < leftLength && rightIndex < rightLength)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    array[k] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[k] = right[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            for (int i = leftIndex; i < leftLength; i++)
            {
                array[k] = left[leftIndex];
                k++;
            }

            for (int i = rightIndex; i < rightLength; i++)
            {
                array[k] = right[rightIndex];
                k++;
            }
        }
    }
}
