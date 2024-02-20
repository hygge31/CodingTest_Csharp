using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        bool[] arr = new bool[10];
        
        for(int i = 0;i<numbers.Length;i++){
            arr[numbers[i]]=true;
        }
        
        for(int i = 0;i<10;i++){
           if(!arr[i]){
               answer+=i;
           }
        }
        
        return answer;
    }
}