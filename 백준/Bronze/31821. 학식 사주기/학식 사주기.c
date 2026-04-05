#include <stdio.h>

int main() {
    int n, m, a[10000], total = 0;
    scanf("%d", &n);
    for (int i = 0; i < n; i++) {
        scanf("%d", a + i);
    }
    scanf("%d", &m);
    while (m--) {
        scanf("%d", &n);
        total += a[n - 1];
    }
    printf("%d", total);
    return 0;
}