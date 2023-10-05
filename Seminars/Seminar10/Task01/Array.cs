using System;
namespace ArrayNameSpace {
    class ArrayClass {
        public static void ArrayFill(ref double[] Array) {
            Random rnd = new Random();
            for (int i = 0; i < Array.Length; ++i) {
                Array[i] = rnd.NextDouble() * 24.5 - 12.25;
            }
        }

        public static void ArrayPrint(double[] Array) {
            for (int i = 0; i < Array.Length; ++i) {
                Console.Write(Array[i] + " ");
            }
        }

    }
}
