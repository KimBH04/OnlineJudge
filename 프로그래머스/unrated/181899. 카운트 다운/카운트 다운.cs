using System;

public class Solution {
    public int[] solution(int start, int end) {
        int l = start - end + 1;
        int[] answer = new int[l];
        for (int i = 0; i < l; i++, start--) {
            answer[i] = start;
        }
        return answer;
    }
}