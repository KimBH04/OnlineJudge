using System;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        foreach (int n in array) {
            if (height < n) {
                answer++;
            }
        }
        return answer;
    }
}