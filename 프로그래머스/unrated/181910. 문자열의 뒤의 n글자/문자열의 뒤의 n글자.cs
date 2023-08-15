using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        int l = my_string.Length;
        for (int i = l - n; i < l; i++) {
            answer += my_string[i];
        }
        return answer;
    }
}