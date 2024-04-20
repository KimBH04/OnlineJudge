using System;
using System.Text;

namespace Prob1009
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split();
                switch (int.Parse(input[0]) % 10)
                {
                    case 1:
                        sb.AppendLine("1");
                        break;
                    case 2:
                        if (int.Parse(input[1]) % 4 - 3 == 0)
                            sb.AppendLine("8");
                        else if (int.Parse(input[1]) % 4 - 2 == 0)
                            sb.AppendLine("4");
                        else if (int.Parse(input[1]) % 4 - 1 == 0)
                            sb.AppendLine("2");
                        else if (int.Parse(input[1]) % 4 == 0)
                            sb.AppendLine("6");
                        break;
                    case 3:
                        if (int.Parse(input[1]) % 4 - 3 == 0)
                            sb.AppendLine("7");
                        else if (int.Parse(input[1]) % 4 - 2 == 0)
                            sb.AppendLine("9");
                        else if (int.Parse(input[1]) % 4 - 1 == 0)
                            sb.AppendLine("3");
                        else if (int.Parse(input[1]) % 4 == 0)
                            sb.AppendLine("1");
                        break;
                    case 4:
                        if (int.Parse(input[1]) % 2 - 1 == 0)
                            sb.AppendLine("4");
                        else if (int.Parse(input[1]) % 2 == 0)
                            sb.AppendLine("6");
                        break;
                    case 5:
                        sb.AppendLine("5");
                        break;
                    case 6:
                        sb.AppendLine("6");
                        break;
                    case 7:
                        if (int.Parse(input[1]) % 4 - 3 == 0)
                            sb.AppendLine("3");
                        else if (int.Parse(input[1]) % 4 - 2 == 0)
                            sb.AppendLine("9");
                        else if (int.Parse(input[1]) % 4 - 1 == 0)
                            sb.AppendLine("7");
                        else if (int.Parse(input[1]) % 4 == 0)
                            sb.AppendLine("1");
                        break;
                    case 8:
                        if (int.Parse(input[1]) % 4 - 3 == 0)
                            sb.AppendLine("2");
                        else if (int.Parse(input[1]) % 4 - 2 == 0)
                            sb.AppendLine("4");
                        else if (int.Parse(input[1]) % 4 - 1 == 0)
                            sb.AppendLine("8");
                        else if (int.Parse(input[1]) % 4 == 0)
                            sb.AppendLine("6");
                        break;
                    case 9:
                        if (int.Parse(input[1]) % 2 - 1 == 0)
                            sb.AppendLine("9");
                        else if (int.Parse(input[1]) % 2 == 0)
                            sb.AppendLine("1");
                        break;
                    case 0:
                        sb.AppendLine("10");
                        break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
