using System;

public class Solution {
    public int solution(int[] num_list) {
        string o, e;
        o = e = "";
        foreach (int i in num_list) {
            if (i % 2 == 1) {
                o += i;
            }
            else {
                e += i;
            }
        }
        return int.Parse(o) + int.Parse(e);
    }
}