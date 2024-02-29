using System.Linq;
using System;

public class Solution {
    public string solution(string s) {
        string answer =  new string(s.OrderByDescending(c => c).ToArray());
      
        return answer;
    }
}