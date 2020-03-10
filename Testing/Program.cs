using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingMSort();


            Console.ReadKey();
        }
        public static void TestingMSort()
        {
            int[] vs1 = new int[] { 28, 3, 7, 3, 33, 99, -11, 111, -04059 };
            int[] vs = new int[] { 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22};
            PrintArray(vs);
            MergeSort.MSort(vs);
            PrintArray(vs);

        }

        public static void PrintArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
