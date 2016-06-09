using System;
// you can also use other imports, for example:
 using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        int[] newArray = new int[A.Length];
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (A.Length == 0 || K == 0 || A.Length == 1 || K == A.Length){
            return A;
        }
        //Reducing fully looping around multiple times.
        K = K%A.Length;
        for(int i = 0; i < A.Length; i++){
           if(i-K >= 0){
               newArray[i] = A[i-K];
            }
            else{
             newArray[i] = A[A.Length + (i-K)];   
            }
        }
        return newArray;
    }
}