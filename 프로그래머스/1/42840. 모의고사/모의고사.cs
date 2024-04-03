using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[]{};
        
        int[] p1 = new int[]{1,2,3,4,5};
        int[] p2 = new int[]{2,1,2,3,2,4,2,5};
        int[] p3 = new int[]{3,3,1,1,2,2,4,4,5,5};
      
        int p1a= 0;
        int p2a= 0;
        int p3a= 0;
        
     for(int i = 0; i < answers.Length; i++){
        if( answers[i] == p1[ i % p1.Length ]) p1a++; 
        if( answers[i] == p2[ i % p2.Length ]) p2a++; 
        if( answers[i] == p3[ i % p3.Length ]) p3a++; 
    }
        int[] arr = new int[]{p1a,p2a,p3a};
        int max =arr.Max();
        List<int> list = new List<int>();
        
        if(p1a == max) list.Add(1);
        if(p2a == max) list.Add(2);
        if(p3a == max) list.Add(3);
 
        return list.ToArray();
    }
}