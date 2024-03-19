using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        
         Array.Sort(strings, (a, b) => {
            if (a[n] == b[n]) {
                return string.Compare(a, b);
            } else {
                return a[n].CompareTo(b[n]);
            }
        });
        
        return strings;
    }
}