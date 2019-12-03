using System;
using System.Linq;

namespace Rezolvari
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a method that reads from the console three numbers of type int and prints their sum.
            //  Sum();

            //2. Write a method that reads five numbers from the console and prints the greatest of them.
            // Greatest();

            //3. Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
            // Cerc();

            // 4. Write a method that reads from the console two integer numbers(int) and prints
            //how many numbers between them exist that are divisible with 5.
            //such that the remainder of their division by 5 is 0.
            // Counter();

            //5.Write a method that reads two numbers from the console and prints the greater of them.
            //Solve the problem without using conditional statements and with conditional statements.
            // NrMaiMare();

            // 7.Write a method that prints on the console the numbers from 1 to N. 
            // The number N should be read from the standard input.
            // Numbers();

            // 8. Write a method that prints on the console the numbers from 1 to N,
            // which are not divisible by 3 and 7 simultaneously. 
            // The number N should be read from the standard input.
            //  NumbersDivisible();

            // 9. Write a method that reads from the console a series of 5 integers and prints the smallest and largest of them.
            // MareMic();

            //10. Write method that outputs a triangle made of stars with variable size, 
            //depending on an input parameter.Look at the examples to get an idea.
            //The input comes as a string number, which needs to be parsed to a number.
            //The output is a series of lines printed on the console, forming a triangle of variable size.
            //Input 2:   
            //Output:   
            //*  
            //**
            //*
            //Triangle();

            // 11 * .Write a method that converts a given number from decimal to binary notation(numeral system).
            // DecToBin();

            // 12*. Write a method that by a given integer N prints the numbers from 1 to N in random order
            // RandomPrint();

            //13*. A method which iterates the integers from 1 to 50 For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
            // For numbers which are multiples of both three and five print "FizzBuzz".
            // Output : 
            // fizzbuzz
            // 1
            // 2
            // fizz
            // 4 
            // buzz
            // FizzBuzz();

            // 14 A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.
            // Write a program that reads information about the company and its manager and then prints it on the console.
            CompanyManager();
        }

        //1. Write a method that reads from the console three numbers of type int and prints their sum.
        static void Sum()
        {
            Console.WriteLine("Introduceti primul numar:");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar:");
            int nr3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma numerelor introduse este: " + (nr1 + nr2 + nr3));
        }

        //2. Write a method that reads five numbers from the console and prints the greatest of them.
        static void Greatest()
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
            Console.WriteLine("Cel mai mare numar introdus este " + max);
        }

        //3. Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
        static void Cerc()
        {
            Console.WriteLine("Introduceti Raza unui cerc:");
            int raza = int.Parse(Console.ReadLine());
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
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            int nr2 = int.Parse(Console.ReadLine());
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
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            int nr2 = int.Parse(Console.ReadLine());
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


        //10. Write method that outputs a triangle made of stars with variable size, 
        //depending on an input parameter.Look at the examples to get an idea.
        //The input comes as a string number, which needs to be parsed to a number.
        //The output is a series of lines printed on the console, forming a triangle of variable size.
        //Input 2:   
        //Output:   
        //*  
        //**
        //*
        static void Triangle()
        {
            Console.WriteLine("Introduceti un numar:");
            int nr = int.Parse(Console.ReadLine());
            for (int i = 1; i < nr; i++)
            {
                string result = new String('*', i);
                Console.WriteLine(result);
            }
            for (int i = 0; i < nr; i++)
            {
                string result = new String('*', nr - i);
                Console.WriteLine(result);
            }
        }

        // 11 * .Write a method that converts a given number from decimal to binary notation(numeral system).
        static void DecToBin()
        {
            int nr = int.Parse(Console.ReadLine());
            // mai simplu sring binar = Convert.ToString(nr, 2);    
            string rezultat = "";
            while (nr > 1)   
            {
                int rest = nr % 2;
                rezultat = Convert.ToString(rest) + rezultat;
                nr /= 2;
         
            }
            Console.WriteLine(nr.ToString() + rezultat);
        }

        // 12*. Write a method that by a given integer N prints the numbers from 1 to N in random order
        static void RandomPrint()
        {
            Console.WriteLine("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            var numere = Enumerable.Range(1, n).OrderBy(r => rnd.Next()).ToArray();
            Console.Write("Numerele aleatorii sunt: ");
            foreach (var numar in numere)
            {
                
                Console.Write(numar + " ");
            }
        }

        //13*. A method which iterates the integers from 1 to 50 For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
        // For numbers which are multiples of both three and five print "FizzBuzz".
        // Output : 
        // fizzbuzz
        // 1
        // 2
        // fizz
        // 4 
        // buzz

        static void FizzBuzz()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // 14 A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.
        // Write a program that reads information about the company and its manager and then prints it on the console.
        static void CompanyManager()
        {
            Console.WriteLine("Introduceti numele companiei:");
            String numeCompanie = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de telefon al companiei:");
            String telefonCompanie = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de fax al companiei:");
            String faxCompanie = Console.ReadLine();
            Console.WriteLine("Introduceti  siteul al companiei:");
            String siteCompanie = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele Managerului:");
            String prenumenumeManager = Console.ReadLine();
            Console.WriteLine("Introduceti numele Managerului:");
            String numeManager = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de telefon al Managerului:");
            String telefonManager = Console.ReadLine();
            Console.WriteLine($"Datele companiei sunt urmatoarele:\n Nume Companie: {numeCompanie}\n Telefon: {telefonCompanie}\n Fax: {faxCompanie}\n site {siteCompanie}\n Manager: {prenumenumeManager} {numeManager}\n Telefon manager: {telefonManager}");
        }
    }
}
