static class Program
{
    private static int pointer = 0;
    private static string[] readBuffer = Array.Empty<string>();

    private static string GetInput(this TextReader reader)
    {
        if (pointer >= readBuffer.Length)
        {
            do
            {
                readBuffer = reader.ReadLine()!.Split();
            }
            while (readBuffer.Length == 0);

            pointer = 0;
        }

        return readBuffer[pointer++];
    }

    private static void Main(string[] args)
    {
        using StreamReader sr = new(Console.OpenStandardInput());
        using StreamWriter sw = new(Console.OpenStandardOutput());

        int t = int.Parse(sr.GetInput());
        while (t-- > 0)
        {
            int m = int.Parse(sr.GetInput());
            sw.WriteLine(m - m / 2);

            PriorityQueue<int, int> pq = new(m);
            for (int i = 0, j = 0; i < m; i++)
            {
                int e = int.Parse(sr.GetInput());
                pq.Enqueue(e, e);

                if (i % 2 == 0)
                {
                    j++;
                    int half = pq.Count / 2;
                    int[] arr = new int[half];
                    while (half-- > 0)
                    {
                        arr[half] = pq.Dequeue();
                    }
                    sw.Write(pq.Peek() + (j % 10 == 0 ? "\n" : " "));

                    foreach (int a in arr)
                    {
                        pq.Enqueue(a, a);
                    }
                }
            }
            sw.WriteLine();
        }
    }
}