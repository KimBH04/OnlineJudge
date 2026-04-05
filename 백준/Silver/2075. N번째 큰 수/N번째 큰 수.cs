int n = int.Parse(Console.ReadLine()!);
PriorityQueue<int, int> pq = new();

string[] s = Console.ReadLine()!.Split();
for (int i = 0; i < n; i++)
{
    int x = int.Parse(s[i]);
    pq.Enqueue(x, x);
}

for (int i = 1; i < n; i++)
{
    s = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        int x = int.Parse(s[j]);
        pq.Enqueue(x, x);
        pq.Dequeue();
    }
}

Console.WriteLine(pq.Dequeue());