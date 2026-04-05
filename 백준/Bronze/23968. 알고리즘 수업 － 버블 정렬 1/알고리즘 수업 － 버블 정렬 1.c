#include <stdio.h>

static inline void swap(int *a, int *b) {
    int tmp = *a;
    *a = *b;
    *b = tmp;
}

int main() {
    int n, k, a[10000];

    scanf("%d%d", &n, &k);
    for (int i = 0; i < n; i++) {
        scanf("%d", a + i);
    }
    
    int cnt = 0;
    for (int i = 1; i < n; i++) {
        for (int j = 0; j + i < n; j++) {
            if (a[j] > a[j + 1]) {
                swap(a + j, a + j + 1);
                if (++cnt == k) {
                    printf("%d %d\n", a[j], a[j + 1]);
                    return 0;
                }
            }
        }
    }
    printf("-1\n");
    return 0;
}