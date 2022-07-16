using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    Console.WriteLine(y + z);

                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    Console.WriteLine(y - z);
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    Console.WriteLine(y * z);
                    break;
                default:
                    Console.WriteLine("Вы ввели неверное значение");
                    break;

            }

            Console.ReadKey();
        }
    }
}
