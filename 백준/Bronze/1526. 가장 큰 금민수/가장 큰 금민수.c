#include <stdio.h>
#include <string.h>

int golden_min_num(int n)
{
    char str[10];
    sprintf(str, "%d", n);
    int len = strlen(str);
    for (int i = 0; i < len; i++)
    {
        if (str[i] != 52 && str[i] != 55)
        {
            return 0;
        }
    }

    return 1;
}

int main()
{
    int n;
    scanf("%d", &n);
    for (int i = n; i > 3; i--)
    {
        if (golden_min_num(i))
        {
            printf("%d", i);
            break;
        }
    }
    return 0;
}