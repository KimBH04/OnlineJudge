#include <stdio.h>

int main()
{
    int n, s[101], i;
    scanf("%d", &n);
    for (i = 1; i <= n; i++)
    {
        scanf("%d", &s[i]);
    }

    int t;
    scanf("%d", &t);
    while (t--)
    {
        int a, b;
        scanf("%d %d", &a, &b);

        if (a - 1)
        {
            s[b] = !s[b];
            int left = b - 1, right = b + 1;

            while (left > 0 && right <= n && s[left] == s[right])
            {
                s[left] = !s[left];
                s[right] = !s[right];

                left--;
                right++;
            }
        }
        else
        {
            for (i = b; i <= n; i += b)
            {
                s[i] = !s[i];
            }
        }
    }

    for (i = 1; i <= n; i++)
    {
        printf("%d", s[i]);
        printf(i % 20 ? " " : "\n");
    }

    return 0;
}