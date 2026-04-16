#include <stdio.h>

int main()
{
    int n, a[50], b[50];
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        scanf("%d", a + i);
    }

    for (int i = 0; i < n; i++)
    {
        int min = a[0];
        int idx = 0;
        for (int j = 1; j < n; j++)
        {
            if (min > a[j])
            {
                min = a[j];
                idx = j;
            }
        }
        b[idx] = i;
        a[idx] = __INT_MAX__;
    }
    
    for (int i = 0; i < n; i++)
    {
        printf("%d ", b[i]);
    }
    return 0;
}