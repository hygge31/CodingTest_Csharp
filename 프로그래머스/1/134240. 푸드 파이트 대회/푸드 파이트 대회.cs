using System;
public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string a = "";
        for(int i = 1;i<food.Length;i++){
           int num = food[i]/2;
           for(int j = 0;j<num;j++){
               answer+=$"{i}";
           }
        }
        for(int i = answer.Length-1;i>=0;i--){
            a+=answer[i];
        }
        answer +=$"0{a}";
        return answer;
    }
}