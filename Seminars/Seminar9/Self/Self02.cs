using System;
using System.Runtime.Serialization;
class asd {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        Random rnd = new Random();
        for (int i = 0; i < N; ++i) {
            A[i] = rnd.Next(-2, 7 + 1);
        }
        for (int i = 0; i < N; ++i) {
            Console.WriteLine(A[i]);
        }
    }
} 
