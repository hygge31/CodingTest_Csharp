using System;
public class Solution {
    public int[] solution(int n, int m) {

        int gcd = Gcd(n,m);
        int lcm =  gcd *(n/gcd) * (m/gcd);
        
        return new int[]{gcd,lcm};
    }
    
    int Gcd(int a, int b){
     return a%b == 0 ? b : Gcd(b,a%b);
    }
     
}