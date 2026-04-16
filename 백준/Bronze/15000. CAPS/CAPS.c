#include <stdio.h>

int main()
{
    char s[1000000];
    scanf("%s", s);
    for (int i = 0; s[i] != NULL; i++)
    {
        printf("%c", s[i] - 32);
    }
    
    return 0;
}