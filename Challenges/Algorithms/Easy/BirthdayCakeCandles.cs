using System;
using System.IO;

namespace Challenges.Algorithms.Easy
{
    public class BirthdayCakeCandles
    {
        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            var max = ar[0];
            var maxCount = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    maxCount = 1;
                    max = ar[i];
                }
                else if (ar[i] == max)
                {
                    maxCount++;
                }
            }

            return maxCount;

        }

        public static void Start(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
                ;
            int result = birthdayCakeCandles(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}