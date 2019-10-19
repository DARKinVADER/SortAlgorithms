using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class BubbleSort : SortBehavior
    {
        public void Sort(int[] array)
        {
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
            }
        }
    }
}
