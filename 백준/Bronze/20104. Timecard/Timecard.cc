#include "timecard.h"

void init(int n) { }

std::string convert(std::string s) {
    int len = s.length();
    for (int i = 0; i < len; i++) {
        if (s[i] < 97) s[i] = s[i] + 32;
    }
    return s;
}
