#include <stdio.h>

int main()
{
    int n, sets = 0, set[9] = { 0 }, temp[9] = { 1, 1, 1, 1, 1, 1, 2, 1, 1 };

    scanf("%d", &n);
    while (n)
    {
        int r = n % 10;
        if (r == 9)
            r = 6;

        if (set[r] == 0)
        {
            sets++;
            for (int i = 0; i < 9; i++)
            {
                set[i] += temp[i];
            }
        }

        set[r]--;
        n /= 10;
    }

    printf("%d", sets);
    return 0;
}