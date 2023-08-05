#include <stdio.h>

int main()
{
    int t;
    scanf("%d", &t);
    while (t--)
    {
        int a, b;
        scanf("%d %d", &a, &b);
        while (b--)
        {
            for (int c = a; c; c--)
            {
                printf("X");
            }
            printf("\n");
        }
        printf("\n");
    }
    return 0;
}