#include <stdio.h>

int main()
{
    int i, r = 0;
    for (i = 0; i < 5; i++)
    {
        int j;
        char c[10];
        scanf("%s", c);
        for (j = 0; j < 8; j++)
        {
            if (c[j] == 'F' && c[j + 1] == 'B' && c[j + 2] == 'I')
            {
                printf("%d ", i + 1);
                r = 1;
                break;
            }
        }
    }

    if (!r)
        printf("HE GOT AWAY!");

    return 0;
}