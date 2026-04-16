#include <stdio.h>

int main()
{
    int m = 0, o = 0, b = 0, i = 0, s = 0, j;
    char c[100];
    scanf("%s", c);

    for (j = 0; j < 100; j++)
    {
        switch (c[j])
        {
        case 'M':
            m = 1;
            break;

        case 'O':
            o = 1;
            break;

        case 'B':
            b = 1;
            break;

        case 'I':
            i = 1;
            break;

        case 'S':
            s = 1;
            break;

        default:
            break;
        }
    }

    printf(m && o && b && i && s ? "YES" : "NO");
    return 0;
}