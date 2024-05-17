#include <stdio.h>

int main() {
    int n, m, local[16384], start = 1, end = 0, mid, sum = 0, i;
    scanf("%d", &n);
    for (i = 0; i < n; i++) {
        scanf("%d", local + i);
        sum += local[i];
        if (end < local[i]) {
            end = local[i];
        }
    }
    scanf("%d", &m);
    if (sum <= m) {
        printf("%d", end);
        return 0;
    }

    while (start < end) {
        mid = (start + end) / 2;
        sum = 0;
        for (i = 0; i < n; i++) {
            sum += local[i] < mid ? local[i] : mid;
        }
        if (sum < m) {
            if (start == mid) {
                break;
            }
            start = mid;
        }
        else if (sum > m) {
            end = mid;
        }
        else {
            break;
        }
    }
    printf("%d", mid);
    return 0;
}