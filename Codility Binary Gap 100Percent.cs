using System;
// you can also use other imports, for example:
 using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
       string result = Convert.ToString(N, 2);
       bool startCounter = false;
       int maxCounter = 0;
       int currentCounter = 0;
       foreach(char c in result){
           if (c.Equals('1')){
               if (currentCounter > maxCounter){
                       maxCounter = currentCounter;
                }
                  startCounter = true;
                  currentCounter = 0;
                  continue;
               }
           else{
                   currentCounter++;
               }
               
           }
            return maxCounter;
       }
    }