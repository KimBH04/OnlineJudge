using System;

namespace Prob10250
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            string[] roomNum = new string[times];
            for (int i = 0; i < times; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), (a) => int.Parse(a));
                int W = 1;
                while (true)
                    if (input[2] > input[0])
                    {
                        input[2] -= input[0];
                        W++;
                    }
                    else
                        break;
                if (W < 10)
                    roomNum[i] = input[2].ToString() + "0" + W.ToString();
                else
                    roomNum[i] = input[2].ToString() + W.ToString();
            }
            foreach (string a in roomNum)
                Console.WriteLine(a);
        }
    }
}
