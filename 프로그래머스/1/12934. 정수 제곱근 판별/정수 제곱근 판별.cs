using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        long sqrt = (long)Math.Sqrt(n);
        answer = (long)Math.Pow(sqrt,2);
        
        
        if(answer ==n){
            answer = (long)Math.Pow(sqrt+1,2);
        }else{
            answer = -1;
        }
        return answer;
    }
}