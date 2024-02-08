string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), k = int.Parse(inputs[1]);

PriorityQueue<int, int> pq = new();
foreach (string s in Console.ReadLine()!.Split())
{
    int a = int.Parse(s);
    pq.Enqueue(a, a);
}

int r = 0;
while (k-- > 0)
{
    r = pq.Dequeue();
}

Console.WriteLine(r);