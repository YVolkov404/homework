using System;

/*Используя Visual Studio, создайте проект по шаблону Console Application.
    ._ Напишите программу, в которой создайте переменную  'a'. Значение переменной 'а' должен задавать пользователь.
    ._ Если а < 10 то выведите 'Верно', а иначе (a > 10) выведите 'Неверно'. */ 

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program returns the value");
            Console.WriteLine(new string('-', 30));

            Console.Write("Input the value: ");
            string a = Console.ReadLine();
            double value = double.Parse(a);

            Console.WriteLine(new string('·', 30));


            if (value < 10)
            {
                Console.WriteLine("Input is true!");
            }
            else
            {
                Console.WriteLine("Input is false!");
            }

            Console.WriteLine(new string('-', 30));
        }
    }
}
