#include <stdio.h>

int main()
{
    int gomoku[30][30] = { { 0, }, };
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
            if (gomoku[i][j] == gomoku[i + 1][j] &&
                gomoku[i][j] == gomoku[i + 2][j] &&
                gomoku[i][j] == gomoku[i + 3][j] &&
                gomoku[i][j] == gomoku[i + 4][j] &&
                gomoku[i][j] != gomoku[i - 1][j] &&
                gomoku[i][j] != gomoku[i + 5][j])
            {
                if (gomoku[i][j] == 1)
                {
                    printf("1\n");
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
                else if (gomoku[i][j] == 2)
                {
                    printf("2\n");
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
            }
            
            if (gomoku[i][j] == gomoku[i][j + 1] &&
                gomoku[i][j] == gomoku[i][j + 2] &&
                gomoku[i][j] == gomoku[i][j + 3] &&
                gomoku[i][j] == gomoku[i][j + 4] &&
                gomoku[i][j] != gomoku[i][j - 1] &&
                gomoku[i][j] != gomoku[i][j + 5])
            {
                if (gomoku[i][j] == 1)
                {
                    printf("1\n");
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
                else if (gomoku[i][j] == 2)
                {
                    printf("2\n");
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
            }

            if (gomoku[i][j] == gomoku[i + 1][j + 1] &&
                gomoku[i][j] == gomoku[i + 2][j + 2] &&
                gomoku[i][j] == gomoku[i + 3][j + 3] &&
                gomoku[i][j] == gomoku[i + 4][j + 4] &&
                gomoku[i][j] != gomoku[i - 1][j - 1] &&
                gomoku[i][j] != gomoku[i + 5][j + 5])
            {
                if (gomoku[i][j] == 1)
                {
                    printf("1\n");
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
                else if (gomoku[i][j] == 2)
                {
                    printf("2\n");
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
            }
            
            if (gomoku[i][j] == gomoku[i - 1][j + 1] &&
                gomoku[i][j] == gomoku[i - 2][j + 2] &&
                gomoku[i][j] == gomoku[i - 3][j + 3] &&
                gomoku[i][j] == gomoku[i - 4][j + 4] &&
                gomoku[i][j] != gomoku[i + 1][j - 1] &&
                gomoku[i][j] != gomoku[i - 5][j + 5])
            {
                if (gomoku[i][j] == 1)
                {
                    printf("1\n");
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
                else if (gomoku[i][j] == 2)
                {
                    printf("2\n");
                    printf("%d %d", i - 4, j - 4);
                    return 0;
                }
            }
        }
    }
    printf("0");
    return 0;
}