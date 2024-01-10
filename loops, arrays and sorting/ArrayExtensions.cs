using System;
using System.Collections.Generic;

namespace LoopsArraysSorting
{
    internal static class ArrayExtensions
    {
        public static IEnumerable<T> BubleSortAscended<T>(this T[] array)
            where T : IComparable
        {
            for (int j = 1; j < array.Length; j++)
            {
                bool isSorted = true;
                for (int i = 0; i < array.Length - j; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0) //i = номер эллемента массива
                    {
                        isSorted = false;
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    }
                }
                if (isSorted)
                {
                    break;
                }
            }
            return array;
        }

        public static IEnumerable<T> InsertionSort<T>(this T[] array)
            where T : IComparable
        {
            for (int j = 2; j < array.Length; j++)
            {
                T key = array[j];
                int i = j - 1;

                while (i >= 0 && array[i].CompareTo(key) > 0)
                {
                    array[i + 1] = array[i];
                    i--;
                }
                array[i + 1] = key;
            }
            return array;
        }
    }
}
