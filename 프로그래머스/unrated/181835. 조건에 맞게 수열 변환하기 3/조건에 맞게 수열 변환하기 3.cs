using System;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int l = arr.Length;
        int[] answer = new int[l];
        if (k % 2 == 1){
            for (int i = 0; i < l; i++) {
                answer[i] = arr[i] * k;
            }
        }
        else {
            for (int i = 0; i < l; i++) {
                answer[i] = arr[i] + k;
            }
        }
        return answer;
    }
}