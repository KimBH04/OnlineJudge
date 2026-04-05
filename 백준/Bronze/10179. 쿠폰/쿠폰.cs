using System;

namespace Prob10179
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            double[] prices = new double[times];
            for (int i = 0; i < times; i++)
            {
                double price = double.Parse(Console.ReadLine());
                prices[i] = Math.Round(price / 100 * 80, 2);
            }
            foreach (double item in prices)
                Console.WriteLine("${0:0.00}", item);
        }
    }
}
