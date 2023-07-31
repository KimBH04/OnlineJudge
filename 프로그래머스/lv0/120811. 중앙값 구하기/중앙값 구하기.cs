using System;

public class Solution {
    public int solution(int[] array) {
        Array.Sort(array);
        int answer = array[array.Length / 2];
        return answer;
    }
}