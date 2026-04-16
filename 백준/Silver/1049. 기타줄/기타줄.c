#include <stdio.h>
#define I_MAX 2147483647

int main() {
    int n, m, pack_min = I_MAX, solo_min = I_MAX;
    scanf("%d%d", &n, &m);
    while (m--) {
        int pack, solo;
        scanf("%d%d", &pack, &solo);
        if (pack_min > pack) pack_min = pack;
        if (solo_min > solo) solo_min = solo;
    }
    int magni = 0, price_min = I_MAX;
    do {
        int magni_cnt = magni * 6;
        int price = magni * pack_min + (n > magni_cnt ? (n - magni_cnt) * solo_min : 0);
        if (price_min > price) {
            price_min = price;
        }
        magni++;
    }
    while (magni < n);
    printf("%d", price_min);
    return 0;
}