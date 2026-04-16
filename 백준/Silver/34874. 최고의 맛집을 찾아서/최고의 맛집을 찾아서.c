#include <stdio.h>

int main()
{
    int n, m, count[1000] = { 0 };
    scanf("%d%d", &n, &m);
    for (int i = 0; i < n; i++)
    {
        int scores[1000];
        int max = 0, *ptr;
        for (int j = 0; j < m; j++)
        {
            scanf("%d", ptr = scores + j);
            if (max < *ptr)
            {
                max = *ptr;
            }
        }
        for (int j = 0; j < m; j++)
        {
            if (scores[j] < max)
            {
                count[j]++;
            }
        }
    }

    for (int i = 0; i < m; i++)
    {
        printf("%d ", count[i]);
    }
    return 0;
}