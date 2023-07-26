using System;

public class Solution {
    public int solution(int price) {
        int answer = 0;
        if (price > 499999) {
            answer = price * 4 / 5;
        }
        else if (price > 299999) {
            answer = price * 9 / 10;
        }
        else if (price > 99999) {
            answer = price * 19 / 20;
        }
        else {
            answer = price;
        }
        
        return answer;
    }
}