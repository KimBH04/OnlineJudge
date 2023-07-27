using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach (char c in my_string) {
            if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u') {
                answer += c;
            }
        }
        return answer;
    }
}