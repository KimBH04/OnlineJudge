using System;

public class Solution {
    public int solution(string str1, string str2) {
        if (str2.Contains(str1)) {
            return 1;
        }
        else {
            return 0;
        }
    }
}