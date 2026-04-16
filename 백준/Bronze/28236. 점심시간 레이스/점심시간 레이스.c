#include <stdio.h>

int main()
{
    int n, m, k;
    scanf("%d %d %d", &n, &m, &k);
    int min = 2147483647;
    int class = 0;
    for (int i = 1; i <= k; i++)
    {
        int f, d;
        scanf("%d %d", &f, &d);
        int dis = m - d + f;
        if (min > dis)
        {
            min = dis;
            class = i;
        }
    }
    printf("%d", class);

    return 0;
}