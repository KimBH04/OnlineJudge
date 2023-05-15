#include <stdio.h>

int main()
{
    int n[3], i, j;
    scanf("%d %d %d", &n[0], &n[1], &n[2]);

    for (i = 1; i < 3; i++)
    {
        for (j = 0; j < 3 - i; j++)
        {
            if (n[j] > n[j + 1])
            {
                int temp = n[j];
                n[j] = n[j + 1];
                n[j + 1] = temp;
            }
        }
    }

    char s[4];
    scanf("%s", s);

    for (i = 0; i < 3; i++)
    {
        printf("%d ", n[s[i] - 65]);
    }

    return 0;
}