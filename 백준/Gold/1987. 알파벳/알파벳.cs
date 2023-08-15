class Program
{
    static readonly int[,] DIR = { { 0, 1 }, { 0, -1 }, { -1, 0 }, { 1, 0 } };
    static string[] map = Array.Empty<string>();
    static int R, C;

    static void Main()
    {
        bool[] visited = { false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false };

        string[] input = Console.ReadLine()!.Split();
        R = int.Parse(input[0]);
        C = int.Parse(input[1]);
        map = new string[R];
        for (int i = 0; i < R; i++)
        {
            map[i] = Console.ReadLine()!;
        }

        Console.WriteLine(DepthFirstSearch(0, 0, visited));
    }

    static int DepthFirstSearch(int x, int y, bool[] visited)
    {
        visited[map[y][x] - 65] = true;
        int r = 1;
        int m = 0;
        for (int i = 0; i < 4; i++)
        {
            if (0 <= x + DIR[i, 0] && x + DIR[i, 0] < C && 0 <= y + DIR[i, 1] && y + DIR[i, 1] < R)
            {
                if (!visited[map[y + DIR[i, 1]][x + DIR[i, 0]] - 65])
                {
                    m = Math.Max(m, DepthFirstSearch(x + DIR[i, 0], y + DIR[i, 1], visited.ToArray()));
                }
            }
        }

        return r + m;
    }
}