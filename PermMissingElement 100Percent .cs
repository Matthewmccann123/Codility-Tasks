using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int[] tempArray = new int[A.Length];
        int num = 1;
        if (A.Length == 0){
            return 1;
        }
        int count = 0;
        foreach (var item in A.OrderBy(x => x))
            {
                tempArray[count] = item; 
                count++;
            }
        
        int count2= 0;
        for (int i = 0; i < A.Length; i++){
            if(num!=tempArray[count2]){
                return num;
            }
            num++;
            count2++;
        }
        return num;
             
    }
}