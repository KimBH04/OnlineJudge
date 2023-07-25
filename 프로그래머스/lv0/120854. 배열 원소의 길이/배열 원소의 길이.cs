using System;

public class Solution {
    public int[] solution(string[] strlist) {
        int l = strlist.Length;
        int[] answer = new int[l];
        for (int i = 0; i < l; i++)
        {
            answer[i] = strlist[i].Length;
        }
        return answer;
    }
}