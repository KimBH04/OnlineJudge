using System;

namespace _16503
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();
            var _0 = int.Parse(arr[0]);
            var _1 = int.Parse(arr[2]);
            var _2 = int.Parse(arr[4]);

            var __0 = Calculator(_0, arr[1], Calculator(_1, arr[3], _2));
            var __1 = Calculator(Calculator(_0, arr[1], _1), arr[3], _2);

            if (__0 > __1)
            {
                var temp = __1;
                __1 = __0;
                __0 = temp;
            }

            Console.WriteLine("{0}\n{1}", __0, __1);
        }

        static int Calculator(int a, string o, int b)
        {
            switch (o)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    return 0;
            }
        }
    }
}
