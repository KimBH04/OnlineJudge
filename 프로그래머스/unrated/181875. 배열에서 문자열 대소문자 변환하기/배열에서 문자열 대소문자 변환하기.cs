using System;

public class Solution {
    public string[] solution(string[] strArr) {
        int l = strArr.Length;
        string[] answer = new string[l];
        for (int i = 0; i < l; i++) {
            answer[i] = i % 2 == 0 ? strArr[i].ToLower() : strArr[i].ToUpper();
        }
        return answer;
    }
}