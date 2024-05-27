#include <stdio.h>
#include <string.h>

int main()
{
    int t;
    scanf("%d", &t);

    while (t--)
    {
        char x[20], y[20];
        scanf("%s %s", x, y);
        printf("Distances:");

        int len = strlen(x), i;
        for (i = 0; i < len; i++)
        {
            printf(" %d", y[i] + (x[i] > y[i] ? 26 : 0) - x[i]);
        }
        printf("\n");
    }

    return 0;
}