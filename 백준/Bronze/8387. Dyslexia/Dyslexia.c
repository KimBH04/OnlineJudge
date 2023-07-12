#include <stdio.h>

int main()
{
    int n, r = 0;
    char o[100000], s[100000];
    
    scanf("%d", &n);
    scanf("%s", o);
    scanf("%s", s);
    
    for (int i = 0; i < n; i++)
    {
        if (o[i] == s[i])
            r++;
    }
    
    printf("%d", r);
    return 0;
}
