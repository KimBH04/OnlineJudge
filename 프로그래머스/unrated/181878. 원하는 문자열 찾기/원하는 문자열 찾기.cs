using System;

public class Solution {
    public int solution(string myString, string pat) {
        myString = myString.ToLower();
        pat = pat.ToLower();
        
        int answer = myString.Contains(pat) ? 1 : 0;
        return answer;
    }
}