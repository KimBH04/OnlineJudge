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
            char[] num1 = input[0].ToCharArray(), num2 = input[1].ToCharArray();
            Array.Reverse(num1); Array.Reverse(num2);
            while (true) //양쪽의 자릿수를 같게 Do same two numbers' digits
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
                int a = (int)Char.GetNumericValue(num1[i]), 
                    b = (int)Char.GetNumericValue(num2[i]);
                if (a == -1) //자릿수를 늘려서 생긴 빈 곳의 수를 0으로 변경 Change null to 0 'cause of number's digit expanded
                    a = 0;
                else if (b == -1)
                    b = 0;
                int sum = a + b;
                if (roundedNum == true) //뒤의 자리에 의해 자리 올림이 발생 Occured round up caused by caculated at next place
                    sum++;
                if (sum > 9) //자리 올림이 발생 할 경우 자리 올림을 기록 후 -10 If Occur round up, record for round up and subtract 10
                {
                    roundedNum = true;
                    sum -= 10;
                }
                else //자리 올림이 발생하지 않을 경우 기록 제거 Unless occur round up, remove record
                    roundedNum = false;
                total[j] = sum;
                j++;
            }
            if (roundedNum == true) //맨 앞 자리에서 자리 올림이 발생 할 경우 맨 앞을 1로 설정 If occur roundf up at first digit, add 1 to first digit
            {
                Array.Resize<int>(ref total, total.Length + 1);
                total[total.Length - 1] = 1;
            }
            for (int i = total.Length - 1; i > -1; i--)
                Console.Write(total[i]);
        }
    }
}