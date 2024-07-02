#include <stdio.h>

int main() {
#if BOJ
    printf("Hello World!");
#else
    printf("What");
#endif
    return 0;
}