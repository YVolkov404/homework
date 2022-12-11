using System;

// Используя Visual Studio, создайте проект по шаблону Console Application.
// Имеются 3 переменные типа int x = 10, y = 12, и z = 3;
// Рассчитайте результаты следующих операций:

// x += y - x++ * z;
// z = --x – y * 5;
// y /= x + 5 % z;
// z = x++ + y * 5;
// x = y - x++ * z;

namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates next examples");

            Console.WriteLine(new string('=', 37));

            int x = 10, y = 12, z = 3;

            Console.WriteLine($"._____: {"x += y - x++ * z"} ---> {x - x - y - ((x++) * z)}");
            Console.WriteLine($"._____: {"z = --x - y * 5"} ----> {z - (--x) + (y * 5)}");
            Console.WriteLine($"._____: {"y /= x + 5 % z"} -----> {y - (y / x) - (5 % z)}");
            Console.WriteLine($"._____: {"z = x++ + y * 5"} ----> {z - (x++) - (y * 5)}");
            Console.WriteLine($"._____: {"x = y - x++ * z"} ----> {x - y + ((x++) * z)}");

            Console.WriteLine(new string('_', 37));
        }
    }
}
