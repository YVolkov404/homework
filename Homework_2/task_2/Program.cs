using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Используя Visual Studio, создайте проект по шаблону Console Application.

    Напишите программу, которая будет рассчитывать процент скидки в зависимости от количества купленного товара:
      >_ если куплено 3 либо меньше единиц товара, то скидка должна быть 10 процентов от общей суммы,
      >_ иначе - если куплено больше 3, но меньше 7 единиц товара, то скидка должна быть 20 процентов от общей суммы,
      >_ иначе - если куплено 7 или больше единиц товара, то скидка должна быть 25 процентов от общей суммы.

    Цена и общее количество купленного товара задаются пользователем. */

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates your discount on the goods");

            Console.WriteLine(new string('+', 50));

            Console.Write("Input amount of goods: ");
            string amountOfGoods = Console.ReadLine();
            int item = int.Parse(amountOfGoods);

            Console.WriteLine(new string('.', 50));

            Console.Write("Input the price on the good: ");
            string priceOnGood = Console.ReadLine();
            double price = double.Parse(priceOnGood);

            Console.WriteLine(new string('-', 50));

            int discount1 = 10;
            int discount2 = 20;
            int discount3 = 25;

            if (item <= 3) {

                Console.WriteLine("The discount is: " + discount1 + "%");
                Console.WriteLine(new string('.', 50));
                double amountOfDiscount = (item * price * discount1) / 100;
                Console.WriteLine("The amount of discount is: " + "{0:N}", amountOfDiscount);

            }

            else if (item < 7) {

                Console.WriteLine("The discount is: " + discount2 + "%");
                Console.WriteLine(new string('.', 50));
                double amountOfDiscount = (item * price * discount2) / 100;
                Console.WriteLine("The amount of discount is: " + "{0:N}", amountOfDiscount);

            }

            else {

                Console.WriteLine("The discount is: " + discount3 + "%");
                Console.WriteLine(new string('.', 50));
                double amountOfDiscount = (item * price * discount3) / 100;
                Console.WriteLine("The amount of discount is: " + "{0:N}", amountOfDiscount);

            }

            Console.WriteLine(new string('+', 50));
        }
    }
}
