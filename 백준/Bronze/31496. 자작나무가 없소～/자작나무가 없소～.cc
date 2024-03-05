#include <stdio.h>
#include <string.h>

int check(char *base, char *test, int len)
{
    for (int i = 0; i < len; i++)
    {
        if (base[i] != test[i])
        {
            return 0;
        }
    }
    return 1;
}

int main()
{
    int n, r = 0;
    char s[64];
    scanf("%d %s", &n, s);
    int name_len = strlen(s);
    while (n--)
    {
        char name[64];
        int count;
        scanf("%s %d", name, &count);
        int item_len = strlen(name);
        int start = 0;
        for (int i = 0; i <= item_len; i++)
        {
            if (name[i] == '_' || name[i] == '\0')
            {
                if (name_len == i - start && check(name + start, s, name_len))
                {
                    r += count;
                    break;
                }
                start = i + 1;
            }
        }
    }
    printf("%d", r);
    return 0;
}