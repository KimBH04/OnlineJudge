using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] inputs = sr.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);
int k = int.Parse(sr.ReadLine()!);

List<(int, int)>[] nodes = new List<(int, int)>[n + 1];
int[] distance = new int[n + 1];
bool[] visited = new bool[n + 1];
for (int i = 0; i <= n; i++)
{
    nodes[i] = new();
    distance[i] = -1;
    visited[i] = false;
}

for (int i = 0; i < m; i++)
{
    string[] edges = sr.ReadLine()!.Split();
    int u = int.Parse(edges[0]),
        v = int.Parse(edges[1]),
        w = int.Parse(edges[2]);

    nodes[u].Add((v, w));
}

foreach (var (node, dis) in nodes[k])
{
    distance[node] = dis;
}
distance[k] = 0;

PriorityQueue<int, int> pq = new();
visited[k] = true;
pq.Enqueue(k, 0);

while (pq.Count > 0)
{
    int v = pq.Dequeue();
    foreach (var (node, dis) in nodes[v])
    {
        if (visited[node])
        {
            if (distance[node] > distance[v] + dis)
            {
                distance[node] = distance[v] + dis;
                pq.Enqueue(node, distance[node]);
            }
            continue;
        }

        visited[node] = true;
        distance[node] = distance[v] + dis;
        pq.Enqueue(node, distance[node]);
    }
}

foreach (int i in distance[1..])
{
    sw.WriteLine(i > -1 ? i : "INF");
}