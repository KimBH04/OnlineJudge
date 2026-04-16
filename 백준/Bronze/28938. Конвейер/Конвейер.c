#include <stdio.h>

int main()
{
    int n, c = 0;
    scanf("%d", &n);
    while (n--)
    {
        int x;
        scanf("%d", &x);
        c += x;
    }
    printf(c > 0 ? "Right" : c < 0 ? "Left" : "Stay");
    return 0;


}