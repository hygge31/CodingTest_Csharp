using System.Linq;
using System;
public class Solution {
    public bool solution(int x) {
        int ad = 0;
    int[] arr = x.ToString().Select(c=>int.Parse(c.ToString())).ToArray();
        
        foreach(int n in arr){
            ad += n;
        }
        
        Console.Write(x);
        
        return x % ad == 0 ? true : false;
    }
}