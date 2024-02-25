int n = int.Parse(Console.ReadLine()!);
int[,] @class = new int[n, 5];
bool[,] mets = new bool[n, n];

for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < 5; j++)
    {
        @class[i, j] = int.Parse(inputs[j]);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        for (int k = j + 1; k < n; k++)
        {
            if (@class[j, i] == @class[k, i])
            {
                mets[j, k] = mets[k, j] = true;
            }
        }
    }
}

int max = 0; int num = 1;
for (int i = 0; i < n; i++)
{
    int met = 0;
    for (int j = 0; j < n; j++)
    {
        if (mets[i, j])
        {
            met++;
        }
    }

    if (max < met)
    {
        max = met;
        num = i + 1;
    }
}

Console.WriteLine(num);