using System;
using System.Linq;

public class Solution {
    public int[] solution(long n) {
        
        int len = n.ToString().Length;
        
        string[] arr = n.ToString().Select(c=>c.ToString()).ToArray();
        arr = arr.Reverse().ToArray();
     
        int[] answer = arr.Select(int.Parse).ToArray();
        
        
        return answer;
    }
}