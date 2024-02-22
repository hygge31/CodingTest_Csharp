using System;
using System.Linq;
public class Solution {
    public string solution(int n) {
    return string.Concat(Enumerable.Repeat("수박", n/2+1)).Substring(0,n);
        
    }
}