#include <stdio.h>
#include <stdlib.h>
typedef long long int ll;

const int SIZE = 1 << 26;

int main()
{
    char *buffer = (char*)malloc(SIZE);
    fread(buffer, 1, SIZE, stdin);

    int n = 0;
    int i;
    for (i = 0; buffer[i] !='\n'; i++)
    {
        n *= 10;
        n += buffer[i] - 48;
    }

    i++;
    ll r = 0;
    int t = 0;
    for (; buffer[i] != '\0'; i++)
    {
        if (buffer[i] == '\n')
        {
            r += t;
            t = 0;
        }
        else
        {
            t *= 10;
            t += buffer[i] - 48;
        }
    }

    r += t;

    printf("%d\n%lld", n, r);

    free(buffer);
    return 0;
}