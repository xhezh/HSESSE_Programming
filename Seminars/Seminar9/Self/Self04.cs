using System;
using System.Runtime.Serialization;
class asd {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];
        Random rnd = new Random();
        for (int i = 0; i < N; ++i) {
            A[i] = rnd.Next(-2, 7 + 1);
        }
        int IndB = 0, IndC = 0;
        for (int i = 0; i < N; ++i) {
            if (A[i] % 2 == 0) {
                Array.Copy(A, i, B, IndB++, 1);
            }
            else {
                Array.Copy(A, i, C, IndC++, 1);
            }
        }
        for (int i = 0; i < B.Length; ++i) {
            Console.WriteLine($"B[{i}] = {B[i]}");
        }
        for (int i = 0; i < C.Length; ++i) {
            Console.WriteLine($"C[{i}] = {C[i]}");
        }
    }
} 
