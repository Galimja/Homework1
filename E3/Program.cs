using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Кабылбеков Галымжан
  а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
метода
 */
namespace E3
{
    internal class Program
    {
        static double ReadCoord(string name)
        {
            Console.Write(name);
            return double.Parse(Console.ReadLine());
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            
            double x1 = ReadCoord("Введите x1 ");
            double y1 = ReadCoord("Введите y1 ");
            double x2 = ReadCoord("Введите x2 ");
            double y2 = ReadCoord("Введите y2 ");

            double r = Distance(x1, y1, x2, y2);
            Console.WriteLine("Расстояние между двумя точками - {0:F2}", r);
            Console.ReadLine();
        }
    }
}
