using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach (char c in my_string.Reverse()) {
            answer += c;
        }
        return answer;
    }
}