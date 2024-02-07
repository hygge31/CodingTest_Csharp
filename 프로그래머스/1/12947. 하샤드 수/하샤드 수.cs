using System.Linq;
using System;
public class Solution {
    public bool solution(int x) {
        int ad = 0;
    var sum = x.ToString().ToList().Select(c=>int.Parse(c.ToString())).Sum();
    
      
        
      
        
        return x%sum == 0 ? true :false;
    }
}