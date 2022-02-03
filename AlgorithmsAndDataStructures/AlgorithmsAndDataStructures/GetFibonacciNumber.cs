using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public static class GetFibonacciNumber
    {
        public static int Recursion(int n)
        {
            if (n <= 1)
                return n;
            else
                return Recursion(n - 1) + Recursion(n - 2);
        }

        public static int Cycle(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n <= 2)
            {
                return 1;
            }
            else
            {
                int sum = 0;
                int f1 = 1;
                int f2 = 1;
                for (int i = 2; i < n; i++)
                {
                    sum = f1 + f2;
                    f1 = f2;
                    f2 = sum;
                }
                return sum;
            }
        }
        
    }
}
