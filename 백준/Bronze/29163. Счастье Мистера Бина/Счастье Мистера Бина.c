#include <stdio.h>

int main()
{
    int n, r = 0;
    scanf("%d", &n);
    while (n--)
    {
        int i;
        scanf("%d", &i);
        r += i % 2 ? -1 : 1;
    }
    printf(r > 0 ? "Happy" : "Sad");
    return 0;
}