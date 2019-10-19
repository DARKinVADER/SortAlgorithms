using System;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = new int[] { 5, 1, 4, 2, 8 };

            SortBehavior sort = new BubbleSort();

            sort.Sort(arrayToSort);
            arrayToSort.ToList().ForEach(t => Console.WriteLine(t));
        }
    }
}
