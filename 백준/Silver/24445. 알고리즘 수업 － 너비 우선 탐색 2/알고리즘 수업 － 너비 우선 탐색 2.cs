using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] inputs = sr.ReadLine()!.Split();
int n = int.Parse(inputs[0]),
    m = int.Parse(inputs[1]),
    r = int.Parse(inputs[2]);

List<int>[] nodes = new List<int>[n + 1];
bool[] visited = new bool[n + 1];
int[] sequence = new int[n + 1];
for (int i = 0; i <= n; i++)
{
    nodes[i] = new();
    visited[i] = false;
    sequence[i] = 0;
}

while (m-- > 0)
{
    inputs = sr.ReadLine()!.Split();
    int u = int.Parse(inputs[0]),
        v = int.Parse(inputs[1]);

    nodes[u].Add(v);
    nodes[v].Add(u);
}

for (int i = 0; i <= n; i++)
{
    nodes[i].Sort();
    nodes[i].Reverse();
}

int s = 1;
visited[r] = true;

Queue<int> queue = new();
queue.Enqueue(r);

while (queue.Count > 0)
{
    int v = queue.Dequeue();
    sequence[v] = s++;
    foreach (int i in nodes[v])
    {
        if (visited[i])
            continue;

        visited[i] = true;
        queue.Enqueue(i);
    }
}

foreach (int i in sequence[1..])
{
    sw.WriteLine(i);
}