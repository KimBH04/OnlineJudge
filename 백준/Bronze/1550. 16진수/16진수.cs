using System;

namespace Prob1550
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexacode = Console.ReadLine().ToCharArray();
            var decimalcode = 0;
            for (byte i = 0; i < hexacode.Length; i++)
            {
                var temp = "";
                temp += hexacode[^(i + 1)];
                switch (temp)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        decimalcode += int.Parse(temp) * (int)Math.Pow(16, i);
                        break;
                    case "A":
                    case "B":
                    case "C":
                    case "D":
                    case "E":
                    case "F":
                        decimalcode += ((int)char.Parse(temp) - 55) * (int)Math.Pow(16, i);
                        break;
                }
            }
            Console.WriteLine(decimalcode);
        }
    }
}
