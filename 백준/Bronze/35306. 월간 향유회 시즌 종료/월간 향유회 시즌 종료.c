#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n, k;
    scanf("%d%d", &n, &k);
    int **list = (int**)malloc(sizeof(int*) * n);
    for (int i = 0; i < n; i++)
    {
        list[i] = (int*)malloc(sizeof(int) * k);
        for (int j = 0; j < k; j++)
        {
            scanf("%d", list[i] + j);
        }
    }

    int cnt = 0, *check = (int*)calloc(n, sizeof(int) * n);
    for (int i = 0; i < k; i++)
    {
        int max = list[0][i], max_cnt = 1, idx = 0;
        for (int j = 1; j < n; j++)
        {
            if (max < list[j][i])
            {
                max = list[j][i];
                max_cnt = 1;
                idx = j;
            }
            else if (max == list[j][i])
            {
                max_cnt++;
            }
        }
        
        if (max_cnt < 2 && !check[idx])
        {
            cnt++;
            check[idx] = 1;
        }
    }

    printf("%d", cnt);

    for (int i = 0; i < n; i++)
    {
        free(list[i]);
    }
    free(list);
    free(check);
    return 0;
}