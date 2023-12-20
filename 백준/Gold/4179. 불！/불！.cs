string[] inputs = Console.ReadLine()!.Split();
int r = int.Parse(inputs[0]), c = int.Parse(inputs[1]);

Queue<(int, int)> queue = new();
Queue<(int, int)> fireQ = new();

bool[,] visited = new bool[r, c];
bool[,] fire = new bool[r, c]; 
string[] map = new string[r];
for (int i = 0; i < r; i++)
{
    map[i] = Console.ReadLine()!;
    for (int j = 0; j < c; j++)
    {
        if (map[i][j] == 'J')
        {
            visited[i, j] = true;
            queue.Enqueue((i, j));
        }
        else if (map[i][j] == 'F')
        {
            fire[i, j] = true;
            fireQ.Enqueue((i, j));
        }
    }
}

int[,] dir = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };

int cnt = 0;
while (queue.Count > 0)
{
    cnt++;

    int fireCnt = fireQ.Count;
    while (fireCnt-- > 0)
    {
        var (row, col) = fireQ.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int tr = row + dir[i, 0];
            int tc = col + dir[i, 1];
            if (0 <= tr && tr < r && 0 <= tc && tc < c && map[tr][tc] != '#' && !fire[tr, tc])
            {
                fire[tr, tc] = true;
                fireQ.Enqueue((tr, tc));
            }
        }
    }
    
    int qCnt = queue.Count;
    while (qCnt-- > 0)
    {
        var (row, col) = queue.Dequeue();
        if (row == 0 || row == r - 1 || col == 0 || col == c - 1)
        {
            Console.WriteLine(cnt);
            return;
        }

        for (int i = 0; i < 4; i++)
        {
            int tr = row + dir[i, 0];
            int tc = col + dir[i, 1];
            if (0 <= tr && tr < r && 0 <= tc && tc < c && map[tr][tc] != '#' && !fire[tr, tc] && !visited[tr, tc])
            {
                visited[tr, tc] = true;
                queue.Enqueue((tr, tc));
            }
        }
    }
}

Console.WriteLine("IMPOSSIBLE");