#include <stdio.h>
#include <stdlib.h>

typedef struct locate
{
    long long int x, y;
}
locate;

int main()
{
    int n; scanf("%d", &n);
    locate *locates[10001] = {NULL};
    for (int i = 0; i < n; i++)
    {
        locates[i] = (locate*)malloc(sizeof(locate));
        scanf("%lld%lld", &locates[i]->x, &locates[i]->y);
    }
    locates[n] = locates[0];
    long long int sum = 0LL;
    for (int i = 0; i < n; i++)
    {
        sum += locates[i]->x * locates[i + 1]->y - locates[i]->y * locates[i + 1]->x;
    }
    printf("%.1f", (sum < 0 ? -sum : sum) * 0.5);
    for (int i = 0; i < n; i++)
    {
        free(locates[i]);
    }
    return 0;
}