using System;

namespace _2164
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new System.Collections.Generic.Queue<int>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                q.Enqueue(i);
            }

            while (q.Count > 1)
            {
                q.Dequeue();
                q.Enqueue(q.Dequeue());
            }

            Console.WriteLine(q.Dequeue());
        }
    }
}
