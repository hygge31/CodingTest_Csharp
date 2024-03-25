using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        answer[0] = -1;
        for(int i =s.Length-1;i>0;i--){
            for(int j = i-1;j>=0;j--){
                if(s[i]==s[j]){
                    answer[i] =i-j;
                    break;
                }
                answer[i] = -1;
            }
        }
        return answer;
    }
 
}