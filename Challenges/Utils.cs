using System;

namespace Challenges
{
    public class Utils
    {
        public static void Quicksort<T>(T[] arr, int pivotIndex, int startIndex=0)
        {
            var lowIndex = startIndex;
            for (int j = startIndex; j <= pivotIndex; j++)
            {
                if ((dynamic)arr[j] <= (dynamic)arr[pivotIndex])
                {
                    var currentValue = arr[lowIndex];
                    arr[lowIndex] = arr[j];
                    arr[j] = currentValue;
                    lowIndex++;
                }
            }

            if (lowIndex > 2)
                Quicksort(arr,  lowIndex - 2, 0);
            if (lowIndex < pivotIndex)
                Quicksort(arr, pivotIndex, lowIndex);
        }
    }
}