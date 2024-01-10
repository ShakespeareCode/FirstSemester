using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsArraysSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 20, 1, 9, 4, 2, 3, 18, 16, 8 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            int[] sortedArray = ArraySorting.BubbleSort(arr.Clone() as int[]);
            Console.WriteLine("\nОтсортированный массив (пузырьком):");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write($"{sortedArray[i]} ");
            }
            int[] insertionSortedArray = ArraySorting.InsertionSort(arr.Clone() as int[]);
            Console.WriteLine("\nОтсортированный массив (вставкой):");
            for (int i = 0; i < insertionSortedArray.Length; i++)
            {
                Console.Write($"{insertionSortedArray[i]} ");
            }

            Console.ReadKey();
        }
    }
}
