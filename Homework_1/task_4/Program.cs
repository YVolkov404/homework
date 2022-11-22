using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Создать программу для определения синуса угла: ввод величины угла должен осуществлять пользователь.

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the sinus angle");

            Console.WriteLine(new string('=', 39));

            Console.Write(">_ Input the angle: ");
            string angle = Console.ReadLine();
            double value = double.Parse(angle);

            Console.WriteLine(new string('-', 39));

            double sinusAngle = Math.Sin(value); // calculate the sinus angle

            Console.Write("<_ The sinus angle: ");
            Console.WriteLine("{0:N}", sinusAngle);

            Console.WriteLine(new string('=', 39));
        }
    }
}
