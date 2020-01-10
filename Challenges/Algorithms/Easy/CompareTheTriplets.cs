using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenges.Algorithms.Easy
{
    public class CompareTheTriplets
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var scores = new int[2];

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) scores[0] = scores[0] + 1;
                if (a[i] < b[i]) scores[1] = scores[1] + 1;
            }

            return scores.ToList();
        }

        public static void Start(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}