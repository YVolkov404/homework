using System;

/* Используя Visual Studio, создайте проект по шаблону Console Application.
    Написать программу, которая определяет, является ли год високосным. 
    Пользователь вводит год, а программа должна вывести на экран ответ: является ли год високосным. 
    !_Подсказка: 
        >_ год, номер которого кратен 400, — високосный;
        >_ остальные годы, номер которых кратен 100, — невисокосные (например, годы 1700, 1800, 1900, 2100, 2200, 2300);
        >_ остальные годы, номер которых кратен 4, — високосные;
        >_ все остальные годы — невисокосные. */

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('=', 27));

            Console.WriteLine("Является ли год високосным?");

            Console.WriteLine(new string('=', 27));

            Console.Write("Введите год: ");
            int y = int.Parse(Console.ReadLine());

            int n = y % 400;
            int b = y % 4;

            Console.WriteLine(new string('-', 27));

            if (n != 0 & b != 0)
            {
                Console.WriteLine("Этот год невисокосный!");
            }
            else
            {
                Console.WriteLine("Этот год високосный!");
            }

            Console.WriteLine(new string('=', 27));
        }
    }
}
