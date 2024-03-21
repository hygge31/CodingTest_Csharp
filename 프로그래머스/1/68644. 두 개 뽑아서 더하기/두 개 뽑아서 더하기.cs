using System;
using System.Collections.Generic;
public class Solution {
    public List<int>solution(int[] numbers) {     
        
        List<int> combination = new List<int>();
        HashSet<int> list = new HashSet<int>();
        Combination(numbers,combination,0,2,ref list);
        combination = new List<int>(list);
        combination.Sort();
        
    
        return combination;
    }
    
    public void Combination(int[] numbers, List<int> combination, int start, int end,ref HashSet<int> list){
        if(end == 0){
            int sum = 0;
         foreach(int i in combination){
             sum += i;
         }
            list.Add(sum);
            return;
        }
   
       for(int i = start;i <= numbers.Length-end;i++){
           combination.Add(numbers[i]);
           Combination(numbers, combination, i + 1, end - 1,ref list);
           combination.Remove(numbers[i]);
       }
    }
}