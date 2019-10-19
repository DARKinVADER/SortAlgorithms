using System;
using System.Linq;

namespace BubbleSort
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = new int[] { 5, 1, 4, 2, 8 };

            ISortBehavior sort = new BubbleSort();

            sort.Sort(arrayToSort);
            arrayToSort.ToList().ForEach(t => Console.WriteLine(t));
        }
    }
}
