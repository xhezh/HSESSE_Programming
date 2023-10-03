using System;
using System.Runtime.Serialization;
class asd {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        int[] U = new int[6] {0, 0, 0, 0, 0, 0};

        Random rnd = new Random();
        for (int i = 0; i < N; ++i) {
            A[i] = rnd.Next(1, 5 + 1);
        }

        for (int i = 0; i < N; ++i) {
            if (U[A[i]] >= 1) {
                A[i] = 0;
            } 
            U[A[i]]++;
        }
        for (int i = 0; i < A.Length; ++i) {
            Console.WriteLine($"A[{i}] = {A[i]}");
        }
    }
} 
