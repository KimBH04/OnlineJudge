using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine()!);
PriorityQueue<int, int> pq = new();

while (n-- > 0)
{
    int x = int.Parse(sr.ReadLine()!);
    if (x == 0)
    {
        if (pq.Count > 0)
        {
            sw.WriteLine(pq.Dequeue());
        }
        else
        {
            sw.WriteLine(0);
        }
    }
    else
    {
        pq.Enqueue(x, x);
    }
}