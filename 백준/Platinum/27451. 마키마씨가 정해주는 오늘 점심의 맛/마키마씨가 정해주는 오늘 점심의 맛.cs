string[] nm = Console.ReadLine()!.Split();
int n = int.Parse(nm[0]), m = int.Parse(nm[1]);

List<int>[] edge = new List<int>[n + 1];
for (int i = 0; i <= n; i++)
{
    edge[i] = new();
}

bool[,,] visited = new bool[n + 1, n + 1, n + 1];

string[] abc = Console.ReadLine()!.Split();
int a = int.Parse(abc[0]), b = int.Parse(abc[1]), c = int.Parse(abc[2]);

visited[a, b, c] = true;

Queue<(int, int, int, string, string, string)> queue = new();
queue.Enqueue((a, b, c, a.ToString(), b.ToString(), c.ToString()));

while (m-- > 0)
{
    string[] path = Console.ReadLine()!.Split();
    int s = int.Parse(path[0]), e = int.Parse(path[1]);
    edge[s].Add(e);
}

int cnt = 0;
while (queue.Count > 0)
{
    int qcnt = queue.Count;
    while (qcnt-- > 0)
    {
        var (pow, den, aki, powPath, denPath, akiPath) = queue.Dequeue();
        if (pow == den && den == aki)
        {
            Console.WriteLine($"{aki} {cnt}");
            Console.WriteLine(powPath);
            Console.WriteLine(denPath);
            Console.WriteLine(akiPath);
            return;
        }

        foreach (int node1 in edge[pow])
        {
            foreach (int node2 in edge[den])
            {
                foreach (int node3 in edge[aki])
                {
                    if (!visited[node1, node2, node3])
                    {
                        visited[node1, node2, node3] = true;
                        queue.Enqueue((node1, node2, node3, $"{powPath} {node1}", $"{denPath} {node2}", $"{akiPath} {node3}"));
                    }
                }
            }
        }
    }
    cnt++;
}

Console.WriteLine(-1);