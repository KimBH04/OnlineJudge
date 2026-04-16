using System;

namespace _11866
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new System.Collections.Generic.List<int>();
            var I = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = I[0];

            l.Add(n);
            for (int i = 1; i < n; i++)
            {
                l.Add(i);
            }

            Console.Write("<");
            for (int i = I[1]; l.Count != 0; i += I[1] - 1)
            {
                i %= l.Count;
                Console.Write(l[i]);
                l.RemoveAt(i);
                if (l.Count > 0) Console.Write(", ");
            }
            Console.Write(">");
        }
    }
}