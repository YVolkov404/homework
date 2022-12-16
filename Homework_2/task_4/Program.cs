using System;

/* Используя Visual Studio, создайте проект по шаблону Console Application. 
    Напишите программу, в которой пользователь вводит целое число, а программа в свою очередь должна ответить:
        >_ четным или нечетным является это число,
        >_ делится ли число на 3 и делится ли оно на 6. */

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('+', 55));

            Console.Write("Enter the integer number: ");
            int n = int.Parse(Console.ReadLine());

            int z = n % 2;
            int x = n % 3;
            int y = n % 6;

            Console.WriteLine(new string('-', 55));

            if (z == 0) {
                Console.WriteLine("This number is even");
            } else {
                Console.WriteLine("This number is odd");
            }

            Console.WriteLine(new string('-', 55));

            if (x == 0 & y == 0) {
                Console.WriteLine("Number divided by 3 and divided by 6");
            } else if (x !=0 & y == 0) {
                Console.WriteLine("Number is not divisible by 3, but divided by 6");
            } else if (x == 0 & y != 0) {
                Console.WriteLine("Number divided by 3 but is not divisible by 6");
            } else if (x != 0 & y != 0) {
                Console.WriteLine("Number is not divisible by 3 and is not divisible by 6");
            }

            Console.WriteLine(new string('+', 55));
        }
    }
}
