#include <stdio.h>
#include <stdlib.h>

int binary_search(int *arr, int right, int n) {
    int left = 0;
    while (left < right) {
        int mid = (left + right) / 2;
        if (arr[mid] < n) {
            left = mid + 1;
        }
        else if (arr[mid] > n) {
            right = mid;
        }
        else {
            return mid;
        }
    }
    return left;
}

int main() {
    int n, q;
    scanf("%d%d", &n, &q);
    int red_count = 0;
    int blue_count = 0;
    int *red_indexes = (int*)malloc(sizeof(int) * n);
    int *blue_indexes = (int*)malloc(sizeof(int) * n);
    char *s = (char*)malloc(sizeof(char) * (n + 1));
    scanf("%s", s);
    for (int i = 0; i < n; i++) {
        switch (s[i])
        {
        case 'R':
            red_indexes[red_count++] = i;
            break;

        case 'B':
            blue_indexes[blue_count++] = i;
            break;
        
        default:
            break;
        }
    }
    while (q--) {
        int l, r;
        scanf("%d%d", &l, &r);
        if (r - l < 3) {
            printf("-1\n");
            continue;
        }
        int red = binary_search(red_indexes, red_count, l);
        int blue = binary_search(blue_indexes, blue_count, r);
        if (blue == blue_count || blue_indexes[blue] > r) {
            blue--;
        }
        if (blue < 1 || red + 2 > red_count) {
            printf("-1\n");
            continue;
        }
        int a = red_indexes[red],
            b = red_indexes[red + 1],
            c = blue_indexes[blue - 1],
            d = blue_indexes[blue];
        if (b < c) {
            printf("%d %d %d %d\n", a, b, c, d);
        }
        else {
            printf("-1\n");
        }
    }
    free(red_indexes);
    free(blue_indexes);
    free(s);
    return 0;
}