#include <stdio.h>

int main()
{
    int p[4] = {0}, t0, t1, t[128] = {0}, cnt = 0, result = 0;
    scanf("%d%d%d", p + 1, p + 2, p + 3);
    for (int i = 0; i < 3; i++)
    {
        scanf("%d%d", &t0, &t1);
        t[t0]++;
        t[t1]--;
    }
    for (int i = 1; i <= 100; i++)
    {
        cnt += t[i];
        result += p[cnt] * cnt;
    }
    printf("%d", result);
    return 0;
}