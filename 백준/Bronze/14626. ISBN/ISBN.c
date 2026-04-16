#include <stdio.h>

int main()
{
    char s[16];
    scanf("%s", s);
    
    int sum = 0;
    int idx = -1;
    for (int i = 0; i < 13; i++)
    {
        if (s[i] == '*')
        {
            idx = i;
            continue;
        }
            
        sum += (s[i] - '0') * (i % 2 * 2 + 1);
    }
    
    idx = idx % 2 * 2 + 1;
    for (int i = 0; i < 10; i++)
    {
        if ((sum + i * idx) % 10 == 0)
        {
            printf("%d", i);
            break;
        }
    }
    return 0;
}