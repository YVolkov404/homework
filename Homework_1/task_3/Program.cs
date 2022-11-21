using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Создать программу для определения гипотенузы прямоугольного треугольника, используя формулу с = √(𝑎^2 + 𝑏^2), где 'с' – гипотенуза, 'а' и 'b' - катеты прямоугольного треугольника.
// Ввод катетов должен осуществлять пользователь. 

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the hypotenuse of a right-angle triangle");

            Console.WriteLine(new string('=', 64));

            Console.Write("Input the first leg value: ");
            string firstLegValue = Console.ReadLine();
            double firstValue = Convert.ToDouble(firstLegValue);

            Console.WriteLine(new string('-', 64));

            Console.Write("Input the second leg value: ");
            string secondLegValue = Console.ReadLine();
            double secondValue = Convert.ToDouble(secondLegValue);

            Console.WriteLine(new string('-', 64));

            double hypotenuseValue = Math.Sqrt(Math.Pow(firstValue, 2) + Math.Pow(secondValue, 2)); // calculate the hypotenuse of a right-angle triangle

            Console.Write("The hypotenuse of a right-angle triangle: ");
            Console.WriteLine("{0:N}", hypotenuseValue);

            Console.WriteLine(new string('=', 64));
        }
    }
}
