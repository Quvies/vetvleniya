using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Задача 1
            Console.WriteLine("Задача 1");
            Console.Write("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Два числа равны");
            }

            if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго числа");
            }

            else
            {
                Console.WriteLine("Первое число меньше второго числа");
            }

            Console.WriteLine();

            // Задача 2
            Console.WriteLine("Задача 2");
            Console.Write("Введите число:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            if (number1 > 5 && number1 < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }

            else
            {
                Console.WriteLine("Неизвестное число");
            }

            Console.WriteLine();

            // Задача 3
            Console.WriteLine("Задача 3");
            Console.Write("Введите число:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (number2 == 5 || number2 == 10)
            {
                Console.WriteLine("Число либо равно 5 либо равно 10");
            }

            else
            {
                Console.WriteLine("Неизвестное число");
            }

            Console.WriteLine();


        }
    }
}
