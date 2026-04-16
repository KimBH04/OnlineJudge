#include <stdio.h>

int main()
{
    int n, k, a[10000];
    scanf("%d%d", &n, &k);
    for (int i = 0; i < n; i++)
    {
        scanf("%d", a + i);
    }

    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j + i < n; j++)
        {
            if (a[j] > a[j + 1])
            {
                int tmp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = tmp;
                
                if (--k <= 0)
                {
                    goto end;
                }                
            }
        }
    }

    printf("-1");
    return 0;

    end:
    for (int i = 0; i < n; i++)
    {
        printf("%d ", a[i]);
    }
    return 0;
}