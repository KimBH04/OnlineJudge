int[,] dir = { { 1, 2 }, { 2, 1 }, { 2, -1 }, { 1, -2 }, { -1, -2 }, { -2, -1 }, { -2, 1 }, { -1, 2 } };

int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    int l = int.Parse(Console.ReadLine()!);
    bool[,] chess = new bool[l, l];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < l; j++)
        {
            chess[i, j] = false;
        }
    }

    Queue<(int, int)> queue = new();

    string[] input = Console.ReadLine()!.Split();
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    queue.Enqueue((x, y));
    chess[x, y] = true;

    input = Console.ReadLine()!.Split();
    int endx = int.Parse(input[0]);
    int endy = int.Parse(input[1]);

    int r = 0;
    while (queue.Count > 0)
    {
        int cnt = queue.Count;
        while (cnt-- > 0)
        {
            (x, y) = queue.Dequeue();

            if (x == endx && y == endy)
            {
                goto end;
            }

            for (int i = 0; i < 8; i++)
            {
                int tx = x + dir[i, 0];
                int ty = y + dir[i, 1];

                if (0 <= tx && tx < l &&
                    0 <= ty && ty < l &&
                    !chess[tx, ty])
                {
                    chess[tx, ty] = true;
                    queue.Enqueue((tx, ty));
                }
            }
        }
        r++;
    }
end:
    Console.WriteLine(r);
}
