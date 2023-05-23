#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n, ym[10000][13] = { { 0 } };
    scanf("%d", &n);
    
    while (n--)
    {
        int a, b, c, d;
        scanf("%d-%d %d-%d", &a, &b, &c, &d);
        
        ym[a][b] += 1;
        if (d == 12)
        {
            d = 1;
            c++;
        }
        else
        {
            d++;
        }
        ym[c][d] -= 1;
    }

    int i, j, y = 2000, m = 1, max = 0;
    for (i = 2000; i < 10000; i++)
    {
        for (j = 1; j < 13; j++)
        {
            if (j == 1)
            {
                ym[i][j] += ym[i - 1][12];
            }
            else
            {
                ym[i][j] += ym[i][j - 1];
            }

            if (max < ym[i][j])
            {
                max = ym[i][j];
                y = i;
                m = j;
            }
        }
    }

    printf("%d-%02d", y, m);
}