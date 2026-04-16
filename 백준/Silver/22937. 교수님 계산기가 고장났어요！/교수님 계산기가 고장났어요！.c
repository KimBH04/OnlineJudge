#include <stdio.h>
typedef unsigned long long int ull;
const ull p = 1000000000000000000ULL;

int main()
{
    int n;
    scanf("%d", &n);
    while (n--)
    {
        char a[16], b[16];
        scanf("%s %s", a, b);
        short idx_a = 0, idx_b = 0;
        if (a[0] == '-')
        {
            idx_a = 1;
        }
        if (b[0] == '-')
        {
            idx_b = 1;
        }
        short is_minus = idx_a != idx_b;
        ull la = 0, lb = 0;
        
        for (short i = idx_a; i < idx_a + 11; i++)
        {
            if (a[i] == '.')
            {
                continue;
            }
            
            la *= 10;
            la += a[i] - '0';
        }
        
        for (short i = idx_b; i < idx_b + 11; i++)
        {
            if (b[i] == '.')
            {
                continue;
            }
            
            lb *= 10;
            lb += b[i] - '0';
        }
        
        ull result = la * lb;
        if (is_minus)
        {
            printf("-");
        }
        
        printf("%lld.%018lld\n", result / p, result % p);
    }
    return 0;
}