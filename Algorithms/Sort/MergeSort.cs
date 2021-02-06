using System;

namespace Algorithms.Sort
{
    public static class MergeSort
    {
        internal static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            Merge(array, 0, array.Length - 1);
            return array;
        }

        internal static T[] SortReverse<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            MergeReverse(array, 0, array.Length - 1);
            return array;
        }

        #region Private Methods

        private static void Merge<T>(T[] array, int l, int r) where T : IComparable<T>
        {
            if (l < r)
            {
                var mid = l + (r - l) / 2;
                Merge(array, l, mid);
                Merge(array, mid + 1, r);
                T[] leftArr = array[l..(mid + 1)], rightArr = array[(mid + 1)..(r + 1)];
                int i = 0, j = 0;
                for (int k = l; k <= r; k++)
                {
                    if (i < leftArr.Length && j < rightArr.Length)
                    {
                        if (leftArr[i].CompareTo(rightArr[j]) < 0)
                        {
                            array[k] = leftArr[i];
                            i++;
                        }
                        else
                        {
                            array[k] = rightArr[j];
                            j++;
                        }
                    }
                    else if (i == leftArr.Length)
                    {
                        array[k] = rightArr[j];
                        j++;
                    }
                    else
                    {
                        array[k] = leftArr[i];
                        i++;
                    }
                }
            }
        }

        private static void MergeReverse<T>(T[] array, int l, int r) where T : IComparable<T>
        {
            if (l < r)
            {
                var mid = l + (r - l) / 2;
                MergeReverse(array, l, mid);
                MergeReverse(array, mid + 1, r);
                T[] leftArr = array[l..(mid + 1)], rightArr = array[(mid + 1)..(r + 1)];
                int i = 0, j = 0;
                for (int k = l; k <= r; k++)
                {
                    if (i < leftArr.Length && j < rightArr.Length)
                    {
                        if (leftArr[i].CompareTo(rightArr[j]) > 0)
                        {
                            array[k] = leftArr[i];
                            i++;
                        }
                        else
                        {
                            array[k] = rightArr[j];
                            j++;
                        }
                    }
                    else if (i == leftArr.Length)
                    {
                        array[k] = rightArr[j];
                        j++;
                    }
                    else
                    {
                        array[k] = leftArr[i];
                        i++;
                    }
                }
            }
        }

        #endregion
    }
}