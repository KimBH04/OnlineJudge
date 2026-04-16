#include <stdio.h>

int main()
{
    char s[100002], t[100002];
    while (scanf("%s%s", s, t) != EOF)
    {
        int j = 0;
        for (int i = 0; t[i]; i++)
        {
            if (s[j] == t[i])
            {
                j++;
            }
        }
        printf(s[j] ? "No\n" : "Yes\n");
    }

    return 0;
}