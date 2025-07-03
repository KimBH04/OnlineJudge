for (int c = 1; ; c++)
{
    string[] input = Console.ReadLine()!.Split();
    int n = int.Parse(input[0]), m = int.Parse(input[1]);
    if (n == 0 && m == 0)
    {
        break;
    }

    var graph = new List<int>[n + 1];
    for (int i = 1; i <= n; i++)
    {
        graph[i] = new();
    }

    for (int i = 0; i < m; i++)
    {
        input = Console.ReadLine()!.Split();
        int a = int.Parse(input[0]), b = int.Parse(input[1]);
        graph[a].Add(b);
        graph[b].Add(a);
    }

    bool[] visited = new bool[n + 1];
    int cnt = 0;
    for (int i = 1; i <= n; i++)
    {
        if (!visited[i])
        {
            visited[i] = true;
            if (DFS(visited, graph, i, 0))
            {
                cnt++;
            }
        }
    }

    Console.WriteLine($"Case {c}: {(cnt > 1 ? $"A forest of {cnt} trees." : cnt < 1 ? "No trees." : "There is one tree.")}");
}

static bool DFS(bool[] visited, List<int>[] graph, int n, int parent)
{
    foreach (int to in graph[n])
    {
        if (to == parent)
        {
            continue;
        }

        if (visited[to])
        {
            return false;
        }

        visited[to] = true;
        if (!DFS(visited, graph, to, n))
        {
            return false;
        }
    }

    return true;
}
