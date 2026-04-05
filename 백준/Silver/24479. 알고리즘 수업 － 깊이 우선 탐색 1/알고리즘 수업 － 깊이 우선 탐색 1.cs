using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] inputs = sr.ReadLine()!.Split();
int n = int.Parse(inputs[0]),
    m = int.Parse(inputs[1]),
    r = int.Parse(inputs[2]);

List<int>[] node = new List<int>[n + 1];
bool[] visited = new bool[n + 1];
int[] sequence = new int[n + 1];
for (int i = 0; i <= n; i++)
{
    node[i] = new();
    visited[i] = false;
    sequence[i] = 0;
}

while (m-- > 0)
{
    inputs = sr.ReadLine()!.Split();
    int u = int.Parse(inputs[0]),
        v = int.Parse(inputs[1]);

    node[u].Add(v);
    node[v].Add(u);
}

for (int i = 0; i <= n; i++)
{
    node[i].Sort();
}

visited[r] = true;
sequence[r] = 1;

int s = 2;
DepthFirstSearch(node, visited, sequence, r, ref s);
foreach (int i in sequence[1..])
{
    sw.WriteLine(i);
}

static void DepthFirstSearch(List<int>[] node, bool[] visited, int[] sequence, int v, ref int s)
{
    foreach (int i in node[v])
    {
        if (visited[i])
            continue;

        visited[i] = true;
        sequence[i] = s++;
        DepthFirstSearch(node, visited, sequence, i, ref s);
    }
}
