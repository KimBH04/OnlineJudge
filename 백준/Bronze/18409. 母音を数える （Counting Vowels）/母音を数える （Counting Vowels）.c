#include <stdio.h>

int main()
{
    int n, r = 0;
    char s[50];

    scanf("%d", &n);
    scanf("%s", s);

    while (n--)
    {
        if (s[n] == 'a' ||
            s[n] == 'e' ||
            s[n] == 'i' ||
            s[n] == 'o' ||
            s[n] == 'u')
        {
            r++;
        }
    }

    printf("%d", r);
    return 0;
}