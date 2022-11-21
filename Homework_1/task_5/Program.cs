using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте две целочисленные переменные и выведите на экран результаты всех арифметических операций над этими двумя переменными.

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The five operations used for arithmetic");

            Console.WriteLine(new string('*', 40));

            int variable1 = 666;
            int variable2 = 225;

            Console.Write("[+] addition       _: ");
            int addition = variable1 + variable2;
            Console.WriteLine(string.Format("{0} + {1} = {2}", variable1, variable2, addition));

            Console.Write("[-] subtraction    _: ");
            int subtraction = variable1 - variable2;
            Console.WriteLine(string.Format("{0} - {1} = {2}", variable1, variable2, subtraction));

            Console.Write("[*] multiplication _: ");
            int multiplication = variable1 * variable2;
            Console.WriteLine(string.Format("{0} * {1} = {2}", variable1, variable2, multiplication));

            Console.Write("[/] division       _: ");
            int division = variable1 / variable2;
            Console.WriteLine(string.Format("{0} / {1} = {2}", variable1, variable2, division));

            Console.Write("[%] reminder       _: ");
            int reminder = variable1 % variable2;
            Console.WriteLine(string.Format("{0} % {1} = {2}", variable1, variable2, reminder));

            Console.ReadLine();
        }
    }
}
