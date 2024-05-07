using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int t = int.Parse(sr.ReadLine()!);
while (t-- > 0)
{
    string[] inputs = sr.ReadLine()!.Split();
    int n = int.Parse(inputs[0]), k = int.Parse(inputs[1]);
    int[] d = new int[n + 1];
    string[] dstring = sr.ReadLine()!.Split();
    for (int i = 0; i < n; i++)
    {
        d[i + 1] = int.Parse(dstring[i]);
    }

    int[] visited = new int[n + 1];
    List<int>[] edges = new List<int>[n + 1];
    for (int i = 1; i <= n; i++)
    {
        edges[i] = new();
    }

    for (int i = 0; i < k; i++)
    {
        string[] nodes = sr.ReadLine()!.Split();
        int x = int.Parse(nodes[0]), y = int.Parse(nodes[1]);
        edges[x].Add(y);
        visited[y]++;
    }

    int w = int.Parse(sr.ReadLine()!);

    PriorityQueue<int, int> pq = new();
    for (int i = 1; i <= n; i++)
    {
        if (visited[i] == 0)
        {
            pq.Enqueue(i, d[i]);
        }
    }

    while (pq.TryDequeue(out int node, out int time))
    {
        foreach (int item in edges[node])
        {
            visited[item]--;
            if (visited[item] == 0)
            {
                pq.Enqueue(item, d[item] += time);
            }
        }
    }

    sw.WriteLine(d[w]);
}
