#include <stdio.h>

int main()
{
    int n, cow[11] = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, }, r = 0;
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        int num, witch;
        scanf("%d %d", &num, &witch);

        if (cow[num] == -1)
        {
            cow[num] = witch;
        }
        else if (cow[num] != witch)
        {
            cow[num] = witch;
            r++;
        }
    }

    printf("%d", r);
    return 0;
}