using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Кабылбеков Галымжан
 * Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.
*/

namespace E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Напишите вашу Фамилию:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Напишите ваш возраст:");
            string age = Console.ReadLine();
            Console.WriteLine("Напишите ваш рост:");
            string height = Console.ReadLine();
            Console.WriteLine("Напишите ваш вес:");
            string weight = Console.ReadLine();
            Console.WriteLine(name + ", " + lastName + ", возраст: " + age + ", рост: "
                              + height + ", вес: " + weight);
            Console.WriteLine("{0}, {1}, возраст: {2}, рост: {3}, вес: {4}",
                              name, lastName, age, height, weight);
            Console.WriteLine($"{name}, {lastName}, возраст: {age}, рост: {height}, вес: {weight}");
            Console.ReadLine();
        }
    }
}
