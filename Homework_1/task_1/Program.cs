using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Создайте программу для перевода метров в сантиметры (1м = 100см): ввод метров должен осуществлять пользователь.

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This programm converts metres to centimetres");

            Console.WriteLine(new string('=', 44));

            Console.Write(">_ Input the number in metres: ");
            string metres = Console.ReadLine();
            int m = Convert.ToInt32(metres);

            Console.WriteLine(new string('-', 44));

            int result = m * 100; // convert metres to centimetres

            Console.Write("<_ Result in centimetres: ");
            string output = string.Concat(result + " cm");
            Console.WriteLine(output);

            Console.WriteLine(new string('=', 44));
        }
    }
}