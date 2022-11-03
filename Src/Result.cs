using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'minimumNumber' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. STRING password
         */

        public static int minimumNumber(int n, string password)
        {
            string numbers = "0123456789";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special = "!@#$%^&*()-+";

            int countNumbers = 0;
            int countLower = 0;
            int countUpper = 0;
            int countSpecial = 0;

            int miss = 0;

            foreach (var item in password)
            {
                countNumbers = numbers.Contains(item) ? countNumbers += 1 : countNumbers;
                countLower = lower.Contains(item) ? countLower += 1 : countLower;
                countUpper = upper.Contains(item) ? countUpper += 1 : countUpper;
                countSpecial = special.Contains(item) ? countSpecial += 1 : countSpecial;
            }

            miss = countNumbers == 0 ? miss += 1 : miss;
            miss = countLower == 0 ? miss += 1 : miss;
            miss = countUpper == 0 ? miss += 1 : miss;
            miss = countSpecial == 0 ? miss += 1 : miss;

            return miss < (6 - n) ? (6 - n) : miss;

        }
    }
}