#include <stdio.h>

static inline void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

int main() {
    int p; scanf("%d", &p);
    while (p-- > 0) {
        int t, cnt = 0, a[20];
        scanf("%d", &t);
        for (int i = 0; i < 20; i++) {
            scanf("%d", a + i);
            for (int j = i; j > 0; j--) {
                if (a[j - 1] > a[j]) {
                    cnt++;
                    swap(a + j - 1, a + j);
                }
            }
        }
        printf("%d %d\n", t, cnt);
    }
    return 0;
}