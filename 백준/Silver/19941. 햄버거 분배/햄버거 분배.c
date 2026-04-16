#include <stdio.h>
#define MAX(a, b) (((a) > (b)) ? (a) : (b))
#define MIN(a, b) (((a) < (b)) ? (a) : (b))

int main()
{
    int n, k, cnt = 0;
    char s[20000];
    scanf("%d%d%s", &n, &k, s);
    for (int i = 0; i < n; i++)
    {
        if (s[i] != 'P')
            continue;

        for (int j = MAX(0, i - k); j < MIN(i + k + 1, n); j++)
        {
            if (s[j] != 'H')
                continue;

            s[j] = ' ';
            cnt++;
            break;
        }
    }
    printf("%d\n", cnt);
    return 0;
}