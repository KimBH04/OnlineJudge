using System;

namespace Prob10757
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            bool roundedNum = false;
            string[] input = Console.ReadLine().Split();
            char[] num1 = input[0].ToCharArray();
            char[] num2 = input[1].ToCharArray();

            Array.Reverse(num1);
            Array.Reverse(num2);

            while (true)
            {
                if (num1.Length > num2.Length)
                    Array.Resize<char>(ref num2, num2.Length + 1);
                else if (num1.Length < num2.Length)
                    Array.Resize<char>(ref num1, num1.Length + 1);
                else
                    break;
            }

            int[] total = new int[num1.Length];

            for (int i = 0; i < total.Length; i++)
            {
                int a = (int)Char.GetNumericValue(num1[i]);
                int b = (int)Char.GetNumericValue(num2[i]);

                if (a == -1)
                    a = 0;
                else if (b == -1)
                    b = 0;

                int sum = a + b;

                if (roundedNum == true)
                    sum++;

                if (sum > 9)
                {
                    roundedNum = true;
                    sum -= 10;
                }
                else
                    roundedNum = false;

                total[j] = sum;
                j++;
            }

            if (roundedNum == true)
            {
                Array.Resize<int>(ref total, total.Length + 1);
                total[total.Length - 1] = 1;
            }

            for (int i = total.Length - 1; i > -1; i--)
                Console.Write(total[i]);
        }
    }
}
