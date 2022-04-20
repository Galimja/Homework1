using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Кабылбеков Галымжан
 Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
 I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
 */
namespace E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес в кг:");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах:");
            double h = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Индекс массы тела = {m / (h * h)}");
            Console.ReadLine();
        }
    }
}
