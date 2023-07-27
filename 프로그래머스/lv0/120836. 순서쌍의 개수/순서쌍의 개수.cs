using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        double sqrtn = Math.Sqrt(n);
        for (int i = 1; i <= sqrtn; i++) {
            if (n % i == 0) {
                answer++;
                if (n / i != i) {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}