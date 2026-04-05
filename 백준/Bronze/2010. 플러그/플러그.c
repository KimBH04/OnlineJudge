#include <stdio.h>

int main()
{
    int n, r = 0, i;
    scanf("%d", &n);
    
    while (n--)
    {
        scanf("%d", &i);
        r += i - 1;
    }
    
    printf("%d", r + 1);
    return 0;
}