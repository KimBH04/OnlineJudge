using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = { 0, 0 };
        foreach (int n in num_list)
        {
            if (n % 2 == 0)
            {
                answer[0]++;
            }
            else
            {
                answer[1]++;
            }
        }
        return answer;
    }
}