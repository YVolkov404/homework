using System;

/* Используя Visual Studio, создайте проект по шаблону Console Application. 
    Напишите программу, которая решает квадратное уравнение ах^2 + bх + с = 0. 
    >_ Пользователь должен ввести коэффициенты а, b и с 
    >_ Программа должна вывести на консоль все корни этого уравнения либо сообщение о том, что их нет. 
    >_ Рассмотреть случаи когда дискриминант квадратного уравнения D > 0, D < 0 и D = 0. */

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('+', 41));

            Console.WriteLine("._ Дискриминант квадратного уравнения");

            Console.WriteLine(new string('+', 41));

            Console.Write("?_ введите значение переменной 'a': ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("?_ введите значение переменной 'b': ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("?_ введите значение переменной 'c': ");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c; // вычисляем дискриминант
            double x1, x2, x3; // корни квадратного уравнения

            Console.WriteLine(new string('-', 41));

            if (d > 0)
            {
                x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine(string.Format(@"!_ уравнение имеет 2 корня: {0:N}, {1:N}", x1, x2));               
            } 
            else if (d == 0)
            {
                x3 = (-b) / (2 * a);

                Console.WriteLine(string.Format(@"!_ уравнение имеет 1 корень: {0:N}", x3));
            }
            else if (d < 0)
            {
                Console.WriteLine("!_ уравнение не имеет корней");
            }

            Console.WriteLine(new string('+', 41));
        }
    }
}
