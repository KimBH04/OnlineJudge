int n = int.Parse(Console.ReadLine()!);
Queue<int> q = new();
for (int i = 1; i <= n; i++)
{
    q.Enqueue(i);
}

while (q.Count > 1)
{
    Console.Write(q.Dequeue() + " ");
    q.Enqueue(q.Dequeue());
}

Console.WriteLine(q.Dequeue());