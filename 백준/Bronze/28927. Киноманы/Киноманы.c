#include <stdio.h>
#define T(t, e, f) (t * 3 + e * 20 + f * 120)

int main()
{
    int t1, e1, f1, t2, e2, f2;
    scanf("%d %d %d %d %d %d", &t1, &e1, &f1, &t2, &e2, &f2);
    int max = T(t1, e1, f1), mel = T(t2, e2, f2);
    printf(max > mel ? "Max" : max < mel ? "Mel" : "Draw");
    return 0;
}