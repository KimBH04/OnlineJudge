using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine()!);
PriorityQueue<int, int> min = new(), max = new();

for (int i = 0; i < n; i++)
{
    int x = int.Parse(sr.ReadLine()!);

    if (min.Count == 0)
    {
        min.Enqueue(x, -x);
    }
    else if (min.Peek() >= x)
    {
        min.Enqueue(x, -x);
    }
    else if (max.Count == 0)
    {
        max.Enqueue(x, x);
    }
    else
    {
        max.Enqueue(x, x);
    }

    while (Math.Abs(min.Count - max.Count) > 1)
    {
        if (min.Count < max.Count)
        {
            int a = max.Dequeue();
            min.Enqueue(a, -a);
        }
        else if (max.Count < min.Count)
        {
            int a = min.Dequeue();
            max.Enqueue(a, a);
        }
    }

    if (min.Count > max.Count)
    {
        sw.WriteLine(min.Peek());
    }
    else if (max.Count > min.Count)
    {
        sw.WriteLine(max.Peek());
    }
    else
    {
        int a = min.Peek(), b = max.Peek();
        sw.WriteLine(a > b ? b : a);
    }
}
