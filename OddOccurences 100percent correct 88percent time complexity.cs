using System;
using System.Linq;
// you can also use other imports, for example:
 using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
          int value = (A)
             .ToLookup(x => x)
             .Where(xs => xs.Count()%2==1)
             .First()
             .Key;
        return value;
       }           
    }