string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]), b = int.Parse(inputs[2]);
int[,] plane = new int[n, m];

int highest = 0;
int lowest = 256;
for (int row = 0; row < n; row++)
{
    string[] line = Console.ReadLine()!.Split();
    for (int col = 0; col < m; col++)
    {
        plane[row, col] = int.Parse(line[col]);
        if (highest < plane[row, col])
        {
            highest = plane[row, col];
        }

        if (lowest > plane[row, col])
        {
            lowest = plane[row, col];
        }
    }
}

int fastest = int.MaxValue;
int result = 0;
for (int height = highest; height >= lowest; height--)
{
    int time = 0;
    int inventory = b;
    foreach (int cell in plane)
    {
        int diff = cell - height;
        if (diff < 0)
        {
            time -= diff;
        }
        else
        {
            time += diff + diff;
        }
        inventory += diff;
    }

    if (inventory > -1)
    {
        if (fastest > time)
        {
            fastest = time;
            result = height;
        }
    }
}

Console.WriteLine($"{fastest} {result}");