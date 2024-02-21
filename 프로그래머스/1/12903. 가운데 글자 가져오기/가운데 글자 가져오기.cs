public class Solution {
    public string solution(string s) {
        string answer = "";
        bool even = false;
        int idx = s.Length/2;
        if(s.Length%2 == 0){
            even = true;
        }
        if(even){
            answer+=s[idx-1];
            answer+=s[idx];
        }else{
            answer+=s[idx];
        }
            
        return answer;
    }
}