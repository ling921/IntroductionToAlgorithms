using System;

namespace Algorithms.Sort
{
    public static class InsertionSort
    {
        internal static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return array;
        }

        internal static T[] SortReverse<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) < 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return array;
        }
    }
}