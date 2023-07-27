using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int l = numbers.Length;
        int[] answer = new int[l];
        for (int i = 0; i < l; i++) {
            answer[i] = numbers[i] * 2;
        }
        return answer;
    }
}