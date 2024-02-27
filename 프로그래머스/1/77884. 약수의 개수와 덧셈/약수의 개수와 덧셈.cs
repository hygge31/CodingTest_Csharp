using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
       
        for(int i = left;i<=right;i++){
            int num = Dvisor(i);
            if(num % 2 == 0){
                answer += i;
            }else{
                answer -= i;
            }
        }
        
        return answer;
    }
    
    int Dvisor(int num){
            int count = 1;
            for(int i= 2;i<=num;i++){
                if(num%i == 0){
                    count++;
                }
            }
            return count;
        }
}