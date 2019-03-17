using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Witaj :)");

             Console.Write("Podaj swoje imię: ");
             string imie = Console.ReadLine();
             Console.WriteLine($"Cześć {imie} !!");
             Console.Write("Podaj wiek: ");
             int wiek = Convert.ToInt16(Console.ReadLine());
             if (wiek < 18)
             {
                 Console.WriteLine("Niepełnoletni");
             } else
             {
                 Console.WriteLine("Pełnoletni");
             }

             // 0 1 1 2 3 5 8 

             Console.WriteLine("Generator n liczb ciągu Fibbonaciego");
             Console.Write("Podaj n liczbe ciągu: ");
             int n = Convert.ToInt32(Console.ReadLine());
             int a = 0;
             int b = 1;
             if (n >= 1)
             {
                 Console.Write($" {a}");
                 if(n >= 2)
                 {
                     Console.Write($" {b}");
                     if(n > 2)
                     {
                         for(int i=0; i<n; i++)
                                     {
                                         int y = b;
                                         b = a + b;
                                         a = y;
                                         Console.Write($" {b} ");

                                     }
                     }
                 }
             } */


            Console.WriteLine("Kalkulator V1");
            Console.WriteLine("Wybierz działanie: 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie, 5 - potęgowanie");
            Console.Write("Działanie: ");
            int operation = Convert.ToInt16(Console.ReadLine());
            if (operation == 1)
            {
                Console.Write("Podaj a: ");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.Write("Podaj b: ");
                int b = Convert.ToInt16(Console.ReadLine());


            }

            

            

        }
    }
}
