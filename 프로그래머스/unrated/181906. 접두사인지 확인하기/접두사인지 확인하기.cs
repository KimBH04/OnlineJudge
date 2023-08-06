using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int l = is_prefix.Length;
        if (my_string.Length < l) {
            return 0;
        }
        for (int i = 0; i < l; i++) {
            if (my_string[i] != is_prefix[i]) {
                return 0;
            }
        }
        return 1;
    }
}