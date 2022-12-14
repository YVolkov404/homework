using System;

// Используя Visual Studio, создайте проект по шаблону Console Application.
// Напишите программу расчёта объема (v) и площади поверхности (s) цилиндра.
// Объем (v) цилиндра радиусом (r) и высотой (h) вычисляется по формуле: v = πr^2h.
// Площадь (s) поверхности цилиндра вычисляется по формуле: s = 2πr(r + h).
// Результаты расчетов выведите на консоль. Пользователь должен иметь возможность вводить (r) радиус и (h) высоту цилинда.

namespace task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates volume & surface area of cylinder");

            Console.WriteLine(new string('+', 57));

            Console.Write(">_ Input the radius of cylinder: ");
            string radius = Console.ReadLine();
            double r = double.Parse(radius);

            Console.WriteLine(new string('-', 57));

            Console.Write(">_ Input the height of cylinder: ");
            string height = Console.ReadLine();
            double h = double.Parse(height);

            Console.WriteLine(new string('=', 57));

            double volume = Math.PI * Math.Pow(r, 2) * h; // calculate the volume of cylinder
            Console.Write("<_ The volume of cylinder: ");
            Console.WriteLine("{0:N}", volume);

            Console.WriteLine(new string('-', 57));

            double area = 2 * Math.PI * r * (r + h); // calculate the area of cylinder
            Console.Write("<_ The area of cylinder: ");
            Console.WriteLine("{0:N}", area);

            Console.WriteLine(new string('+', 57));
        }
    }
}
