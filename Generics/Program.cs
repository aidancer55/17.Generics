using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank<int> number1 = new Bank<int>();
            number1.Input();
            Console.WriteLine(number1.Print());
            Console.WriteLine();
            Bank<string> number2 = new Bank<string>();
            number2.Input();
            Console.WriteLine(number2.Print());
            Console.ReadKey();
        }
    }
}
