#include <stdio.h>

int main() {
    int n, arr[200001], kinds[10] = {0}, left = 0, right, max = 0, kind = 0;
    scanf("%d", &n);
    for (right = 0; right < n; right++) {
        scanf("%d", arr + right);
        if (!kinds[arr[right]]++) {
            kind++;
        }
        for (; kind > 2; left++) {
            if (!--kinds[arr[left]]) {
                kind--;
            }
        }
        int cnt = right - left + 1;
        if (max < cnt) {
            max = cnt;
        }
    }
    printf("%d", max);
    return 0;
}