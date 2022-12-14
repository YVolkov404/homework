using System;

// Используя Visual Studio, создайте проект по шаблону Console Application.  
// Создайте программу для перевода метров в сантиметры (1м = 100см): ввод метров должен производиться пользователем.

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This programm converts metres to centimetres");

            Console.WriteLine(new string('=', 44)); // just a delimiter

            Console.Write(">_ Input the number in metres: ");
            string metres = Console.ReadLine();
            int m = int.Parse(metres);

            Console.WriteLine(new string('-', 44));

            int result = m * 100; // convert metres to centimetres

            Console.Write("<_ Result in centimetres: ");
            string output = string.Concat(result + " cm");
            Console.WriteLine(output);

            Console.WriteLine(new string('=', 44));
        }
    }
}