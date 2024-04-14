int n = int.Parse(Console.ReadLine()!);
PriorityQueue<int, int> queue = new(n);

while (n-- > 0)
{
    int x = int.Parse(Console.ReadLine()!);
    queue.Enqueue(x, x);
}

int re = 0;
while (queue.Count > 1)
{
    int a = queue.Dequeue();
    int b = queue.Dequeue();
    re += a + b;
    queue.Enqueue(a + b, a + b);
}

Console.WriteLine(re);