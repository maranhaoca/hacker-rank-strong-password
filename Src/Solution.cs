using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string password = Console.ReadLine();

            int answer = Result.minimumNumber(n, password);

            textWriter.WriteLine(answer);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}