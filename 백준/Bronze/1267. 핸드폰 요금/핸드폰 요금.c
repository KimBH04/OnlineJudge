#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n, y = 10, m = 15, i;
    scanf("%d", &n);
    int *a = (int *)malloc(n * sizeof(int));
    y *= n;
    m *= n;

    for (i = 0; i < n; i++)
    {
        scanf("%d", a + i);
    }

    for (i = 0; i < n; i++)
    {
        y += *(a + i) / 30 * 10;
        m += *(a + i) / 60 * 15;
    }

    if (y <= m)
        printf("Y ");
    if (y >= m)
        printf("M ");

    printf("%d", y < m ? y : m);

    free(a);
    return 0;
}