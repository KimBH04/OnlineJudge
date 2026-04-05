using System;
using System.Collections.Generic;

namespace _9020
{
    class Program
    {
        #region make prime list

        //소수 리스트 만들기
        //프로그램 돌리면서 일일이 검사하는건 비효율적이겠지?
        //그리고 귀찮음
        static List<int> primes = new List<int>();
        static int len;

        static void PrimeList()
        {
            primes.Add(2);

            for (int i = 3; i < 10001; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) goto here;
                }

                primes.Add(i);

            here:;
            }

            len = primes.Count;
        }
        #endregion

        static void Main(string[] args)
        {
            PrimeList();

            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var result = "";
                var n = int.Parse(Console.ReadLine());

                //어차피 앞에 출력 될 수가 더 작으니 n의 반까지만 반복
                for (int j = 0; j < len && primes[j] <= n / 2; j++)
                {
                    //뒤 숫자가 앞 숫자보다 작을 수 없으므로 k = j
                    //j번째 소수 + k번째 소수가 n 이하일 때 반복
                    //당근 j,k는 소수 리스트의 수 보다 작아야 됨
                    for (int k = j; k < len && primes[j] + primes[k] <= n; k++)
                    {
                        //같으면 입력
                        if (primes[j] + primes[k] == n)
                        {
                            result = primes[j] + " " + primes[k];
                        }
                    }

                    //n의 반까지 갈 수록 두 수의 차가 작아지니 
                    //걍 놔두면 알아서 차이가 작은 수 입력함
                }

                Console.WriteLine(result);
            }
        }
    }
}
