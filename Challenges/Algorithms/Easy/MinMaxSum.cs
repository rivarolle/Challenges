using System;

namespace Challenges.Algorithms.Easy
{
    public class MinMaxSum
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(long[] arr)
        {
            //sort the array
            QuickSort(arr);

            var min = arr[0] + arr[1] + arr[2] + arr[3];
            var max = arr[4] + arr[1] + arr[2] + arr[3];

            Console.WriteLine($"{min} {max}");
        }

        static void QuickSort(long[] arr)
        {
            pivotArray(arr, 0, arr.Length - 1);
        }

        static void pivotArray(long[] arr, int startIndex, int pivotIndex)
        {
            var lowIndex = startIndex;
            for(int j=startIndex; j<= pivotIndex; j++)
            {
                if (arr[j] <= arr[pivotIndex])
                {
                    var currentValue = arr[lowIndex];
                    arr[lowIndex] = arr[j];
                    arr[j] = currentValue;
                    lowIndex++;
                }
            }
            
            if(lowIndex > 2)
                pivotArray(arr, 0, lowIndex-2);
            if(lowIndex < pivotIndex)
                pivotArray(arr, lowIndex, pivotIndex);
        }

        public static void Start(string[] args)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            miniMaxSum(arr);
        }
    }
}