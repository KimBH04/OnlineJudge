#include <stdio.h>

int main()
{
    int n, r = 0, p[101] = { 0 };
    scanf("%d", &n);
    while (n--)
    {
        int x;
        scanf("%d", &x);
        if (p[x])
            r++;
        else
            p[x]++;
    }
    printf("%d", r);
    return 0;
}