using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Используя Visual Studio, создайте проект по шаблону Windows Forms (.Net framework). 
// Создайте программу для расчёта возраста пользователя. Вывести на консоль его текущий возраст (использовать DateTime).

namespace task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This programm calculates the age of the user");

            Console.WriteLine(new string('*', 44));

            Console.Write(">_ Input the user's birthday: ");
            string input = Console.ReadLine();
            int userBirthdaay = int.Parse(input);

            Console.WriteLine(new string('-', 44));

            int userAge = DateTime.Now.Year - userBirthdaay; // calculates the age of the use
            string output = string.Concat("<_ The age of the user: " + userAge);
            Console.WriteLine(output);

            Console.WriteLine(new string('=', 44));
        }
    }
}
