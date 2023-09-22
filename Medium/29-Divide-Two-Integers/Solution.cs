using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeExercises.Medium.DivideTwoIntegers
{
    public class Solution
    {
        public int Divide(int dividend, int divisor) 
        {
          long quotient = 0;
          var flag = (dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0) ? -1 : 1;
          long dividendL = Math.Abs((long)dividend);
          long divisorL = Math.Abs((long)divisor);
          
          while(dividendL >= divisorL){
              int n = 0;
              while(dividendL >= (divisorL << n)){
                  n++;
              }
              quotient += 1L << (n - 1);
              dividendL -= divisorL << (n - 1);
          }
        
          if(flag == -1 ) {
              quotient = -quotient;
          }
          
          if(quotient > 2147483647){
              return 2147483647;
          }
          if(quotient < -2147483648){
              return -2147483648;
          }
          return (int)quotient;
      }
    }
}