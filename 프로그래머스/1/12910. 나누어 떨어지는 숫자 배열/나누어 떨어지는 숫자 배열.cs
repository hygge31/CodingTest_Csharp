using System.Linq;
using System;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = arr.Where(v => v % divisor == 0).ToArray();
        
        Array.Sort(answer);
       
        return answer.Length == 0 ? new int[]{-1} : answer;
    }

    
}