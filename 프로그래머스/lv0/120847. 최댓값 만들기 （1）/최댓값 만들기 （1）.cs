using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        Array.Sort(numbers);
        Array.Reverse(numbers);
        answer = numbers[0] * numbers[1];
        return answer;
    }
}