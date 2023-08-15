using System;

public class Solution {
    public string solution(string rny_string) {
        string answer = "";
        int l = rny_string.Length;
        for (int i = 0; i < l; i++) {
            answer += rny_string[i] == 'm' ? "rn" : $"{rny_string[i]}";
        }
        return answer;
    }
}