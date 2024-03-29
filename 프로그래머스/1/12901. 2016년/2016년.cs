using System;
public class Solution {
    public string solution(int a, int b) {
        int idx =0;
        string[] arr = new string[]{"THU","FRI","SAT","SUN","MON","TUE","WED"};
        int[] days = new int[]{31,29,31,30,31,30,31,31,30,31,30,31};
        string answer = "";
        int sum = 0;
        for(int i = 1; i<a;i++){
            sum += days[i-1];
        }
        
        sum += b;
 
        return answer = arr[sum%7];
    }
}