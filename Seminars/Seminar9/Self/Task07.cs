using System;
using System.Runtime.Serialization;
class asd {
    static void Main(string[] args) {
        int[] A = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        int[] B = {-12, 1, 0, -5, 12, 14, 12, 4, -3, 7};

        int EvCnt = 0;
        for (int i = 0; i < 20; ++i) {
            if (A[i] % 2 == 0) EvCnt++;
        }

        Console.WriteLine(EvCnt);

        int[] C = new int[10 + EvCnt];

        Array.Copy(B, 0, C, 0, 10);

        int cur = EvCnt;
        for (int i = 0; i < 20; ++i) {
            if (A[i] % 2 == 0) Array.Copy(A, i, C, 10 + --cur, 1);
        }

        for (int i = 0; i < 10 + EvCnt; ++i) {
            Console.Write(C[i] + " ");
        }
    }
} 
