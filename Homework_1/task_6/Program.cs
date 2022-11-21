using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Используя Visual Studio, создайте проект по шаблону Console Application.
// Написать программу для расчёта скидки на товар, скидку и цену товара должен вводить пользователь.

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate a discount on the merch");

            Console.WriteLine(new string('+', 33));

            Console.Write(">_ Input the price: ");
            string price = Console.ReadLine();
            double value1 = Convert.ToDouble(price);

            Console.WriteLine(new string('-', 33));

            Console.Write(">_ Enter the dicount: ");
            string discount = Console.ReadLine();
            double value2 = Convert.ToDouble(discount);

            Console.WriteLine(new string('+', 33));

            double value = (value1 * value2) / 100;
            Console.Write("<_ A discount on the merch: ");
            Console.WriteLine("{0:N}", value);

            Console.WriteLine(new string('-', 33));
        }
    }
}
