using System;

// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Создать программу для определения гипотенузы прямоугольного треугольника, используя формулу с = √(𝑎^2 + 𝑏^2), где 'с' – гипотенуза, 'а' и 'b' - катеты прямоугольного треугольника.
// Ввод значений катетов должен производить пользователь. 

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the hypotenuse of a right-angle triangle");

            Console.WriteLine(new string('=', 64));

            Console.Write(">_ Input the first leg value: ");
            string firstLegValue = Console.ReadLine();
            double firstValue = double.Parse(firstLegValue);

            Console.WriteLine(new string('-', 64));

            Console.Write(">_ Input the second leg value: ");
            string secondLegValue = Console.ReadLine();
            double secondValue = double.Parse(secondLegValue);

            Console.WriteLine(new string('-', 64));

            double hypotenuseValue = Math.Sqrt(Math.Pow(firstValue, 2) + Math.Pow(secondValue, 2)); // calculate the hypotenuse of a right-angle triangle

            Console.Write("<_ The hypotenuse of a right-angle triangle: ");
            Console.WriteLine("{0:N}", hypotenuseValue);

            Console.WriteLine(new string('=', 64));
        }
    }
}
