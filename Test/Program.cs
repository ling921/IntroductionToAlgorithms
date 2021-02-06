using static Algorithms.Extensions.Sort;
using System;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arr = new int[] { 5, 2, 4, 6, 1, 3 };
            arr.BubbleSort(true);
            Console.WriteLine("Hello World!");
        }
    }
}