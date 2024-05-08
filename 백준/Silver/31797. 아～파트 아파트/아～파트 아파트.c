#include <stdio.h>

int main() {
    int n, m, h1, h2, apart[1000], input[10001] = { 0, }, j = 0;
    scanf("%d %d", &n, &m);
    for (int idx = 1; idx <= m; idx++) {
        scanf("%d %d", &h1, &h2);
        input[h1] = input[h2] = idx;
    }
    for (int idx = 0; idx < 10000; idx++) {
        if (input[idx]) {
            apart[j++] = input[idx];
        }
    }
    printf("%d", apart[(n - 1) % (m + m)]);
    return 0;
}