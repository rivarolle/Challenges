using System;
using System.IO;

namespace Challenges.Algorithms.Easy
{
    public class TimeConversion
    {
        /*
    * Complete the timeConversion function below.
    */
        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */

            var pmOram = s.Substring(s.Length - 2);
            var originalHours = s.Substring(0, 2);
            var rest = s.Substring(2, s.Length - 4);

            if (pmOram == "AM")
            {
                if (originalHours == "12") return $"00{rest}";
                return $"{originalHours}{rest}";
            }

            if (originalHours == "12") return $"12{rest}";
            return $"{Convert.ToInt32(originalHours) + 12}{rest}";

        }

        public static void Start(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }
    }
}