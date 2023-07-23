using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        foreach (int i in numbers)
        {
            answer += i;
        }
        return answer / numbers.Length;
    }
}