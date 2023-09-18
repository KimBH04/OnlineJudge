using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        int s1 = arr1.Sum();
        int s2 = arr2.Sum();
        if (arr1.Length > arr2.Length) {
            answer = 1;
        }
        else if (arr1.Length < arr2.Length) {
            answer = -1;
        }
        else if (s1 > s2) {
            answer = 1;
        }
        else if (s1 < s2) {
            answer = -1;
        }
        return answer;
    }
}