using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        foreach (int i in num_list)
            if (i == n)
                return 1;
        return 0;
    }
}