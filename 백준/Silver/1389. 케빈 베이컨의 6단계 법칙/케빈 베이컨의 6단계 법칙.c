#include <stdio.h>
#define INF 21474836

int main()
{
    int n, m, fw[101][101];
    scanf("%d%d", &n, &m);
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            fw[i][j] = INF;
        }
    }

    while (m--)
    {
        int a, b;
        scanf("%d%d", &a, &b);
        fw[a][b] = fw[b][a] = 1;
    }

    for (int k = 1; k <= n; k++)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j)
                {
                    fw[i][j] = 0;
                    continue;
                }

                int sum = fw[i][k] + fw[k][j];
                if (fw[i][j] > sum)
                {
                    fw[i][j] = sum;
                }
            }
        }
    }

    int min = 0x7FFFFFFF, num = 0;
    for (int i = 1; i <= n; i++)
    {
        int cnt = 0;
        for (int j = 1; j <= n; j++)
        {
            cnt += fw[i][j];
        }
        if (min > cnt)
        {
            min = cnt;
            num = i;
        }
    }
    printf("%d", num);
    return 0;
}