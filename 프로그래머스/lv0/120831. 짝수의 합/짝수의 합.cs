using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if (n != 1)
        {
            answer = n / 2 * (n + 2) / 2;
        }
        return answer;
    }
}