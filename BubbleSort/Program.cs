using System;
using System.Linq;

namespace BubbleSort
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort");
            int[] arrayToSort = new int[] { 5, 1, 4, 2, 8 };
            ISortBehavior sort = new BubbleSort();
            sort.Sort(arrayToSort);
            arrayToSort.ToList().ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Qucik Sort");
            int[] arrayToQuickSort = new int[] { 10, 7, 8, 9, 1, 5 };
            ISortBehavior quickSort = new QuickSort();
            quickSort.Sort(arrayToQuickSort);
            arrayToQuickSort.ToList().ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Merge Sort");
            int[] arrayToMergeSort = new int[] { 38, 27, 43, 3, 9, 82, 10 };
            ISortBehavior mergeSort = new MergeSort();
            mergeSort.Sort(arrayToMergeSort);
            arrayToMergeSort.ToList().ForEach(t => Console.WriteLine(t));
        }
    }
}
