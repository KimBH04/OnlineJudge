#include <stdio.h>

int main()
{
    int tile[1001], n;
    tile[0] = tile[1] = 1;
    for (int i = 2; i <= 1000; i++)
    {
        tile[i] = (tile[i - 1] + tile[i - 2]) % 10007;
    }

    scanf("%d", &n);
    printf("%d", tile[n]);
    return 0;
}