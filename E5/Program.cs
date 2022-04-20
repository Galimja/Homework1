using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Кабылбеков Галымжан
 а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организовать в центре экрана.
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 */
namespace E5
{
    
    internal class Program
    {
        static void PrintMsg(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            string msg = "Галымжан Кабылбеков, город Нур-Султан";

            PrintMsg(msg, Console.WindowWidth / 3, Console.WindowHeight / 2);

            Console.ReadLine();
        }
    }
}
