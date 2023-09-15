using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        foreach (char c in myString.ToLower()) {
            if (c == 'a') {
                answer += 'A';
            }
            else {
                answer += c;
            }
        }
        return answer;
    }
}