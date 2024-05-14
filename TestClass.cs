using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_Test
{
    public static class TestClass
    {
        public static int FindMaxNumber(int[] numbers)
        {
            int maxNumber = numbers.Max();
            return maxNumber;
        }

        public static long FindFactorial_Number(int num)
        {
            long resultat = 1;
            foreach(int i in Enumerable.Range(1, num))
            {
                resultat *= i;
            }

            return resultat;

        }
        public static int FindSummNumber(int[] numbers)
        {
            int sum = numbers.Sum();
            return sum; 

        }

    }
}
