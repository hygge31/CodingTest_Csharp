using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        while(n/10 != 0){
            answer += n%10;
            n= n/10;
        }
        
        return answer+n;
    }
}