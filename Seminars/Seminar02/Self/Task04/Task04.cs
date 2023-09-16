using System.Threading.Tasks.Dataflow;
using System;

class LoL { 
    static void Main() {
        char x = char.Parse(Console.ReadLine());
        if (char.IsDigit(x)) {
            Console.WriteLine("Это цифра");
        }
        else if (char.IsLetter(x)) {
            Console.WriteLine("Это буква");
        }
        else {
            Console.WriteLine("Это ни буква, ни цифра");
        }
    }
}
