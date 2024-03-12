using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] arr = s.Split(" ");
        
        
        foreach(string sa in arr){
            string result = "";
           for(int i = 0 ; i<sa.Length;i++){
               if (i % 2 == 0)
                {
                 result += char.ToUpper(sa[i]);
                }
                else
               {
                 result += char.ToLower(sa[i]);
                }
             }
            answer +=$"{result} ";
        }
        
        foreach(string sas in arr){
            Console.WriteLine(sas);
        }
        
        return answer = answer.Substring(0, answer.Length - 1);;
    }
}