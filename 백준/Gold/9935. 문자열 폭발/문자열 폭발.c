#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main() {
    char s[1 << 20], bomb[64], *stack;
    scanf("%s%s", s, bomb);
    int s_len = strlen(s), bomb_len = strlen(bomb), i = 0, j = 0, repeat;
    if (s_len < bomb_len) {
        printf("%s", s);
        return 0;
    }

    stack = (char*)malloc(sizeof(char) * (s_len + 1));
    for (; i < bomb_len - 1; i++, j++) {
        stack[j] = s[i];
    }
    
    for (; i < s_len; i++, j++) {
        stack[j] = s[i];
        for (repeat = 0; repeat < bomb_len; repeat++) {
            if (stack[j - repeat] != bomb[bomb_len - (repeat + 1)]) {
                goto not_found;
            }
        }
        j -= bomb_len;
    not_found:;
    }

    stack[j] = '\0';
    printf("%s", j ? stack : "FRULA");

    free(stack);
    return 0;
}