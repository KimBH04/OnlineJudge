using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        foreach (int i in my_string) {
            if (i - 48 < 10) {
                answer += i - 48;
            }
        }
        return answer;
    }
}