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

            int variable1 = 666, variable2 = 225;

            Console.Write("[+] addition       _: ");
            Console.WriteLine(string.Format($"{variable1} + {variable2} = {variable1 + variable2}")); // addition 

            Console.Write("[-] subtraction    _: ");
            Console.WriteLine(string.Format($"{variable1} - {variable2} = {variable1 - variable2}")); // subtraction

            Console.Write("[*] multiplication _: ");
            Console.WriteLine(string.Format($"{variable1} * {variable2} = {variable1 * variable2}")); // multiplication

            Console.Write("[/] division       _: ");
            Console.WriteLine(string.Format($"{variable1} / {variable2} = {variable1 / variable2}")); // division 

            Console.Write("[%] reminder       _: ");
            Console.WriteLine(string.Format($"{variable1} % {variable2} = {variable1 % variable2}")); // reminder 

            Console.ReadLine();
        }
    }
}
