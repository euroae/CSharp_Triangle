using System;
// you can also use other imports, for example:
using System.Collections;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Array.Sort(A);
        
        for (int x= 0;x+2<A.Length;x++)
        {
            if(((long)A[x]+(long)A[x+1])>(long)A[x+2])
                return 1;
        }
        
        return 0;
    }
}
