int[,] sudoku = new int[9, 9];
List<(int, int)> coor = new();

for (int i = 0; i < 9; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < 9; j++)
    {
        sudoku[i, j] = int.Parse(inputs[j]);
        if (sudoku[i, j] == 0)
        {
            coor.Add((i, j));
        }
    }
}

SolvingSudoku(sudoku, coor, 0, coor.Count);
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(sudoku[i, j] + " ");
    }
    Console.WriteLine();
}

static bool SolvingSudoku(int[,] sudoku, List<(int, int)> coor, int m, int depth)
{
    if (m == depth)
    {
        return true;
    }
    else
    {
        for (int i = 1; i < 10; i++)
        {
            var (r, c) = coor[m];

            for (int j = 0; j < 9; j++)
            {
                if (sudoku[r, j] == i || sudoku[j, c] == i)
                {
                    goto next;
                }
            }

            var (rs, re) = CheckBox(r);
            var (cs, ce) = CheckBox(c);

            for (int j = rs; j < re; j++)
            {
                for (int k = cs; k < ce; k++)
                {
                    if (sudoku[j, k] == i)
                    {
                        goto next;
                    }
                }
            }

            sudoku[r, c] = i;
            if (SolvingSudoku(sudoku, coor, m + 1, depth))
            {
                return true;
            }
            sudoku[r, c] = 0;

        next:;
        }

        return false;
    }
}

static (int, int) CheckBox(int n)
{
    if (n < 3)
    {
        return (0, 3);
    }
    else if (n < 6)
    {
        return (3, 6);
    }
    else
    {
        return (6, 9);
    }
}