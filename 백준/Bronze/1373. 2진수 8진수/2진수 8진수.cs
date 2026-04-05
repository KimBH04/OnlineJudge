using System;

namespace Prob1373
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            using var sr = new System.IO.StreamReader(Console.OpenStandardInput());
            using var sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

            var input = sr.ReadLine().ToCharArray();
            if (input.Length % 3 == 0)
            {
                for (; i < input.Length;)
                {
                    i = Binary2Octar(sw, input, i);
                }
            }
            else if ((input.Length - 2) % 3 == 0)
            {
                string s = "";
                s += input[i++];
                s += input[i++];
                int output = Convert.ToInt32(s, 2);
                sw.Write(output);

                for (; i < input.Length;)
                {
                    i = Binary2Octar(sw, input, i);
                }
            }
            else
            {
                string s = "";
                s += input[i++];
                int output = Convert.ToInt32(s, 2);
                sw.Write(output);

                for (; i < input.Length;)
                {
                    i = Binary2Octar(sw, input, i);
                }
            }
        }

        static int Binary2Octar(System.IO.StreamWriter sw,char[] input, int i)
        {
            string s = "";
            s += input[i++];
            s += input[i++];
            s += input[i++];
            int output = Convert.ToInt32(s, 2);
            sw.Write(output);
            return i;
        }
    }
}
