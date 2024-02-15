using System;
using System.Linq;
public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
       
        return absolutes.Select((v,idx)=> signs[idx] ? v : -v).Sum();
    }
    
}