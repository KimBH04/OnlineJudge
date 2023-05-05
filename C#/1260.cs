var input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]),
    v = int.Parse(input[2]);

var nodes = new List<int>[n + 1];
var visited = new bool[n + 1];
for (int i = 1; i <= n; i++)
{
    nodes[i] = new List<int>();
    visited[i] = false;
}

for (int i = 0; i < m; i++)
{
    input = Console.ReadLine()!.Split();
    int f = int.Parse(input[0]),
        t = int.Parse(input[1]);

    nodes[f].Add(t);
    nodes[f].Sort();

    nodes[t].Add(f);
    nodes[t].Sort();
}

visited![v] = true;
Stack(v);

void Stack(int node)
{
    Console.Write(node + " ");

    foreach (var item in nodes![node])
    {
        if (visited[item])
            continue;

        visited[item] = true;
        Stack(item);
    }
}

Console.WriteLine();
for (int i = 1; i <= n; i++)
    visited[i] = false;

var queue = new Queue<int>();
queue.Enqueue(v);
visited[v] = true;

while (queue.Count > 0)
{
    var node = queue.Dequeue();
    Console.Write(node + " ");

    foreach (var item in nodes[node])
    {
        if (visited[item])
            continue;

        visited[item] = true;
        queue.Enqueue(item);
    }
}