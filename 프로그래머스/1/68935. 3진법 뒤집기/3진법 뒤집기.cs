using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string num = "";
        
        if(n/3 != 0){
             while(true){
            int a = n/3;
            int b = n%3;
            
            n = a;
            num+=b;
            
            if(a/3 == 0){
                num+=a;
                break;
            }
            
        }
        
        for(int i =0;i<num.Length;i++){
            int number = int.Parse(num[i].ToString());
            answer += (int)Math.Pow(3,num.Length-1-i) * number;
        }
            
            
        }else{
            answer = n;
        }
        
       
    
        return answer;
    }
}