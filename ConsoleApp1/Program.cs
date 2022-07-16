using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Введите первое число");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение 4.Деление");
                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Сложение");
                        Console.WriteLine(num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine("Вычитание");
                        Console.WriteLine(num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine("Умножение");
                        Console.WriteLine(num1 * num2);
                        break;
                    case 4:
                        Console.WriteLine("Деление");
                        Console.WriteLine(num1 / num2);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
            
    }
}
