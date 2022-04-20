using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Кабылбеков Галымжан
 4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
а) с использованием третьей переменной;
б) *без использования третьей переменной.
 */
namespace E4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 10;
            b = 20;
            Console.WriteLine($"Первое чисо = {a}, Второе чило = {b}");

            #region Меняем местами значения с использованием 3 переменной
            c = a;
            a = b;
            b = c;
            #endregion
            Console.WriteLine($"Первое чисо = {a}, Второе чило = {b}");

            #region Меняем местами значения без использования 3 переменной
            a += b;
            b = a - b;
            a = a - b;
            #endregion
            Console.WriteLine($"Первое чисо = {a}, Второе чило = {b}");
            Console.ReadLine();

        }
    }
}
