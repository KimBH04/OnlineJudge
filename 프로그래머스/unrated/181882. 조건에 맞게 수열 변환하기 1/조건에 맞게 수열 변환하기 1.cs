using System;

public class Solution {
    public int[] solution(int[] arr) {
        int l = arr.Length;
        int[] answer = new int[l];
        for (int i = 0; i < l; i++) {
            if (arr[i] > 49 && arr[i] % 2 == 0) {
                answer[i] = arr[i] / 2;
            }
            else if (arr[i] < 50 && arr[i] % 2 == 1) {
                answer[i] = arr[i] * 2;
            }
            else {
                answer[i] = arr[i];
            }
        }
        return answer;
    }
}