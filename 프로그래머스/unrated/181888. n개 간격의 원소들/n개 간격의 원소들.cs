using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        var a = new List<int>();
        int l = num_list.Length;
        for (int i = 0; i < l; i += n) {
            a.Add(num_list[i]);
        }
        return a.ToArray();
    }
}