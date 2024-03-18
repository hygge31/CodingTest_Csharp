using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for(int i = 0;i<s.Length;i++){
            int a = Convert.ToInt32(s[i]);
            Console.Write(a);
            
                if(a ==32){
                    answer+=" ";
                    continue;
                }
            
                if(a<=90){
                    a+=n;
                    if(a>90){
                        answer+=(char)(64+(a-90));
                    }else{
                        answer+=(char)a;
                    }
                }else{
                    a+=n;
                    if(a>122){
                        answer+=(char)(96+(a-122));
                    }else{
                        answer+=(char)a;
                    }
                }
            
        }
        //97,122
        return answer;
    }
}