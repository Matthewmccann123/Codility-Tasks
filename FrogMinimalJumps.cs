using System;
// you can also use other imports, for example:
 using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        if (X==Y || D==0)
        return 0;
        
        if (X<Y){
            //Console.WriteLine("Target: " + Y + " Starting " + X + " Distance " + D);
            decimal calc = ((decimal)Y-(decimal)X)/(decimal)D;
            return (int)Math.Ceiling(calc);
        }
        else return -1;
    }
}