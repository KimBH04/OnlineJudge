#include <stdio.h>

int main()
{
    int n, min = 5;
    char s[101], eagle[] = { 'e', 'a', 'g', 'l', 'e' };
    scanf("%d%s", &n, s);
    for (int i = 0; i + 4 < n; i++)
    {
        int total = 0;
        for (int j = 0; j < 5; j++)
        {
            if (s[i + j] != eagle[j])
            {
                total++;
            }
        }
        if (min > total)
        {
            min = total;
        }
    }
    printf("%d", min);
    return 0;
}