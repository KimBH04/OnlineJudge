using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        foreach (char a in my_string) {
            if (a.ToString() == letter)
                continue;
            answer += a;
        }
        return answer;
    }
}