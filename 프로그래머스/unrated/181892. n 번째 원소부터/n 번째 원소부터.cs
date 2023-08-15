using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int l = num_list.Length;
        int[] answer = new int[l - n + 1];
        for (int i = 0; i <= l - n; i++) {
            answer[i] = num_list[n + i - 1];
        }
        return answer;
    }
}