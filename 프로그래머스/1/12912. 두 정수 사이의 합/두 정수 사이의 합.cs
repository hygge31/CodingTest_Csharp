using System;

public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long min = Math.Min(a,b);
        long max = Math.Max(a,b);
        
        
        
        
        for(long i = min;i<=max;i++){
            answer +=i;
        }
        return answer;
    }
}