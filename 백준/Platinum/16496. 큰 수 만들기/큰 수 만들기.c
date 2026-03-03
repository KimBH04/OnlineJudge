#include <stdio.h>
#include <string.h>

inline int compare(char *a, char *b)
{
    unsigned long long int first = 0, second = 0;
    for (int i = 0; a[i]; i++)
    {
        first *= 10;
        first += a[i] - '0';
    }
    for (int i = 0; b[i]; i++)
    {
        first *= 10;
        second *= 10;
        first += b[i] - '0';
        second += b[i] - '0';
    }
    for (int i = 0; a[i]; i++)
    {
        second *= 10;
        second += a[i] - '0';
    }

    return first < second ? -1 : first > second ? 1 : 0;
}

int main()
{
    int n, idx[1000], is_zero = 1;
    char ls[1000][11];
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        scanf("%s", ls[idx[i] = i]);
        if (ls[i][0] != '0')
        {
            is_zero = 0;
        }
    }
    if (is_zero)
    {
        printf("0");
        return 0;
    }
    
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j + i < n; j++)
        {
            if (compare(ls[idx[j]], ls[idx[j + 1]]) < 0)
            {
                int temp = idx[j];
                idx[j] = idx[j + 1];
                idx[j + 1] = temp;
            }
        }
    }
    for (int i = 0; i < n; i++)
    {
        printf("%s", ls[idx[i]]);
    }
    return 0;
}