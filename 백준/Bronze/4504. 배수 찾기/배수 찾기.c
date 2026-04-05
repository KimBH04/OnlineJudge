#include <stdio.h>

int main()
{
    int n;
    scanf("%d", &n);
    
    while (1)
    {
        int x;
        scanf("%d", &x);
        if (!x)
            break;
    
        printf("%d is%sa multiple of %d.\n", x, x % n ? " NOT " : " ", n);
    }
    
    return 0;
}
