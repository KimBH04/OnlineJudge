class Program
{
    static bool[] visited;
    static int[] maxes;
    static List<int>[] list;
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        int n = int.Parse(input[0]), m = int.Parse(input[1]);

        list = new List<int>[n + 1];
        for (int i = 0; i <= n; i++) list[i] = new List<int>();

        for (int i = 0; i < m; i++)
        {
            input = Console.ReadLine().Split();
            int a = int.Parse(input[0]), b = int.Parse(input[1]);

            list[b].Add(a);
        }

        maxes = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            visited = new bool[n + 1];
            maxes[i] = DFS(i);
        }

        var max = int.MinValue;
        foreach (var i in maxes) max = Math.Max(i, max);

        for (int i = 1; i <= n; i++) if (maxes[i] == max) Console.Write(i + " ");
    }

    static int DFS(int graph)
    {
        var r = 1;
        visited[graph] = true;

        foreach (var i in list[graph]) if (!visited[i]) r += DFS(i);

        return r;
    }
}