using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Bank<T>
    {
        public T Num { get; set; }
        public uint Balance { get; set; }
        public string Name { get; set; }
        public string Print()
        {
            return $"{Num} {Balance} {Name}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine();
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
