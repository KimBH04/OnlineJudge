#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    int t;
    scanf("%d", &t);
    while (t--)
    {
        int a, b;
        char *s = (char *)malloc(sizeof(char) * 1000000);
        scanf("%d %d", &a, &b);
        scanf("%s", s);

        int l = strlen(s);
        for (int i = 0; i < l; i++)
        {
            printf("%c", (a * (*(s + i) - 65) + b) % 26 + 65);
        }
        printf("\n");

        free(s);
    }
    return 0;
}