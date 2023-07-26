using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        answer = array.Count(x => x > height);
        return answer;
    }
}