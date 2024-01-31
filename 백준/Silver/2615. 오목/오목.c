#include <stdio.h>

int gomoku[30][30] = { { 0, }, };
int dir[4][2][6] =
{
    {
        { 1, 2, 3, 4, -1, 5 },
        { 0, 0, 0, 0, 0, 0 }
    },
    {
        { 0, 0, 0, 0, 0, 0 },
        { 1, 2, 3, 4, -1, 5 }
    },
    {
        { 1, 2, 3, 4, -1, 5 },
        { 1, 2, 3, 4, -1, 5 }
    },
    {
        { -1, -2, -3, -4, 1, -5 },
        { 1, 2, 3, 4, -1, 5 }
    }
};

int main()
{
    for (int i = 5; i < 24; i++)
    {
        for (int j = 5; j < 24; j++)
        {
            scanf("%d", &gomoku[i][j]);
        }
    }

    for (int j = 5; j < 24; j++)
    {
        for (int i = 5; i < 24; i++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (gomoku[i][j] &&
                    gomoku[i][j] == gomoku[i + dir[k][0][0]][j + dir[k][1][0]] &&
                    gomoku[i][j] == gomoku[i + dir[k][0][1]][j + dir[k][1][1]] &&
                    gomoku[i][j] == gomoku[i + dir[k][0][2]][j + dir[k][1][2]] &&
                    gomoku[i][j] == gomoku[i + dir[k][0][3]][j + dir[k][1][3]] &&
                    gomoku[i][j] != gomoku[i + dir[k][0][4]][j + dir[k][1][4]] &&
                    gomoku[i][j] != gomoku[i + dir[k][0][5]][j + dir[k][1][5]])
                {
                    printf("%d\n", gomoku[i][j]);
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
            }
        }
    }
    printf("0");
    return 0;
}
