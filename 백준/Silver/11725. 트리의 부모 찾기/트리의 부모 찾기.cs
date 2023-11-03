using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine()!);

List<int>[] node = new List<int>[n + 1];
bool[] visited = new bool[n + 1];
int[] parent = new int[n + 1];
for (int i = 0; i <= n; i++)
{
    node[i] = new();
    visited[i] = false;
}

for (int i = 1; i < n; i++)
{
    string[] inputs = sr.ReadLine()!.Split();
    int s = int.Parse(inputs[0]), e = int.Parse(inputs[1]);

    node[s].Add(e);
    node[e].Add(s);
}

visited[1] = true;
DepthFirstSearch(node, visited, parent, 1);
foreach (int i in parent[2..])
{
    sw.WriteLine(i);
}

static void DepthFirstSearch(List<int>[] node, bool[] visited, int[] parent, int v)
{
    foreach (int i in node[v])
    {
        if (visited[i])
            continue;

        visited[i] = true;
        parent[i] = v;
        DepthFirstSearch(node, visited, parent, i);
    }
}
