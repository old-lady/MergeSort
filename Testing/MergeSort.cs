using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    //public class MergeSort<T> where T : IComparable<T>
    public static class MergeSort
    {
        public static void MSort<T>(this T[] array) where T : IComparable<T>
        {
            MSort(array, 0, array.Length - 1, new T[array.Length]);
        }
        //public static void MSort(T[] array) 
        //{

        //}

        private static void MSort<T>(T[] Array, int startIndex, int slutIndex, T[] emptyArray) where T : IComparable<T>
        {

            //Console.WriteLine(Array.Length.ToString("DD"), startIdex, slutIndex, emptyArray.Length);
            //string g = string.Format("sdkfgsjgfsj{1}", startIdex, slutIndex);
            //Console.WriteLine("dffkdjfhkdj{0}", startIdex);
            //Console.WriteLine($"array length = {Array.Length} \nstartIndex = {startIndex} \nslutIndex = {slutIndex}" );
            //Console.WriteLine();

            if (startIndex < slutIndex)
            {
                int middle = (startIndex + slutIndex) / 2;
                MSort(Array, startIndex, middle, emptyArray);

                MSort(Array, middle + 1, slutIndex, emptyArray);

                Merge(Array, startIndex, middle, slutIndex, emptyArray);


            }
        }
        private static void Merge<T>(T[] Array, int startIndex, int middle, int slutIndex, T[] emptyArray) where T : IComparable<T>
        {
            int resultIndex = startIndex;
            int venstreArrayIndex = startIndex;
            int højreArrayIndex = middle + 1;

            // sammenligner et element fra hvert delarray, til vi løber tør for elementer i et af dem
            while (venstreArrayIndex <= middle && højreArrayIndex <= slutIndex)
            {
                if (Array[venstreArrayIndex].CompareTo(Array[højreArrayIndex]) < 0)
                {

                    emptyArray[resultIndex++] = Array[venstreArrayIndex++];

                    // forklaring på syntax:
                    //emptyArray[resultIndex] = Array[venstreArrayIndex];
                    //resultIndex++;
                }
                else
                {
                    emptyArray[resultIndex++] = Array[højreArrayIndex++];

                }
            }

            // tømmer det array der er noget tilbage i, hvis de ikke begge er tomme
            while (højreArrayIndex < slutIndex)
            {
                emptyArray[resultIndex++] = Array[højreArrayIndex++];
                
            }

            while (venstreArrayIndex < middle)
            {
                emptyArray[resultIndex++] = Array[venstreArrayIndex++];

            }

            for (resultIndex = startIndex, venstreArrayIndex = startIndex; resultIndex <= slutIndex; resultIndex++, venstreArrayIndex++)
            {
                Array[resultIndex] = emptyArray[venstreArrayIndex];
            }

            //Array = emptyArray;
        }
    }
}
