#include <stdio.h>
#include <string.h>

int main()
{
    int cnt = 0, n;
    scanf("%d", &n);

    for (int i = 0; i < n; i++, cnt++)
    {
        char s[10];
        sprintf(s, "%d", i);
        int len = strlen(s);

        int b = 0;
        for (int i = 0; i < len - 1; i++)
        {
            if (s[i] == '5' && s[i + 1] == '0')
            {
                b = 1;
                break;
            }
        }

        cnt += b;
    }

    printf("%d", cnt);
    return 0;
}