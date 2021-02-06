using System;

namespace Algorithms.Extensions
{
    public static class Sort
    {
        public static void InsertionSort<T>(this T[] array, bool reverse = false) where T : IComparable<T>
        {
            if (!reverse)
            {
                Algorithms.Sort.InsertionSort.Sort(array);
            }
            else
            {
                Algorithms.Sort.InsertionSort.SortReverse(array);
            }
        }

        public static void MergeSort<T>(this T[] array, bool reverse = false) where T : IComparable<T>
        {
            if (!reverse)
            {
                Algorithms.Sort.MergeSort.Sort(array);
            }
            else
            {
                Algorithms.Sort.MergeSort.SortReverse(array);
            }
        }

        public static void BubbleSort<T>(this T[] array, bool reverse = false) where T : IComparable<T>
        {
            if (!reverse)
            {
                Algorithms.Sort.BubbleSort.Sort(array);
            }
            else
            {
                Algorithms.Sort.BubbleSort.SortReverse(array);
            }
        }
    }
}