using System;

namespace Rezolvari
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        
        }

        //1. Write a method that reads from the console three numbers of type int and prints their sum.
        static void Sum()
        {
            Console.WriteLine("Introduceti primul numar:");
            String no1 = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea numar:");
            String no2 = Console.ReadLine();
            Console.WriteLine("Introduceti al treilea numar:");
            String no3 = Console.ReadLine();
            int nr1 = int.Parse(no1);
            int nr2 = int.Parse(no2);
            int nr3 = int.Parse(no3);
            Console.WriteLine("Suma numerelor introduse este: " + (nr1 + nr2 + nr3));
        }






    }
}
