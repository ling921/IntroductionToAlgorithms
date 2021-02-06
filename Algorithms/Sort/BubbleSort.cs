using System;

namespace Algorithms.Sort
{
    public static class BubbleSort
    {
        internal static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) > 0)
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        internal static T[] SortReverse<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) < 0)
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}