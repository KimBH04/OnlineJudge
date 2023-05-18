#include <stdio.h>

int main()
{
    int i, j, c[] = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

    for (i = 0; i < 10; i++)
    {
        int a, b;
        scanf("%d %d", &a, &b);

        int n = (b - a + 1) / 2;
        for (j = 0; j < n; j++)
        {
            int temp = c[a + j];
            c[a + j] = c[b - j];
            c[b - j] = temp;
        }
    }

    for (i = 1; i < 21; i++)
        printf("%d ", c[i]);

    return 0;
}