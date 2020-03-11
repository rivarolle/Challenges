using System;

namespace Challenges.Algorithms.Easy
{
    public class MinMaxSum
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(long[] arr)
        {
            //sort the array
            Utils.Quicksort(arr, arr.Length - 1);

            var min = arr[0] + arr[1] + arr[2] + arr[3];
            var max = arr[4] + arr[1] + arr[2] + arr[3];

            Console.WriteLine($"{min} {max}");
        }

        public static void Start(string[] args)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            miniMaxSum(arr);
        }
    }
}