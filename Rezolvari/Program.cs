using System;

namespace Rezolvari
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Sum();
            // Greatest();
            // Cerc();
            // Counter();
            // NrMaiMare();
            // Numbers();
            //  NumbersDivisible();
            MareMic();

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

        //2. Write a method that reads five numbers from the console and prints the greatest of them.
        static void Greatest()
        {
            Console.WriteLine("Introduceti primul numar:");
            String no1 = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea numar:");
            String no2 = Console.ReadLine();
            Console.WriteLine("Introduceti al treilea numar:");
            String no3 = Console.ReadLine();
            Console.WriteLine("Introduceti al patrulea numar:");
            String no4 = Console.ReadLine();
            Console.WriteLine("Introduceti al cincilea numar:");
            String no5 = Console.ReadLine();
            int nr1 = int.Parse(no1);
            int nr2 = int.Parse(no2);
            int nr3 = int.Parse(no3);
            int nr4 = int.Parse(no4);
            int nr5 = int.Parse(no5);
            int max = Math.Max(nr1, Math.Max(nr2, Math.Max(nr3, Math.Max(nr4, nr5))));
            Console.WriteLine("Cel mai mare numar introdus este " + max);
        }

        //3. Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
        static void Cerc()
        {
            Console.WriteLine("Introduceti Raza unui cerc:");
            String r = Console.ReadLine();
            int raza = int.Parse(r);
            const double pi = 3.14159;
            double perimetrul = 2 * pi * raza;
            double aria = pi * raza * raza;
            Console.WriteLine("Aria cercului este:" + aria + " si perimetrul cerculului este:" + perimetrul);
        }

        // 4. Write a method that reads from the console two integer numbers(int) and prints
        //how many numbers between them exist that are divisible with 5.
        //such that the remainder of their division by 5 is 0.
        static void Counter()
        {
            Console.WriteLine("Introduceti primul numar:");
            String no1 = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea numar:");
            String no2 = Console.ReadLine();
            int nr1 = int.Parse(no1);
            int nr2 = int.Parse(no2);
            int nrmare = Math.Max(nr1, nr2);
            int nrmic = Math.Min(nr1, nr2);
            int i = nrmic;
            int counter = 0;
            while (i < nrmare)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
                i++;
            }
            Console.WriteLine("Intre " + nrmic + " si " + nrmare + " sunt " + counter + " divizibile cu 5.");
        }

        //5.Write a method that reads two numbers from the console and prints the greater of them.
        //Solve the problem without using conditional statements and with conditional statements.
        static void NrMaiMare()
        {
            Console.WriteLine("Introduceti primul numar:");
            String no1 = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea numar:");
            String no2 = Console.ReadLine();
            int nr1 = int.Parse(no1);
            int nr2 = int.Parse(no2);
            int nrmare = Math.Max(nr1, nr2);
            Console.WriteLine("Numarul mai mare este: " + nrmare);
            if (nr1 > nr2)
            {
                Console.WriteLine("Numarul mai mare este: " + nr1);
            }
            else
            {
                Console.WriteLine("Numarul mai mare este: " + nr2);
            }
        }

        // 7.Write a method that prints on the console the numbers from 1 to N. 
        // The number N should be read from the standard input.
        static void Numbers()
        {
            Console.WriteLine("Introduceti un nr.:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <= n; i++)
            {
                Console.Write(" " + i);
            }
        }

        // 8. Write a method that prints on the console the numbers from 1 to N,
        // which are not divisible by 3 and 7 simultaneously. 
        // The number N should be read from the standard input.

        static void NumbersDivisible()
        {
            Console.WriteLine("Introduceti un nr.:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % (3 * 7) != 0)
                {
                    Console.Write(" " + i);

                }
            }
        }

        // 9. Write a method that reads from the console a series of 5 integers and prints the smallest and largest of them.
        static void MareMic()
        {
            Console.WriteLine("Introduceti primul numar:");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar:");
            int nr3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al patrulea numar:");
            int nr4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al cincilea numar:");
            int nr5 = int.Parse(Console.ReadLine());
            int max = Math.Max(nr1, Math.Max(nr2, Math.Max(nr3, Math.Max(nr4, nr5))));
            int min = Math.Min(nr1, Math.Min(nr2, Math.Min(nr3, Math.Min(nr4, nr5))));
            Console.WriteLine("Cel mai mare numar introdus este " + max);
            Console.WriteLine("Cel mai mic numar introdus este " + min);
        }
    }
}
