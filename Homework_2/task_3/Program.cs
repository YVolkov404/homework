using System;

/* Используя Visual Studio, создайте проект по шаблону Console Application.  
    Необходимо написать программу, в которой: 
      >_ создать переменную с именем ' min'; 
      >_ значение переменной должно задаваться пользователем;
      >_ интервал допустимых значений переменной от 0 до 59 [необходимо организовать проверку на ввод допустимого интервала]; 
    Определить в какую  четверть часа  попадает значение переменной: в первую, вторую, третью или четвертую. */

namespace task_3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Скільки часу вам знадобилось на інтервью?: ");
            string min = Console.ReadLine();
            double minHour = double.Parse(min);

            double startHour = 0;
            double endHour = 59;
            double qPast= 15; //qPast --> quater to past 'hour'
            double hPast= 30; //hPast --> half past 'hour'
            double qHour = 45; //qHour --> quater to 'hour'

            if (minHour < endHour) {

                if (minHour > startHour && minHour < qPast){

                    Console.WriteLine("Швидко та по справі як український хаймарс. Чверті години не минуло");
                }
                else if (minHour > qPast && minHour < hPast)
                {
                    Console.WriteLine("Непогано впорались - майже ідеал! Друга чверть години за вами");
                }
                else if (minHour > hPast && minHour < qHour)
                {
                    Console.WriteLine("На 'усьо-про-всьо' біля 45ти хвилин. Тому годі й балакати!");
                } else
                {
                    Console.WriteLine("Мабуть ще й за 'життя-буття' розмова була. Майже година!");
                }

            } else {
                Console.WriteLine("Кепські справи! Перебільшено ліміт часу");
            }
        }
    }
}