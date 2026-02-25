#include <stdio.h>
#include <string.h>

int main()
{
    int n;
    char list[1000][21];
    char materials[999][21];
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        scanf("%s", list[i]);
    }
    for (int i = 0; i + 1 < n; i++)
    {
        scanf("%s", materials[i]);
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j + 1 < n; j++)
        {
            if (strcmp(list[i], materials[j]) == 0)
            {
                goto next;
            }
        }
        printf("%s", list[i]);
        break;
    next:;
    }

    return 0;
}