#include <stdio.h>

int main()
{
    int bingo_board[25], said[25], bingo_cnt = 0, said_cnt = 0;
    for (int i = 0; i < 25; i++)
    {
        scanf("%d", bingo_board + i);
    }
    for (int i = 0; i < 25; i++)
    {
        scanf("%d", said + i);
    }
    for (int i = 0; i < 25; i++)
    {
        for (int j = 0; j < 25; j++)
        {
            if (bingo_board[j] == said[i])
            {
                bingo_board[j] = 0;
                int not_bingo[4] = {0}, r = j / 5, c = j % 5;
                for (int k = 0; k < 5; k++)
                {
                    if (r != c || bingo_board[k * 5 + k])
                    {
                        not_bingo[0] = 1;
                    }
                    if (r + c != 4 || bingo_board[k * 5 + 4 - k])
                    {
                        not_bingo[1] = 1;
                    }
                    if (bingo_board[k * 5 + c])
                    {
                        not_bingo[2] = 1;
                    }
                    if (bingo_board[5 * r + k])
                    {
                        not_bingo[3] = 1;
                    }
                }
                for (int k = 0; k < 4; k++)
                {
                    bingo_cnt += 1 - not_bingo[k];
                }
            }
        }
        said_cnt++;
        if (bingo_cnt >= 3)
        {
            break;
        }
    }
    printf("%d", said_cnt);
    return 0;
}