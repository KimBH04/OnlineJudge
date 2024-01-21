using System;

public class Solution {
    public int solution(int n, int t) {
        n *= 1 << t;
        return n;
    }
}