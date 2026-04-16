#include <stdio.h>

int main()
{
    int n, a[10001] = { 0, }, m = 0;
    scanf("%d", &n);
    
    while (n--)
    {
        int x;
        scanf("%d", &x);
        a[x]++;
        
        if (m < x)
        {
            m = x;
        }
    }
    
    m++;
    for (int i = 1; i < m; i++)
    {
        while (a[i]--)
        {
            printf("%d\n", i);
        }
    }
    return 0;
}
