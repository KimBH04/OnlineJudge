#include <stdio.h>

int main()
{
    char str[100];
    scanf("%s", str);

    int i, r = 1;
    for (i = 0; i < 100; i++)
    {
        if (str[i] == ',')
        {
            r++;
        }
    }

    printf("%d", r);
    return 0;
}