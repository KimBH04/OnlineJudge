using System;

public class Solution {
    public int solution(int n) {
        double answer = Math.Sqrt(n);
        return answer % 1 == 0 ? 1 : 2;
    }
}