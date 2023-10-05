using System;
using System.Runtime.Serialization;
class asd {
    static void Main(string[] args) {
        string s = Console.ReadLine();

        int f = 0;
        
        for (int i = 0; i < s.Length; ++i) {
            if (s[i] == ')') f = 0;
            if (f == 1) Console.Write(s[i]);
            if (s[i] == '(') f = 1;
        }
    }
} 
