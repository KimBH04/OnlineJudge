using System;

public class Solution {
    public int solution(string myString, string pat) {
        string str = "";
        int answer = 0, l = myString.Length;
        for (int i = 0; i < l; i++) {
            str += myString[i] == 'A' ? 'B' : 'A';
        }
        answer = str.Contains(pat) ? 1 : 0;
        return answer;
    }
}