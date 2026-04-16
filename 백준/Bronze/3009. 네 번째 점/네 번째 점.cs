using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new string[3];
            var arr2 = new string[3];

            for (int i = 0; i < 3; i++)
            {
                var input = Console.ReadLine().Split();

                arr1[i] = input[0];
                arr2[i] = input[1];
            }

            Array.Sort(arr1);
            Array.Sort(arr2);

            if (arr1[1] == arr1[2])
            {
                Console.Write(arr1[0]);
            }
            else
            {
                Console.Write(arr1[2]);
            }

            Console.Write(" ");

            if (arr2[1] == arr2[2])
            {
                Console.Write(arr2[0]);
            }
            else
            {
                Console.Write(arr2[2]);
            }
        }
    }
}
