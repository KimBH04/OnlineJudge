using System;

namespace _1874
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new System.Collections.Generic.Stack<int>();
            var sb = new System.Text.StringBuilder();
            var n = int.Parse(Console.ReadLine());
            var t = true;
            var o = 1;

            for (int i = 0; i < n; i++)
            {
                var m = int.Parse(Console.ReadLine());

                for (; o <= m; o++)
                {
                    s.Push(o);
                    sb.AppendLine("+");
                }

                if (s.Peek() > m) t = false;

                s.Pop();
                sb.AppendLine("-");
            }

            if (t) System.Console.Write(sb);
            else System.Console.WriteLine("NO");
        }
    }
}
