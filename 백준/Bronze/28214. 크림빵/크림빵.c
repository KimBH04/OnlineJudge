#include <stdio.h>

int main()
{
    int n, k, p, r = 0;
    scanf("%d %d %d", &n, &k, &p);
    while (n--)
    {
        int e = 0;
        for (int i = 0; i < k; i++)
        {
            int c;
            scanf("%d", &c);
            if (!c)
            {
                e++;
            }
        }
        if (e < p)
        {
            r++;
        }
    }
    printf("%d", r);
    return 0;
}