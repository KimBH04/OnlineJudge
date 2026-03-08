using System;
using System.Collections.Generic;

namespace Prob5073
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> so = new List<string>();

            for (int i = 0; ;i++)
            {
                string[] A = Console.ReadLine().Split();
                int a = int.Parse(A[0]);
                int b = int.Parse(A[1]);
                int c = int.Parse(A[2]);

                if(a + b + c == 0)
                    break;

                else if (a >= b + c || b >= a + c || c >= a + b)
                    so.Add("Invalid");

                else if (a == b && b == c)
                    so.Add("Equilateral");

                else if (a == b || b == c || a == c)
                    so.Add("Isosceles");

                else
                    so.Add("Scalene");
            }

            for (int i = 0; i < so.Count; i++)
                Console.WriteLine(so[i]);
        }
    }
}
