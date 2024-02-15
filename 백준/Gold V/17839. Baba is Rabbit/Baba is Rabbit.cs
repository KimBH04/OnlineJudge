int n = int.Parse(Console.ReadLine()!);

Dictionary<string, List<string>> graph = new(n) { { "Baba", new() } };
Dictionary<string, bool> visited = new(n) { { "Baba", true } };

while (n-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    if (graph.ContainsKey(inputs[0]))
    {
        graph[inputs[0]].Add(inputs[2]);
    }
    else
    {
        graph.Add(inputs[0], new() { inputs[2] });
        if (!visited.ContainsKey(inputs[0]))
        {
            visited.Add(inputs[0], false);
        }
    }

    if (!visited.ContainsKey(inputs[2]))
    {
        visited.Add(inputs[2], false);
    }
}

List<string> output = new();
Queue<string> queue = new();
queue.Enqueue("Baba");

while (queue.Count > 0)
{
    string v = queue.Dequeue();

    if (graph.ContainsKey(v))
    {
        foreach (string node in graph[v])
        {
            if (visited[node])
            {
                continue;
            }

            visited[node] = true;
            queue.Enqueue(node);
            output.Add(node);
        }
    }
}

Console.WriteLine(string.Join('\n', output.OrderBy(x => x)));