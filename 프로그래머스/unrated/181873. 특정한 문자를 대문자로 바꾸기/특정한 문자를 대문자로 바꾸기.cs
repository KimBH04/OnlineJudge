using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        foreach (char c in my_string) {
            answer += c == alp[0] ? (char)(c - 32) : c;
        }
        return answer;
    }
}