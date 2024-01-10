using System;


namespace LoopsArraysSorting
{
    static class ArraySorting
    {

        public static int[] BubbleSort(int[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                bool isSorted = true;
                for (int i = 0; i < array.Length - j; i++)
                {
                    if (array[i] > array[i + 1]) //i = номер эллемента массива
                    {
                        isSorted = false;
                        //int buf = array[i];
                        //array[i] = array[i + 1];

                        //array[i + 1] = buf;
                        //то же самое что и ниже
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
        public static int[] InsertionSort(int[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                int key = array[j];
                int i = j - 1;

                while (i >= 0 && array[i] > key)
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
