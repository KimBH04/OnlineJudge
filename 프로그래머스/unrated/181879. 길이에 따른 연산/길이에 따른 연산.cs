using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        if (num_list.Length > 10) {
            foreach (int a in num_list) {
                answer += a;
            }
        }
        else {
            answer = 1;
            foreach (int a in num_list) {
                answer *= a;
            }
        }
        return answer;
    }
}