using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        var h = new HashSet<string>();
        int l = my_string.Length;
        for (int i = 0; i < l; i++) {
            h.Add(my_string.Substring(i));
        }
        return h.Contains(is_suffix) ? 1 : 0;
    }
}