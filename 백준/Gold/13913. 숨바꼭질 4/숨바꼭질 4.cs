bool[] visited = new bool[100001];

string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), k = int.Parse(inputs[1]);

if (n >= k)
{
    Console.WriteLine(n - k);
    using StreamWriter sw = new(Console.OpenStandardOutput());
    for (int i = n; i >= k; i--)
    {
        sw.Write(i + " ");
    }
    return;
}

Queue<(int, string)> queue = new();
queue.Enqueue((n, n.ToString()));
visited[n] = true;

int cnt = 0;
while (queue.Count > 0)
{
    int qcnt = queue.Count;
    while (qcnt-- > 0)
    {
        var (m, path) = queue.Dequeue();
        if (m == k)
        {
            Console.WriteLine(cnt);
            Console.WriteLine(path);
            return;
        }

        int[] move = { m + 1, m - 1, m * 2 };
        foreach (var p in move)
        {
            if (0 <= p && p < 100001 && !visited[p])
            {
                visited[p] = true;
                queue.Enqueue((p, path + $" {p}"));
            }
        }
    }
    cnt++;
}
