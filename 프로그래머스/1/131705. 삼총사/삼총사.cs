using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        List<int> combination = new List<int>();
        Combination(number,combination,0,3,ref answer);
        
        return answer;
    }
    
   public void Combination(int[] numbers, List<int> combination, int start, int end,ref int answer){
        if(end == 0){
            int sum = 0;
            foreach(int num in combination){
                sum +=num;
            }
            if(sum == 0){
                answer++;
            }
            return;
        }
   
       for(int i = start;i <= numbers.Length-end;i++){
           combination.Add(numbers[i]);
           Combination(numbers, combination, i + 1, end - 1, ref answer);
           combination.Remove(numbers[i]);
       }
    }

}

