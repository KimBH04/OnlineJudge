#include <stdio.h>
typedef unsigned long long int ull;

int main()
{
    int t;
    scanf("%d", &t);
    while (t--)
    {
        int n, p;
        scanf("%d", &n);
        p = n;
        ull r = 0;
        while (p--)
        {
            ull x;
            scanf("%llu", &x);
            r += x;
            r %= n;
        }
        printf(r ? "NO\n" : "YES\n");
    }
    
    return 0;
}