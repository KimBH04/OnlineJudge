#include <stdio.h>

int main()
{
    char board[64] = {0};
    scanf("%s", board);
    int i = 0;
    while (board[i])
    {
        if (board[i] == 'X')
        {
            for (int j = 1; j < 4; j++)
            {
                if (board[i + j] != 'X')
                {
                    goto NotA;
                }
            }
            board[i] = board[i + 1] = board[i + 2] = board[i + 3] = 'A';
            i += 4;
            continue;

        NotA:
            if (board[i + 1] == 'X')
            {
                board[i] = board[i + 1] = 'B';
                i += 2;
            }
            else
            {
                printf("-1");
                return 0;
            }
        }
        else
        {
            i++;
        }
    }
    printf("%s", board);
    return 0;
}