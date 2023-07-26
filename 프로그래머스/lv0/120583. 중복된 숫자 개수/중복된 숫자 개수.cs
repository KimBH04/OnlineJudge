using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        answer = array.Count(x => x == n);
        return answer;
    }
}