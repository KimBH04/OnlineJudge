#include <stdio.h>
#include <math.h>

int main() {
    int a, b, c, d;
    scanf("%d%d%d", &a, &b, &c);
    d = a + b;
    printf("%d", c ? c * c - d : (int)(sqrt(d) + 0.5));
    return 0;
}