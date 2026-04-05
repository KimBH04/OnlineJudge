using System;

namespace Prob1920
{
    class Program
    {
        static void Main(string[] arg)
        {
            var sb = new System.Text.StringBuilder();

            var N = int.Parse(Console.ReadLine());
            var A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(A);

            var M = int.Parse(Console.ReadLine());
            var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < M; i++)
            {
                var _is = false;
                var fst = -1;
                var lst = N;

                while (fst + 1 != lst)
                {
                    var mid = (lst + fst) / 2;

                    if (input[i] == A[mid])
                    {
                        _is = true;
                        break;
                    }

                    if (input[i] > A[mid])
                        fst = mid;
                    else if (input[i] < A[mid])
                        lst = mid;
                }

                if (_is)
                    sb.AppendLine("1");
                else
                    sb.AppendLine("0");
            }

            Console.Write(sb);
        }
    }
}
