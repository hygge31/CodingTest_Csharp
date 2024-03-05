using System;
public class Solution {
    public int[] solution(int n, int m) {
       
        int min = Math.Min(n,m);
        int max = Math.Max(n,m);
   
        int gcd = Gcd(max,min);
        int lcm =  gcd *(n/gcd) * (m/gcd);
        
        return new int[]{gcd,lcm};
    }
    
    int Gcd(int a, int b){
        if(a%b == 0){
            return b;
        }
        int Q = (a/b);
        int R = a%b;
        
        return Gcd(b,R);
    }
     
}