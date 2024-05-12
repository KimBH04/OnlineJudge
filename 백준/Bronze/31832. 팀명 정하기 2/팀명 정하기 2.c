#include <stdio.h>
#include <string.h>

int main() {
    int n; scanf("%d", &n);
    while (n--) {
        char s[21]; scanf("%s", s);
        int len = strlen(s);
        if (len > 10) {
            continue;
        }
        int large_cnt = 0, small_cnt = 0, contain_not_number = 0;
        for (int i = 0; i < len; i++) {
            if (s[i] >= 97) {
                small_cnt++;
                contain_not_number = 1;
            }
            else if (s[i] >= 65) {
                large_cnt++;
                contain_not_number = 1;
            }
            else if (s[i] == '-') {
                contain_not_number = 1;
            }
        }
        if (large_cnt <= small_cnt && contain_not_number) {
            printf("%s", s);
            break;
        }
    }
    return 0;
}