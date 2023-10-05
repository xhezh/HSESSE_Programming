using System;
using ArrayNameSpace;
class asd {
    static void Main(string[] args) {
        double[] A = new double[20];

        ArrayClass.ArrayFill(ref A);

        ArrayClass.ArrayPrint(A);
    }
} 
