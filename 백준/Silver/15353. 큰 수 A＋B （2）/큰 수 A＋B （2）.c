#include <stdio.h>
#include <string.h>

int length(int *i, int end_num)
{
    for (int j = 0;; j++)
    {
        if (i[j] == end_num)
        {
            return j;
        }
    }
}

void int_reverse(int *i, int len)
{
    for (int j = 0; j < len / 2; j++)
    {
        int temp = i[j];
        i[j] = i[len - j - 1];
        i[len - j - 1] = temp;
    }
}

void char_reverse(char *s, int len)
{
    for (int i = 0; i < len / 2; i++)
    {
        char temp = s[i];
        s[i] = s[len - i - 1];
        s[len - i - 1] = temp;
    }
}

int char2int(char c)
{
    return c - 48;
}

int main()
{
    char a[10002], b[10002];
    scanf("%s %s", a, b);

    int alen = strlen(a);
    int blen = strlen(b);
    char_reverse(a, alen);
    char_reverse(b, blen);

    int len = 0;
    if (alen < blen)
    {
        len = blen;
        for (int i = alen; i < blen; i++)
        {
            a[i] = '0';
        }
    }
    else
    {
        len = alen;
        for (int i = blen; i < alen; i++)
        {
            b[i] = '0';
        }
    }

    int r[10002];
    for (int i = 0; i < 10002; i++)
    {
        r[i] = -1;
    }
    int o = 0;
    for (int i = 0; i < len; i++)
    {
        r[i] = char2int(a[i]) + char2int(b[i]) + o;

        o = r[i] / 10;
        r[i] %= 10;
    }
    r[len] = o > 0 ? 1 : -1;

    int rlen = length(r, -1);
    int_reverse(r, rlen);

    for (int i = 0; i < rlen; i++)
    {
        printf("%d", r[i]);
    }
    return 0;
}