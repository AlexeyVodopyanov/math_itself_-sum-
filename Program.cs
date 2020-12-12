using System;
using static System.Console;
namespace ConsoleApp5
{
    class Program
    {
        
        static void Main()
        {
            WriteLine("Привет!");
            Write("Пишите число ");
            int a;
            a = Convert.ToInt32(ReadLine());
            WriteLine();
            Write("Пишите число ");
            int b = Convert.ToInt32(ReadLine());
            Write($"{a} + {b} = ");
            int c = Convert.ToInt32(ReadLine());
            
            
            if (a + b == c)
            {
                WriteLine("Верно");
            }
            else
            {
                WriteLine("Не верно");
            }
            
        }
    }
}
