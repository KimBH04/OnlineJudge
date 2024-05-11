using StreamReader sr = new(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine()!),
    m = int.Parse(sr.ReadLine()!);

var edges = new List<(int to, long weight)>[n + 1];
for (int i = 1; i <= n; i++)
{
    edges[i] = new();
}

while (m-- > 0)
{
    string[] inputs = sr.ReadLine()!.Split();
    int s = int.Parse(inputs[0]),
        e = int.Parse(inputs[1]);
    long w = long.Parse(inputs[2]);

    edges[s].Add((e, w));
}

string[] startend = sr.ReadLine()!.Split();
int start = int.Parse(startend[0]), end = int.Parse(startend[1]);

long[] distance = Enumerable.Repeat(long.MaxValue, n + 1).ToArray();
PriorityQueue<int, long> pq = new();
pq.Enqueue(start, distance[start] = 0L);

while (pq.TryDequeue(out int x, out long dis))
{
    if (distance[x] < dis)
    {
        continue;
    }

    foreach (var (to, weight) in edges[x])
    {
        if (distance[to] > distance[x] + weight)
        {
            pq.Enqueue(to, distance[to] = distance[x] + weight);
        }
    }
}

Console.WriteLine(distance[end]);