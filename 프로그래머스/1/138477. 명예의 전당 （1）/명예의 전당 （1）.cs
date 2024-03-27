using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> list = new List<int>();
        for(int i = 0;i<score.Length;i++){
             list.Add(score[i]);
             list.Sort((x,y)=>y.CompareTo(x));
            if(list.Count > k){
                answer[i] = list[k-1];
            }else{   
                answer[i] = list[i];
            }            
        }
    
        return answer;
    }
}