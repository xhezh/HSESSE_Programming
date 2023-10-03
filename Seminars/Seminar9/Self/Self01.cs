using System;
using System.Runtime.Serialization;
class asd {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        for (int i = 0; i < N; ++i) {
            A[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; ++i) {
            Console.WriteLine(A[i]);
        }
    }
} 
