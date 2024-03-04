public class Solution {
    public bool solution(string s) {
    
        if(s.Length ==4 || s.Length==6){
            bool result = int.TryParse(s,out _);
            return result;
        }
      
     return false;
    }
}