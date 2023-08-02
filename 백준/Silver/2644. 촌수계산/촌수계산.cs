int n = int.Parse(Console.ReadLine()!);
bool[] visited = new bool[n + 1];
List<int>[] graph = new List<int>[n + 1];
for (int i = 1; i <= n; i++)
{
    visited[i] = false;
    graph[i] = new();
}

string[] input = Console.ReadLine()!.Split();
int a = int.Parse(input[0]),
    b = int.Parse(input[1]);

int m = int.Parse(Console.ReadLine()!);
while (m-- > 0)
{
    input = Console.ReadLine()!.Split();
    int x = int.Parse(input[0]),
        y = int.Parse(input[1]);

    graph[x].Add(y);
    graph[y].Add(x);
}

Console.WriteLine(DepthFirstSearch(a, 0));

int DepthFirstSearch(int v, int n)
{
    if (v == b)
        return n;

    foreach (int x in graph[v])
    {
        if (visited[x])
            continue;

        visited[x] = true;
        int y = DepthFirstSearch(x, n + 1);
        if (y > 0)
        {
            return y;
        }
    }
    return -1;
}
