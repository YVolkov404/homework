using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Создайте константу с именем 'pi' (π - число «пи»), создайте переменную c именем 'r' (радиус). 
// Используя формулу πR^2, вычислите площадь круга и выведите результат на экран.

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the area of a circle");

            Console.WriteLine(new string('=', 44));

            Console.Write(">_ Input radius: ");
            string radius = Console.ReadLine();
            double r = Convert.ToDouble(radius);

            Console.WriteLine(new string('-', 44));

            double result = Math.PI * Math.Pow(r, 2); // calculate the area of a circle

            Console.Write("<_ The area of a circle: ");
            Console.WriteLine("{0:N}", result);

            Console.WriteLine(new string('=', 44));
        }
    }
}