using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        foreach (string i in s1) {
            foreach (string j in s2) {
                if (i == j) {
                    answer++;
                }
            }
        }
        return answer;
    }
}