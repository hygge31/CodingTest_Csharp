using System;

class Solution
{
    public int solution(int[] nums)
    {

        int answer = 0;
      for(int i = 0;i<nums.Length-2;i++){
          for(int j = i+1;j<nums.Length-1;j++){
              for(int k = j+1;k<nums.Length;k++){
                  int sum = 0;
                  sum += nums[i] + nums[j] + nums[k];
                  if(Prime(sum)){
                      answer++;
                  }
              }
          }
      }

        return answer;

    }

       public bool Prime(int num){
        for(int i = 2; i<num;i++){
            if(num%i == 0)
            {
            return false;
            }
        }
           Console.Write(num);
           return true;
    }

}