#include <stdio.h>
#include <string.h>

int main()
{
    char s[100];
    while (strcmp(fgets(s, 100, stdin), "***\n\0") != 0)
    {
        int l = strlen(s);
        for (int i = l - 2; i >= 0; i--)
        {
            printf("%c", s[i]);
        }
        printf("\n");
    }
    return 0;
}